
namespace WinFormsAppServerFS
{
    partial class FormControls
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
            this.trackBarRudder = new System.Windows.Forms.TrackBar();
            this.labelRudder = new System.Windows.Forms.Label();
            this.trackBarSideSlip = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRudder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSideSlip)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRudder
            // 
            this.trackBarRudder.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRudder.Location = new System.Drawing.Point(12, 19);
            this.trackBarRudder.Maximum = 100;
            this.trackBarRudder.Minimum = -100;
            this.trackBarRudder.Name = "trackBarRudder";
            this.trackBarRudder.Size = new System.Drawing.Size(276, 45);
            this.trackBarRudder.TabIndex = 5;
            // 
            // labelRudder
            // 
            this.labelRudder.AutoSize = true;
            this.labelRudder.Location = new System.Drawing.Point(145, 48);
            this.labelRudder.Name = "labelRudder";
            this.labelRudder.Size = new System.Drawing.Size(13, 13);
            this.labelRudder.TabIndex = 6;
            this.labelRudder.Text = "0";
            // 
            // trackBarSideSlip
            // 
            this.trackBarSideSlip.Location = new System.Drawing.Point(12, 70);
            this.trackBarSideSlip.Maximum = 100;
            this.trackBarSideSlip.Minimum = -100;
            this.trackBarSideSlip.Name = "trackBarSideSlip";
            this.trackBarSideSlip.Size = new System.Drawing.Size(276, 45);
            this.trackBarSideSlip.TabIndex = 7;
            // 
            // FormControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 127);
            this.Controls.Add(this.labelRudder);
            this.Controls.Add(this.trackBarSideSlip);
            this.Controls.Add(this.trackBarRudder);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormControls";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRudder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSideSlip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRudder;
        private System.Windows.Forms.Label labelRudder;
        private System.Windows.Forms.TrackBar trackBarSideSlip;
    }
}