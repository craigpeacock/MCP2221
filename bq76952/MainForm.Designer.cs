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
            this.gbBQ76952 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.gbMCP2211.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
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
            // gbBQ76952
            // 
            this.gbBQ76952.Location = new System.Drawing.Point(12, 80);
            this.gbBQ76952.Name = "gbBQ76952";
            this.gbBQ76952.Size = new System.Drawing.Size(583, 378);
            this.gbBQ76952.TabIndex = 5;
            this.gbBQ76952.TabStop = false;
            this.gbBQ76952.Text = "bq76952 Battery Monitor";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 494);
            this.Controls.Add(this.gbBQ76952);
            this.Controls.Add(this.gbMCP2211);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "bq76952 Battery Monitor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbMCP2211.ResumeLayout(false);
            this.gbMCP2211.PerformLayout();
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
        private GroupBox gbBQ76952;
    }
}