
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarfrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // nPortLabel
            // 
            this.nPortLabel.AutoSize = true;
            this.nPortLabel.Location = new System.Drawing.Point(11, 11);
            this.nPortLabel.Name = "nPortLabel";
            this.nPortLabel.Size = new System.Drawing.Size(38, 13);
            this.nPortLabel.TabIndex = 0;
            this.nPortLabel.Text = "n° port";
            // 
            // nportBox
            // 
            this.nportBox.Location = new System.Drawing.Point(68, 9);
            this.nportBox.MaxLength = 4;
            this.nportBox.Name = "nportBox";
            this.nportBox.Size = new System.Drawing.Size(55, 20);
            this.nportBox.TabIndex = 1;
            this.nportBox.Text = "9002";
            // 
            // trackBarfrequency
            // 
            this.trackBarfrequency.LargeChange = 10;
            this.trackBarfrequency.Location = new System.Drawing.Point(68, 34);
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
            this.frquencyLabel.Location = new System.Drawing.Point(11, 35);
            this.frquencyLabel.Name = "frquencyLabel";
            this.frquencyLabel.Size = new System.Drawing.Size(54, 13);
            this.frquencyLabel.TabIndex = 3;
            this.frquencyLabel.Text = "frequency";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(11, 64);
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
            this.TrackValueLabel.Location = new System.Drawing.Point(154, 35);
            this.TrackValueLabel.Name = "TrackValueLabel";
            this.TrackValueLabel.Size = new System.Drawing.Size(13, 13);
            this.TrackValueLabel.TabIndex = 5;
            this.TrackValueLabel.Text = "2";
            // 
            // RPOSLabel
            // 
            this.RPOSLabel.AutoSize = true;
            this.RPOSLabel.Location = new System.Drawing.Point(488, 14);
            this.RPOSLabel.Name = "RPOSLabel";
            this.RPOSLabel.Size = new System.Drawing.Size(46, 13);
            this.RPOSLabel.TabIndex = 6;
            this.RPOSLabel.Text = "RPOS : ";
            // 
            // RPOSField
            // 
            this.RPOSField.Location = new System.Drawing.Point(540, 11);
            this.RPOSField.Name = "RPOSField";
            this.RPOSField.ReadOnly = true;
            this.RPOSField.Size = new System.Drawing.Size(121, 20);
            this.RPOSField.TabIndex = 7;
            // 
            // ConnectionWSLabel
            // 
            this.ConnectionWSLabel.AutoSize = true;
            this.ConnectionWSLabel.Location = new System.Drawing.Point(81, 66);
            this.ConnectionWSLabel.Name = "ConnectionWSLabel";
            this.ConnectionWSLabel.Size = new System.Drawing.Size(77, 13);
            this.ConnectionWSLabel.TabIndex = 9;
            this.ConnectionWSLabel.Text = "(disconnected)";
            // 
            // RREFField
            // 
            this.RREFField.Location = new System.Drawing.Point(540, 37);
            this.RREFField.Name = "RREFField";
            this.RREFField.ReadOnly = true;
            this.RREFField.Size = new System.Drawing.Size(121, 20);
            this.RREFField.TabIndex = 11;
            // 
            // RREFLabel
            // 
            this.RREFLabel.AutoSize = true;
            this.RREFLabel.Location = new System.Drawing.Point(488, 40);
            this.RREFLabel.Name = "RREFLabel";
            this.RREFLabel.Size = new System.Drawing.Size(45, 13);
            this.RREFLabel.TabIndex = 10;
            this.RREFLabel.Text = "RREF : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.RREFField);
            this.Controls.Add(this.RREFLabel);
            this.Controls.Add(this.ConnectionWSLabel);
            this.Controls.Add(this.RPOSField);
            this.Controls.Add(this.RPOSLabel);
            this.Controls.Add(this.TrackValueLabel);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.frquencyLabel);
            this.Controls.Add(this.trackBarfrequency);
            this.Controls.Add(this.nportBox);
            this.Controls.Add(this.nPortLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarfrequency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

