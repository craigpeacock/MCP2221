using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;
using mcp2221_dll_m;

namespace TestApp1
{
    public partial class MainForm : Form
    {
        static int result = 0;
        const int DEFAULT_VID = 0x04D8;
        const int DEFAULT_PID = 0x00DD;
        static IntPtr mcpHandle = new IntPtr();

        const uint NumberOfParameters = 19;
        Label[] ParameterName = new Label[NumberOfParameters];
        Label[] ParameterValue = new Label[NumberOfParameters];
        Label[] ParameterUnits = new Label[NumberOfParameters];
        Label[] ParameterDescription = new Label[NumberOfParameters];

        const byte bq769xxCELL1VOLT = 0x14;
        const byte bq769xxCELL2VOLT = 0x16;
        const byte bq769xxCELL3VOLT = 0x18;
        const byte bq769xxCELL4VOLT = 0x1A;
        const byte bq769xxCELL5VOLT = 0x1C;
        const byte bq769xxCELL6VOLT = 0x1E;
        const byte bq769xxCELL7VOLT = 0x20;
        const byte bq769xxCELL8VOLT = 0x22;
        const byte bq769xxCELL9VOLT = 0x24;
        const byte bq769xxCELL10VOLT = 0x26;
        const byte bq769xxCELL11VOLT = 0x28;
        const byte bq769xxCELL12VOLT = 0x2A;
        const byte bq769xxCELL13VOLT = 0x2C;
        const byte bq769xxCELL14VOLT = 0x2E;
        const byte bq769xxCELL15VOLT = 0x30;
        const byte bq769xxCELL16VOLT = 0x32;

        const byte bq769xxSTACKVOLT = 0x34;
        const byte bq769xxPACKVOLT = 0x36;
        const byte bq769xxLOADVOLT = 0x38;

        public MainForm()
        {
            InitializeComponent();

            // Enumerate MCP2221 Devices and list Serial Numbers
            GetMCP2221Devices();

            // Set default I2C Speed to 100,000kHz
            cbSpeed.SelectedIndex = 0;

            InitialiseParameters(ParameterName, ParameterValue, NumberOfParameters);

            WriteParameter(0, "Cell 1", "V", "");
            WriteParameter(1, "Cell 2", "V", "");
            WriteParameter(2, "Cell 3", "V", "");
            WriteParameter(3, "Cell 4", "V", "");
            WriteParameter(4, "Cell 5", "V", "");
            WriteParameter(5, "Cell 6", "V", "");
            WriteParameter(6, "Cell 7", "V", "");
            WriteParameter(7, "Cell 8", "V", "");
            WriteParameter(8, "Cell 9", "V", "");
            WriteParameter(9, "Cell 10", "V", "");
            WriteParameter(10, "Cell 11", "V", "");
            WriteParameter(11, "Cell 12", "V", "");
            WriteParameter(12, "Cell 13", "V", "");
            WriteParameter(13, "Cell 14", "V", "");
            WriteParameter(14, "Cell 15", "V", "");
            WriteParameter(15, "Cell 16", "V", "");

            WriteParameter(16, "Stack (VC16)", "V", "");
            WriteParameter(17, "Pack Pin", "V", "");
            WriteParameter(18, "Load Pin", "V", "");

        }

        private void GetMCP2221Devices()
        {
            uint numberOfDevices = 0;

            String libVersion = MCP2221.M_Mcp2221_GetLibraryVersion();

            if (result == MCP2221.M_E_NO_ERR)
            {
                statusStrip1.Items[0].Text = "Library Version: " + libVersion;

                result = MCP2221.M_Mcp2221_GetConnectedDevices(DEFAULT_VID, DEFAULT_PID, ref numberOfDevices);

                if (result == MCP2221.M_E_NO_ERR)
                {
                    if (numberOfDevices > 0)
                    {
                        if (numberOfDevices == 1)
                            statusStrip1.Items[0].Text = statusStrip1.Items[0].Text + ", 1 MCP2221 device found";
                        else
                            statusStrip1.Items[0].Text = statusStrip1.Items[0].Text + ", " + numberOfDevices + " MCP2221 devices found";

                        uint i = 0;
                        while (i < numberOfDevices)
                        {
                            mcpHandle = MCP2221.M_Mcp2221_OpenByIndex(DEFAULT_VID, DEFAULT_PID, i);
                            result = MCP2221.M_Mcp2221_GetLastError();
                            if (result == MCP2221.M_E_NO_ERR)
                            {
                                cbSelectDevice.Items.Add(MCP2221.M_Mcp2221_GetSerialNumberDescriptor(mcpHandle));

                            }
                            result = MCP2221.M_Mcp2221_Close(mcpHandle);
                            if (result > 0)
                            {
                                statusStrip1.Items[0].Text = "Error closing handle during device enumeration";
                            }
                            i++;
                        }
                        // Select first device found
                        cbSelectDevice.SelectedIndex = 0;
                    }
                }
                else if (result == MCP2221.M_E_ERR_DEVICE_NOT_FOUND)
                {
                    statusStrip1.Items[0].Text = statusStrip1.Items[0].Text + ", No MCP2221 devices found";
                }
            }
        }

