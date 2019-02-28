namespace MailRuCreator
{
    partial class StartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.loader = new System.Windows.Forms.Timer(this.components);
            this.start_screen = new MailRuCreator.ElipsePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.start_screen)).BeginInit();
            this.SuspendLayout();
            // 
            // loader
            // 
            this.loader.Enabled = true;
            this.loader.Interval = 10;
            this.loader.Tick += new System.EventHandler(this.loader_Tick);
            // 
            // start_screen
            // 
            this.start_screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_screen.Image = ((System.Drawing.Image)(resources.GetObject("start_screen.Image")));
            this.start_screen.Location = new System.Drawing.Point(0, 0);
            this.start_screen.Name = "start_screen";
            this.start_screen.Size = new System.Drawing.Size(600, 600);
            this.start_screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start_screen.TabIndex = 0;
            this.start_screen.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.start_screen);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            ((System.ComponentModel.ISupportInitialize)(this.start_screen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ElipsePictureBox start_screen;
        private System.Windows.Forms.Timer loader;
    }
}