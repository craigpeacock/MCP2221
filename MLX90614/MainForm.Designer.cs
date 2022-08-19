namespace TestApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbMCP2211 = new System.Windows.Forms.GroupBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.cbSelectDevice = new System.Windows.Forms.ComboBox();
            this.label_SelectDevice = new System.Windows.Forms.Label();
            this.Label_Speed = new System.Windows.Forms.Label();
            this.cbSpeed = new System.Windows.Forms.ComboBox();
            this.gbMLX90614 = new System.Windows.Forms.GroupBox();
            this.labelUnitsObject2 = new System.Windows.Forms.Label();
            this.labelUnitsObject1 = new System.Windows.Forms.Label();
            this.labelUnitsAmbient = new System.Windows.Forms.Label();
            this.lIDNumber = new System.Windows.Forms.Label();
            this.llabelNameObject2 = new System.Windows.Forms.Label();
            this.lableNameObject1 = new System.Windows.Forms.Label();
            this.lableNameAmbient = new System.Windows.Forms.Label();
            this.labelTempObj2 = new System.Windows.Forms.Label();
            this.labelTempObj1 = new System.Windows.Forms.Label();
            this.labelTempAmb = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.gbMCP2211.SuspendLayout();
            this.gbMLX90614.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "MainStatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbMCP2211
            // 
            this.gbMCP2211.Controls.Add(this.bConnect);
            this.gbMCP2211.Controls.Add(this.cbSelectDevice);
            this.gbMCP2211.Controls.Add(this.label_SelectDevice);
            this.gbMCP2211.Controls.Add(this.Label_Speed);
            this.gbMCP2211.Controls.Add(this.cbSpeed);
            this.gbMCP2211.Location = new System.Drawing.Point(12, 12);
            this.gbMCP2211.Name = "gbMCP2211";
            this.gbMCP2211.Size = new System.Drawing.Size(583, 62);
            this.gbMCP2211.TabIndex = 4;
            this.gbMCP2211.TabStop = false;
            this.gbMCP2211.Text = "MCP2221 USB to I2C Protocol Converter";
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(473, 26);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 8;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // cbSelectDevice
            // 
            this.cbSelectDevice.FormattingEnabled = true;
            this.cbSelectDevice.Location = new System.Drawing.Point(97, 26);
            this.cbSelectDevice.Name = "cbSelectDevice";
            this.cbSelectDevice.Size = new System.Drawing.Size(162, 23);
            this.cbSelectDevice.TabIndex = 6;
            // 
            // label_SelectDevice
            // 
            this.label_SelectDevice.AutoSize = true;
            this.label_SelectDevice.Location = new System.Drawing.Point(15, 29);
            this.label_SelectDevice.Name = "label_SelectDevice";
            this.label_SelectDevice.Size = new System.Drawing.Size(76, 15);
            this.label_SelectDevice.TabIndex = 4;
            this.label_SelectDevice.Text = "Select Device";
            // 
            // Label_Speed
            // 
            this.Label_Speed.AutoSize = true;
            this.Label_Speed.Location = new System.Drawing.Point(267, 29);
            this.Label_Speed.Name = "Label_Speed";
            this.Label_Speed.Size = new System.Drawing.Size(39, 15);
            this.Label_Speed.TabIndex = 5;
            this.Label_Speed.Text = "Speed";
            // 
            // cbSpeed
            // 
            this.cbSpeed.FormattingEnabled = true;
            this.cbSpeed.Items.AddRange(new object[] {
            "100kHz",
            "400kHz"});
            this.cbSpeed.Location = new System.Drawing.Point(312, 26);
            this.cbSpeed.Name = "cbSpeed";
            this.cbSpeed.Size = new System.Drawing.Size(121, 23);
            this.cbSpeed.TabIndex = 7;
            // 
            // gbMLX90614
            // 
            this.gbMLX90614.Controls.Add(this.labelUnitsObject2);
            this.gbMLX90614.Controls.Add(this.labelUnitsObject1);
            this.gbMLX90614.Controls.Add(this.labelUnitsAmbient);
            this.gbMLX90614.Controls.Add(this.lIDNumber);
            this.gbMLX90614.Controls.Add(this.llabelNameObject2);
            this.gbMLX90614.Controls.Add(this.lableNameObject1);
            this.gbMLX90614.Controls.Add(this.lableNameAmbient);
            this.gbMLX90614.Controls.Add(this.labelTempObj2);
            this.gbMLX90614.Controls.Add(this.labelTempObj1);
            this.gbMLX90614.Controls.Add(this.labelTempAmb);
            this.gbMLX90614.Location = new System.Drawing.Point(12, 80);
            this.gbMLX90614.Name = "gbMLX90614";
            this.gbMLX90614.Size = new System.Drawing.Size(583, 320);
            this.gbMLX90614.TabIndex = 5;
            this.gbMLX90614.TabStop = false;
            this.gbMLX90614.Text = "MLX90614 Infra Red Thermometer";
            // 
            // labelUnitsObject2
            // 
            this.labelUnitsObject2.AutoSize = true;
            this.labelUnitsObject2.Location = new System.Drawing.Point(340, 210);
            this.labelUnitsObject2.Name = "labelUnitsObject2";
            this.labelUnitsObject2.Size = new System.Drawing.Size(36, 15);
            this.labelUnitsObject2.TabIndex = 10;
            this.labelUnitsObject2.Text = "DegC";
            // 
            // labelUnitsObject1
            // 
            this.labelUnitsObject1.AutoSize = true;
            this.labelUnitsObject1.Location = new System.Drawing.Point(340, 163);
            this.labelUnitsObject1.Name = "labelUnitsObject1";
            this.labelUnitsObject1.Size = new System.Drawing.Size(36, 15);
            this.labelUnitsObject1.TabIndex = 9;
            this.labelUnitsObject1.Text = "DegC";
            // 
            // labelUnitsAmbient
            // 
            this.labelUnitsAmbient.AutoSize = true;
            this.labelUnitsAmbient.Location = new System.Drawing.Point(340, 116);
            this.labelUnitsAmbient.Name = "labelUnitsAmbient";
            this.labelUnitsAmbient.Size = new System.Drawing.Size(36, 15);
            this.labelUnitsAmbient.TabIndex = 8;
            this.labelUnitsAmbient.Text = "DegC";
            // 
            // lIDNumber
            // 
            this.lIDNumber.Location = new System.Drawing.Point(341, 293);
            this.lIDNumber.Name = "lIDNumber";
            this.lIDNumber.Size = new System.Drawing.Size(236, 15);
            this.lIDNumber.TabIndex = 7;
            this.lIDNumber.Text = "lIDNumber";
            this.lIDNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lIDNumber.Visible = false;
            // 
            // llabelNameObject2
            // 
            this.llabelNameObject2.AutoSize = true;
            this.llabelNameObject2.Location = new System.Drawing.Point(187, 203);
            this.llabelNameObject2.Name = "llabelNameObject2";
            this.llabelNameObject2.Size = new System.Drawing.Size(51, 15);
            this.llabelNameObject2.TabIndex = 1;
            this.llabelNameObject2.Text = "Object 2";
            // 
            // lableNameObject1
            // 
            this.lableNameObject1.AutoSize = true;
            this.lableNameObject1.Location = new System.Drawing.Point(187, 156);
            this.lableNameObject1.Name = "lableNameObject1";
            this.lableNameObject1.Size = new System.Drawing.Size(51, 15);
            this.lableNameObject1.TabIndex = 2;
            this.lableNameObject1.Text = "Object 1";
            // 
            // lableNameAmbient
            // 
            this.lableNameAmbient.AutoSize = true;
            this.lableNameAmbient.Location = new System.Drawing.Point(187, 108);
            this.lableNameAmbient.Name = "lableNameAmbient";
            this.lableNameAmbient.Size = new System.Drawing.Size(53, 15);
            this.lableNameAmbient.TabIndex = 3;
            this.lableNameAmbient.Text = "Ambient";
            // 
            // labelTempObj2
            // 
            this.labelTempObj2.AutoSize = true;
            this.labelTempObj2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTempObj2.Location = new System.Drawing.Point(246, 184);
            this.labelTempObj2.Name = "labelTempObj2";
            this.labelTempObj2.Size = new System.Drawing.Size(104, 47);
            this.labelTempObj2.TabIndex = 4;
            this.labelTempObj2.Text = "00.00";
            // 
            // labelTempObj1
            // 
            this.labelTempObj1.AutoSize = true;
            this.labelTempObj1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTempObj1.Location = new System.Drawing.Point(246, 137);
            this.labelTempObj1.Name = "labelTempObj1";
            this.labelTempObj1.Size = new System.Drawing.Size(104, 47);
            this.labelTempObj1.TabIndex = 5;
            this.labelTempObj1.Text = "00.00";
            // 
            // labelTempAmb
            // 
            this.labelTempAmb.AutoSize = true;
            this.labelTempAmb.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTempAmb.Location = new System.Drawing.Point(246, 90);
            this.labelTempAmb.Name = "labelTempAmb";
            this.labelTempAmb.Size = new System.Drawing.Size(104, 47);
            this.labelTempAmb.TabIndex = 6;
            this.labelTempAmb.Text = "00.00";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 436);
            this.Controls.Add(this.gbMLX90614);
            this.Controls.Add(this.gbMCP2211);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "MLX90614 Infra Red Thermometer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbMCP2211.ResumeLayout(false);
            this.gbMCP2211.PerformLayout();
            this.gbMLX90614.ResumeLayout(false);
            this.gbMLX90614.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private GroupBox gbMCP2211;
        private Button bConnect;
        private ComboBox cbSelectDevice;
        private Label label_SelectDevice;
        private Label Label_Speed;
        private ComboBox cbSpeed;
        private GroupBox gbMLX90614;
        private Label llabelNameObject2;
        private Label lableNameObject1;
        private Label lableNameAmbient;
        private Label labelTempObj2;
        private Label labelTempObj1;
        private Label labelTempAmb;
        private Label lIDNumber;
        private Label labelUnitsObject2;
        private Label labelUnitsObject1;
        private Label labelUnitsAmbient;
    }
}