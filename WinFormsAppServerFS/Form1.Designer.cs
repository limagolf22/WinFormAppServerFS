
namespace WinFormsAppServerFS
{
    partial class Form1
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
            this.nPortLabel = new System.Windows.Forms.Label();
            this.nportBox = new System.Windows.Forms.TextBox();
            this.trackBarfrequency = new System.Windows.Forms.TrackBar();
            this.frquencyLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TrackValueLabel = new System.Windows.Forms.Label();
            this.RPOSLabel = new System.Windows.Forms.Label();
            this.RPOSField = new System.Windows.Forms.TextBox();
            this.ConnectionWSLabel = new System.Windows.Forms.Label();
            this.RREFField = new System.Windows.Forms.TextBox();
            this.RREFLabel = new System.Windows.Forms.Label();
            this.buttonOpenControlForm = new System.Windows.Forms.Button();
            this.SimCoLabel = new System.Windows.Forms.Label();
            this.pictureBoxSimCo = new System.Windows.Forms.PictureBox();
            this.groupBoxWS = new System.Windows.Forms.GroupBox();
            this.groupBoxSimCo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarfrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimCo)).BeginInit();
            this.groupBoxWS.SuspendLayout();
            this.groupBoxSimCo.SuspendLayout();
            this.SuspendLayout();
            // 
            // nPortLabel
            // 
            this.nPortLabel.AutoSize = true;
            this.nPortLabel.Location = new System.Drawing.Point(6, 17);
            this.nPortLabel.Name = "nPortLabel";
            this.nPortLabel.Size = new System.Drawing.Size(38, 13);
            this.nPortLabel.TabIndex = 0;
            this.nPortLabel.Text = "n° port";
            // 
            // nportBox
            // 
            this.nportBox.Location = new System.Drawing.Point(69, 15);
            this.nportBox.MaxLength = 4;
            this.nportBox.Name = "nportBox";
            this.nportBox.Size = new System.Drawing.Size(55, 20);
            this.nportBox.TabIndex = 1;
            this.nportBox.Text = "9002";
            // 
            // trackBarfrequency
            // 
            this.trackBarfrequency.LargeChange = 10;
            this.trackBarfrequency.Location = new System.Drawing.Point(63, 40);
            this.trackBarfrequency.Maximum = 50;
            this.trackBarfrequency.Minimum = 1;
            this.trackBarfrequency.Name = "trackBarfrequency";
            this.trackBarfrequency.Size = new System.Drawing.Size(89, 45);
            this.trackBarfrequency.TabIndex = 2;
            this.trackBarfrequency.Value = 10;
            // 
            // frquencyLabel
            // 
            this.frquencyLabel.AutoSize = true;
            this.frquencyLabel.Location = new System.Drawing.Point(6, 41);
            this.frquencyLabel.Name = "frquencyLabel";
            this.frquencyLabel.Size = new System.Drawing.Size(54, 13);
            this.frquencyLabel.TabIndex = 3;
            this.frquencyLabel.Text = "frequency";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(6, 70);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(64, 20);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TrackValueLabel
            // 
            this.TrackValueLabel.AutoSize = true;
            this.TrackValueLabel.Location = new System.Drawing.Point(149, 41);
            this.TrackValueLabel.Name = "TrackValueLabel";
            this.TrackValueLabel.Size = new System.Drawing.Size(29, 13);
            this.TrackValueLabel.TabIndex = 5;
            this.TrackValueLabel.Text = "2 Hz";
            // 
            // RPOSLabel
            // 
            this.RPOSLabel.AutoSize = true;
            this.RPOSLabel.Location = new System.Drawing.Point(10, 43);
            this.RPOSLabel.Name = "RPOSLabel";
            this.RPOSLabel.Size = new System.Drawing.Size(46, 13);
            this.RPOSLabel.TabIndex = 6;
            this.RPOSLabel.Text = "RPOS : ";
            // 
            // RPOSField
            // 
            this.RPOSField.Location = new System.Drawing.Point(62, 40);
            this.RPOSField.Name = "RPOSField";
            this.RPOSField.ReadOnly = true;
            this.RPOSField.Size = new System.Drawing.Size(121, 20);
            this.RPOSField.TabIndex = 7;
            // 
            // ConnectionWSLabel
            // 
            this.ConnectionWSLabel.AutoSize = true;
            this.ConnectionWSLabel.Location = new System.Drawing.Point(76, 72);
            this.ConnectionWSLabel.Name = "ConnectionWSLabel";
            this.ConnectionWSLabel.Size = new System.Drawing.Size(77, 13);
            this.ConnectionWSLabel.TabIndex = 9;
            this.ConnectionWSLabel.Text = "(disconnected)";
            // 
            // RREFField
            // 
            this.RREFField.Location = new System.Drawing.Point(62, 66);
            this.RREFField.Name = "RREFField";
            this.RREFField.ReadOnly = true;
            this.RREFField.Size = new System.Drawing.Size(121, 20);
            this.RREFField.TabIndex = 11;
            // 
            // RREFLabel
            // 
            this.RREFLabel.AutoSize = true;
            this.RREFLabel.Location = new System.Drawing.Point(10, 69);
            this.RREFLabel.Name = "RREFLabel";
            this.RREFLabel.Size = new System.Drawing.Size(45, 13);
            this.RREFLabel.TabIndex = 10;
            this.RREFLabel.Text = "RREF : ";
            // 
            // buttonOpenControlForm
            // 
            this.buttonOpenControlForm.Location = new System.Drawing.Point(11, 128);
            this.buttonOpenControlForm.Name = "buttonOpenControlForm";
            this.buttonOpenControlForm.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenControlForm.TabIndex = 12;
            this.buttonOpenControlForm.Text = "controls";
            this.buttonOpenControlForm.UseVisualStyleBackColor = true;
            this.buttonOpenControlForm.Click += new System.EventHandler(this.buttonOpenControlForm_Click);
            // 
            // SimCoLabel
            // 
            this.SimCoLabel.AutoSize = true;
            this.SimCoLabel.Location = new System.Drawing.Point(10, 21);
            this.SimCoLabel.Name = "SimCoLabel";
            this.SimCoLabel.Size = new System.Drawing.Size(43, 13);
            this.SimCoLabel.TabIndex = 13;
            this.SimCoLabel.Text = "Status :";
            // 
            // pictureBoxSimCo
            // 
            this.pictureBoxSimCo.Image = global::WinFormsAppServerFS.Properties.Resources.redDot;
            this.pictureBoxSimCo.InitialImage = global::WinFormsAppServerFS.Properties.Resources.redDot;
            this.pictureBoxSimCo.Location = new System.Drawing.Point(62, 15);
            this.pictureBoxSimCo.Name = "pictureBoxSimCo";
            this.pictureBoxSimCo.Size = new System.Drawing.Size(24, 21);
            this.pictureBoxSimCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSimCo.TabIndex = 14;
            this.pictureBoxSimCo.TabStop = false;
            // 
            // groupBoxWS
            // 
            this.groupBoxWS.Controls.Add(this.ConnectButton);
            this.groupBoxWS.Controls.Add(this.frquencyLabel);
            this.groupBoxWS.Controls.Add(this.nPortLabel);
            this.groupBoxWS.Controls.Add(this.nportBox);
            this.groupBoxWS.Controls.Add(this.TrackValueLabel);
            this.groupBoxWS.Controls.Add(this.ConnectionWSLabel);
            this.groupBoxWS.Controls.Add(this.trackBarfrequency);
            this.groupBoxWS.Location = new System.Drawing.Point(11, 9);
            this.groupBoxWS.Name = "groupBoxWS";
            this.groupBoxWS.Size = new System.Drawing.Size(200, 100);
            this.groupBoxWS.TabIndex = 15;
            this.groupBoxWS.TabStop = false;
            this.groupBoxWS.Text = "WebSocket Server";
            // 
            // groupBoxSimCo
            // 
            this.groupBoxSimCo.Controls.Add(this.RPOSField);
            this.groupBoxSimCo.Controls.Add(this.RPOSLabel);
            this.groupBoxSimCo.Controls.Add(this.pictureBoxSimCo);
            this.groupBoxSimCo.Controls.Add(this.RREFLabel);
            this.groupBoxSimCo.Controls.Add(this.SimCoLabel);
            this.groupBoxSimCo.Controls.Add(this.RREFField);
            this.groupBoxSimCo.Location = new System.Drawing.Point(217, 9);
            this.groupBoxSimCo.Name = "groupBoxSimCo";
            this.groupBoxSimCo.Size = new System.Drawing.Size(200, 100);
            this.groupBoxSimCo.TabIndex = 16;
            this.groupBoxSimCo.TabStop = false;
            this.groupBoxSimCo.Text = "SimConnect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 159);
            this.Controls.Add(this.groupBoxSimCo);
            this.Controls.Add(this.groupBoxWS);
            this.Controls.Add(this.buttonOpenControlForm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarfrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSimCo)).EndInit();
            this.groupBoxWS.ResumeLayout(false);
            this.groupBoxWS.PerformLayout();
            this.groupBoxSimCo.ResumeLayout(false);
            this.groupBoxSimCo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nPortLabel;
        private System.Windows.Forms.TextBox nportBox;
        private System.Windows.Forms.TrackBar trackBarfrequency;
        private System.Windows.Forms.Label frquencyLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label TrackValueLabel;
        private System.Windows.Forms.Label RPOSLabel;
        private System.Windows.Forms.TextBox RPOSField;
        private System.Windows.Forms.Label ConnectionWSLabel;
        private System.Windows.Forms.TextBox RREFField;
        private System.Windows.Forms.Label RREFLabel;
        private System.Windows.Forms.Button buttonOpenControlForm;
        private System.Windows.Forms.Label SimCoLabel;
        private System.Windows.Forms.PictureBox pictureBoxSimCo;
        private System.Windows.Forms.GroupBox groupBoxWS;
        private System.Windows.Forms.GroupBox groupBoxSimCo;
    }
}

