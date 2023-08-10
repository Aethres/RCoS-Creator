namespace WindowsFormsApp1
{
    partial class ProcessConfig
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
            this.processName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // processName
            // 
            this.processName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.processName.Location = new System.Drawing.Point(299, 12);
            this.processName.Name = "processName";
            this.processName.Size = new System.Drawing.Size(194, 30);
            this.processName.TabIndex = 2;
            this.processName.Text = "ProcessName";
            this.processName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.processName.TextChanged += new System.EventHandler(this.processName_TextChanged);
            // 
            // ProcessConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.processName);
            this.Name = "ProcessConfig";
            this.Size = new System.Drawing.Size(785, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox processName;
    }
}