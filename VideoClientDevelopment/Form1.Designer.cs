namespace VideoClientDevelopment
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
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.cameraLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iPTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cameraText = new System.Windows.Forms.Label();
            this.displayImageBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPictureBox
            // 
            this.myPictureBox.Location = new System.Drawing.Point(296, 245);
            this.myPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(423, 265);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBox.TabIndex = 8;
            this.myPictureBox.TabStop = false;
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cameraLabel.Location = new System.Drawing.Point(525, 514);
            this.cameraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(66, 22);
            this.cameraLabel.TabIndex = 12;
            this.cameraLabel.Text = "(name)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(365, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Moose Video Client!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(452, 209);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 28);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.OnConnectButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.iPTextBox);
            this.groupBox1.Location = new System.Drawing.Point(305, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(401, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ConnectionLog";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(215, 73);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(132, 22);
            this.portTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Port Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter IP address";
            // 
            // iPTextBox
            // 
            this.iPTextBox.Location = new System.Drawing.Point(215, 27);
            this.iPTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iPTextBox.Name = "iPTextBox";
            this.iPTextBox.Size = new System.Drawing.Size(132, 22);
            this.iPTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter below the local IP address and port number (which is 7000)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(387, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Camera Name:";
            // 
            // cameraText
            // 
            this.cameraText.AutoSize = true;
            this.cameraText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cameraText.Location = new System.Drawing.Point(559, 505);
            this.cameraText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cameraText.Name = "cameraText";
            this.cameraText.Size = new System.Drawing.Size(0, 22);
            this.cameraText.TabIndex = 10;
            // 
            // displayImageBtn
            // 
            this.displayImageBtn.Location = new System.Drawing.Point(817, 257);
            this.displayImageBtn.Margin = new System.Windows.Forms.Padding(4);
            this.displayImageBtn.Name = "displayImageBtn";
            this.displayImageBtn.Size = new System.Drawing.Size(144, 28);
            this.displayImageBtn.TabIndex = 11;
            this.displayImageBtn.Text = "Image Information";
            this.displayImageBtn.UseVisualStyleBackColor = true;
            this.displayImageBtn.Click += new System.EventHandler(this.DisplayImageInfo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cameraLabel);
            this.Controls.Add(this.displayImageBtn);
            this.Controls.Add(this.cameraText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Moose Ltd Video Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iPTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cameraText;
        private System.Windows.Forms.Button displayImageBtn;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.Label cameraLabel;
    }
}