        private void ReadParameters(IntPtr mcpHandle)
        {
            Int16 value;

            for (int Cell = 0; Cell < 16; Cell++)
            {

                value = (Int16) GetI2CShort(mcpHandle, (byte)(bq769xxCELL1VOLT + (Cell * 2)));
                if (value > 0)
                {
                    ParameterValue[Cell].Text = ((float)value / 1000).ToString("0.000");
                } 
                else
                {
                    ParameterValue[Cell].Text = "0.000";
                }
            }

            value = (Int16)GetI2CShort(mcpHandle, (byte)(bq769xxSTACKVOLT));
            ParameterValue[16].Text = ((float)value / 100).ToString("0.00");

            value = (Int16)GetI2CShort(mcpHandle, (byte)(bq769xxPACKVOLT));
            ParameterValue[17].Text = ((float)value / 100).ToString("0.00");

            value = (Int16)GetI2CShort(mcpHandle, (byte)(bq769xxLOADVOLT));
            ParameterValue[18].Text = ((float)value / 100).ToString("0.00");
        }

        private void InitialiseParameters(Label[] ParameterName, Label[] ParameterValue, uint NumberOfParameters)
        {
            int numberofrows = 16;
            int col1xoffset = 0;
            int col2xoffset = 200;
            int xoffset;

            for (int i = 0; i < NumberOfParameters; i++)
            {
                if (i < numberofrows) xoffset = col1xoffset;
                else                  xoffset = col2xoffset;

                ParameterName[i] = new Label();
                ParameterName[i].Text = "Parameter " + i;
                ParameterName[i].AutoSize = true;
                ParameterName[i].Location = new Point(xoffset + 13, (i % numberofrows * 20) + 23);
                gbBQ76952.Controls.Add(ParameterName[i]);

                ParameterValue[i] = new Label();
                ParameterValue[i].Text = "0.000";
                ParameterValue[i].TextAlign = ContentAlignment.TopRight;
                ParameterValue[i].Location = new Point(xoffset + 25, (i % numberofrows * 20) + 23);
                gbBQ76952.Controls.Add(ParameterValue[i]);

                ParameterUnits[i] = new Label();
                ParameterUnits[i].Text = "V";
                ParameterUnits[i].AutoSize = true;
                ParameterUnits[i].Location = new Point(xoffset + 125, (i % numberofrows * 20) + 23);
                gbBQ76952.Controls.Add(ParameterUnits[i]);

                ParameterDescription[i] = new Label();
                ParameterDescription[i].Text = "Unknown";
                ParameterDescription[i].AutoSize = true;
                ParameterDescription[i].Location = new Point(xoffset + 160, (i % numberofrows * 20) + 23);
                gbBQ76952.Controls.Add(ParameterDescription[i]);
            }
        }
        private void WriteParameter(uint i, string name, string units, string description)
        {
            ParameterName[i].Text = name;
            ParameterUnits[i].Text = units;
            ParameterDescription[i].Text = description;
        }

        private int GetI2CShort(IntPtr mcpHandle, byte Command)
        {
            const int slaveAddress = 0x08;
            const int bytesToWrite = 1;
            byte[] i2cTxData = new byte[bytesToWrite];
            i2cTxData[0] = Command;
            result = MCP2221.M_Mcp2221_I2cWriteNoStop(mcpHandle, bytesToWrite, slaveAddress, 1, i2cTxData);

            const int bytesToRead = 2;
            byte[] i2cRxData = new byte[bytesToRead];
            result = MCP2221.M_Mcp2221_I2cReadRestart(mcpHandle, bytesToRead, slaveAddress, 1, i2cRxData);

            int value = (i2cRxData[1] << 8) + i2cRxData[0];
            return (value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadParameters(mcpHandle);
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            if (bConnect.Text == "Connect")
            {
                uint speed = 100000;
                mcpHandle = MCP2221.M_Mcp2221_OpenByIndex(DEFAULT_VID, DEFAULT_PID, 0);
                //mcpHandle = MCP2221.M_Mcp2221_OpenBySN(DEFAULT_VID, DEFAULT_PID, cbSelectDevice.Text);
                //mcpHandle = MCP2221.M_Mcp2221_OpenBySN(DEFAULT_VID, DEFAULT_PID, "12345678");

                result = MCP2221.M_Mcp2221_GetLastError();
                if (result != MCP2221.M_E_NO_ERR)
                {
                    statusStrip1.Items[0].Text = "Error " + result + " opening device [" + cbSelectDevice.Text + "]";
                    return;
                }

                if (cbSpeed.SelectedIndex == 0)
                    speed = 100000;
                else
                    speed = 400000;

                result = MCP2221.M_Mcp2221_SetSpeed(mcpHandle, speed);
                if (result != MCP2221.M_E_NO_ERR)
                {
                    statusStrip1.Items[0].Text = "Error setting speed to " + speed + "Hz";
                    return;
                }

                timer1.Enabled = true;
                bConnect.Text = "Disconnect";
            }
            else
            {
                timer1.Enabled = false;
                bConnect.Text = "Connect";
            }
        }
    }
}