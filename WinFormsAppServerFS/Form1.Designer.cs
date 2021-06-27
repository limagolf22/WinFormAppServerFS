
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
            this.nPortLabel.Location = new System.Drawing.Point(16, 41);
            this.nPortLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.nPortLabel.Name = "nPortLabel";
            this.nPortLabel.Size = new System.Drawing.Size(98, 32);
            this.nPortLabel.TabIndex = 0;
            this.nPortLabel.Text = "n° port";
            // 
            // nportBox
            // 
            this.nportBox.Location = new System.Drawing.Point(184, 36);
            this.nportBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.nportBox.MaxLength = 4;
            this.nportBox.Name = "nportBox";
            this.nportBox.Size = new System.Drawing.Size(140, 38);
            this.nportBox.TabIndex = 1;
            this.nportBox.Text = "9002";
            // 
            // trackBarfrequency
            // 
            this.trackBarfrequency.LargeChange = 10;
            this.trackBarfrequency.Location = new System.Drawing.Point(168, 95);
            this.trackBarfrequency.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.trackBarfrequency.Maximum = 50;
            this.trackBarfrequency.Minimum = 1;
            this.trackBarfrequency.Name = "trackBarfrequency";
            this.trackBarfrequency.Size = new System.Drawing.Size(237, 114);
            this.trackBarfrequency.TabIndex = 2;
            this.trackBarfrequency.Value = 10;
            // 
            // frquencyLabel
            // 
            this.frquencyLabel.AutoSize = true;
            this.frquencyLabel.Location = new System.Drawing.Point(16, 98);
            this.frquencyLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.frquencyLabel.Name = "frquencyLabel";
            this.frquencyLabel.Size = new System.Drawing.Size(140, 32);
            this.frquencyLabel.TabIndex = 3;
            this.frquencyLabel.Text = "frequency";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(16, 167);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(171, 48);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TrackValueLabel
            // 
            this.TrackValueLabel.AutoSize = true;
            this.TrackValueLabel.Location = new System.Drawing.Point(397, 98);
            this.TrackValueLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.TrackValueLabel.Name = "TrackValueLabel";
            this.TrackValueLabel.Size = new System.Drawing.Size(72, 32);
            this.TrackValueLabel.TabIndex = 5;
            this.TrackValueLabel.Text = "2 Hz";
            // 
            // RPOSLabel
            // 
            this.RPOSLabel.AutoSize = true;
            this.RPOSLabel.Location = new System.Drawing.Point(27, 103);
            this.RPOSLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RPOSLabel.Name = "RPOSLabel";
            this.RPOSLabel.Size = new System.Drawing.Size(117, 32);
            this.RPOSLabel.TabIndex = 6;
            this.RPOSLabel.Text = "RPOS : ";
            // 
            // RPOSField
            // 
            this.RPOSField.Location = new System.Drawing.Point(165, 95);
            this.RPOSField.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RPOSField.Name = "RPOSField";
            this.RPOSField.ReadOnly = true;
            this.RPOSField.Size = new System.Drawing.Size(316, 38);
            this.RPOSField.TabIndex = 7;
            // 
            // ConnectionWSLabel
            // 
            this.ConnectionWSLabel.AutoSize = true;
            this.ConnectionWSLabel.Location = new System.Drawing.Point(203, 172);
            this.ConnectionWSLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ConnectionWSLabel.Name = "ConnectionWSLabel";
            this.ConnectionWSLabel.Size = new System.Drawing.Size(202, 32);
            this.ConnectionWSLabel.TabIndex = 9;
            this.ConnectionWSLabel.Text = "(disconnected)";
            // 
            // RREFField
            // 
            this.RREFField.Location = new System.Drawing.Point(165, 157);
            this.RREFField.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RREFField.Name = "RREFField";
            this.RREFField.ReadOnly = true;
            this.RREFField.Size = new System.Drawing.Size(316, 38);
            this.RREFField.TabIndex = 11;
            // 
            // RREFLabel
            // 
            this.RREFLabel.AutoSize = true;
            this.RREFLabel.Location = new System.Drawing.Point(27, 165);
            this.RREFLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RREFLabel.Name = "RREFLabel";
            this.RREFLabel.Size = new System.Drawing.Size(113, 32);
            this.RREFLabel.TabIndex = 10;
            this.RREFLabel.Text = "RREF : ";
            // 
            // buttonOpenControlForm
            // 
            this.buttonOpenControlForm.Location = new System.Drawing.Point(29, 305);
            this.buttonOpenControlForm.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonOpenControlForm.Name = "buttonOpenControlForm";
            this.buttonOpenControlForm.Size = new System.Drawing.Size(200, 55);
            this.buttonOpenControlForm.TabIndex = 12;
            this.buttonOpenControlForm.Text = "controls";
            this.buttonOpenControlForm.UseVisualStyleBackColor = true;
            this.buttonOpenControlForm.Click += new System.EventHandler(this.buttonOpenControlForm_Click);
            // 
            // SimCoLabel
            // 
            this.SimCoLabel.AutoSize = true;
            this.SimCoLabel.Location = new System.Drawing.Point(27, 50);
            this.SimCoLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.SimCoLabel.Name = "SimCoLabel";
            this.SimCoLabel.Size = new System.Drawing.Size(111, 32);
            this.SimCoLabel.TabIndex = 13;
            this.SimCoLabel.Text = "Status :";
            // 
            // pictureBoxSimCo
            // 
            this.pictureBoxSimCo.Image = global::WinFormsAppServerFS.Properties.Resources.redDot;
            this.pictureBoxSimCo.InitialImage = global::WinFormsAppServerFS.Properties.Resources.redDot;
            this.pictureBoxSimCo.Location = new System.Drawing.Point(165, 36);
            this.pictureBoxSimCo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBoxSimCo.Name = "pictureBoxSimCo";
            this.pictureBoxSimCo.Size = new System.Drawing.Size(64, 50);
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
            this.groupBoxWS.Location = new System.Drawing.Point(29, 21);
            this.groupBoxWS.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxWS.Name = "groupBoxWS";
            this.groupBoxWS.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxWS.Size = new System.Drawing.Size(533, 238);
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
            this.groupBoxSimCo.Location = new System.Drawing.Point(579, 21);
            this.groupBoxSimCo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxSimCo.Name = "groupBoxSimCo";
            this.groupBoxSimCo.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxSimCo.Size = new System.Drawing.Size(533, 238);
            this.groupBoxSimCo.TabIndex = 16;
            this.groupBoxSimCo.TabStop = false;
            this.groupBoxSimCo.Text = "SimConnect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 379);
            this.Controls.Add(this.groupBoxSimCo);
            this.Controls.Add(this.groupBoxWS);
            this.Controls.Add(this.buttonOpenControlForm);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
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

