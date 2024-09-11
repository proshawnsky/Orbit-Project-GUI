namespace Orbit_Project_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendCommandButton = new System.Windows.Forms.Button();
            this.sendCommandText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.recievedTextBox = new System.Windows.Forms.TextBox();
            this.sentTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.portDropdown = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.sendCommandButton);
            this.groupBox1.Controls.Add(this.sendCommandText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.disconnectButton);
            this.groupBox1.Controls.Add(this.recievedTextBox);
            this.groupBox1.Controls.Add(this.sentTextBox);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.portDropdown);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Communication";
            // 
            // sendCommandButton
            // 
            this.sendCommandButton.Location = new System.Drawing.Point(177, 269);
            this.sendCommandButton.Name = "sendCommandButton";
            this.sendCommandButton.Size = new System.Drawing.Size(100, 34);
            this.sendCommandButton.TabIndex = 11;
            this.sendCommandButton.Text = "Send";
            this.sendCommandButton.UseVisualStyleBackColor = true;
            this.sendCommandButton.Click += new System.EventHandler(this.sendCommandButton_Click);
            // 
            // sendCommandText
            // 
            this.sendCommandText.Location = new System.Drawing.Point(19, 234);
            this.sendCommandText.Name = "sendCommandText";
            this.sendCommandText.Size = new System.Drawing.Size(258, 29);
            this.sendCommandText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Recieved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(152, 75);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(130, 34);
            this.disconnectButton.TabIndex = 6;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // recievedTextBox
            // 
            this.recievedTextBox.Location = new System.Drawing.Point(111, 188);
            this.recievedTextBox.Name = "recievedTextBox";
            this.recievedTextBox.ReadOnly = true;
            this.recievedTextBox.Size = new System.Drawing.Size(166, 29);
            this.recievedTextBox.TabIndex = 5;
            this.recievedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sentTextBox
            // 
            this.sentTextBox.Location = new System.Drawing.Point(111, 153);
            this.sentTextBox.Name = "sentTextBox";
            this.sentTextBox.ReadOnly = true;
            this.sentTextBox.Size = new System.Drawing.Size(166, 29);
            this.sentTextBox.TabIndex = 4;
            this.sentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(111, 118);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(166, 29);
            this.statusTextBox.TabIndex = 3;
            this.statusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(19, 75);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(127, 34);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // portDropdown
            // 
            this.portDropdown.FormattingEnabled = true;
            this.portDropdown.Location = new System.Drawing.Point(19, 37);
            this.portDropdown.Name = "portDropdown";
            this.portDropdown.Size = new System.Drawing.Size(263, 32);
            this.portDropdown.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox recievedTextBox;
        private System.Windows.Forms.TextBox sentTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox portDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendCommandButton;
        private System.Windows.Forms.TextBox sendCommandText;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

