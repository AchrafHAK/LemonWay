namespace WindowsFormClient
{
    partial class BusyForm
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
            this.PB_Loading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Loading)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Loading
            // 
            this.PB_Loading.BackColor = System.Drawing.Color.Transparent;
            this.PB_Loading.Image = global::WindowsFormClient.Properties.Resources.SampleAnimation;
            this.PB_Loading.ImageLocation = "";
            this.PB_Loading.Location = new System.Drawing.Point(0, 0);
            this.PB_Loading.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Loading.Name = "PB_Loading";
            this.PB_Loading.Padding = new System.Windows.Forms.Padding(308, 144, 309, 145);
            this.PB_Loading.Size = new System.Drawing.Size(820, 489);
            this.PB_Loading.TabIndex = 0;
            this.PB_Loading.TabStop = false;
            // 
            // BusyForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.PB_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BusyForm";
            this.Opacity = 0.6D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusyForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BusyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Loading;
    }
}