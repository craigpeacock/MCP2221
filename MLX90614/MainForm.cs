using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
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
   
        public MainForm()
        {
            InitializeComponent();

            // Enumerate MCP2221 Devices and list Serial Numbers
            GetMCP2221Devices();

            // Set default I2C Speed to 100,000kHz
            cbSpeed.SelectedIndex = 0;
        }

        private void GetMCP2221Devices()
        {
            uint numberOfDevices = 0;
            uint mcpIndex = 0;

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
            const byte MLX90614_TA = 0x06;
            const byte MLX90614_TOBJ1 = 0x07;
            const byte MLX90614_TOBJ2 = 0x08;

            int value;

            value = GetI2CData(mcpHandle, MLX90614_TA);
            labelTempAmb.Text = (((float)value / 50) - 273).ToString("0.00");

            value = GetI2CData(mcpHandle, MLX90614_TOBJ1);
            labelTempObj1.Text = (((float)value / 50) - 273).ToString("0.00");

            value = GetI2CData(mcpHandle, MLX90614_TOBJ2);
            labelTempObj2.Text = (((float)value / 50) - 273).ToString("0.00");
        }

        private int GetI2CData(IntPtr mcpHandle, byte Command)
        {
            const int slaveAddress = 0x5A;
            const int bytesToWrite = 1;
            byte[] i2cTxData = new byte[bytesToWrite];
            i2cTxData[0] = Command;     
            result = MCP2221.M_Mcp2221_I2cWriteNoStop(mcpHandle, bytesToWrite, slaveAddress, 1, i2cTxData);

            const int bytesToRead = 2;
            byte[] i2cRxData = new byte[bytesToRead];
            result = MCP2221.M_Mcp2221_I2cReadRestart(mcpHandle, bytesToRead, slaveAddress, 1, i2cRxData);

            int value = (i2cRxData[1] << 8) + i2cRxData[0];
            return(value);
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