namespace MailRuCreator
{
    partial class Mailru_Registrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mailru_Registrator));
            this.general_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.general_Picture = new System.Windows.Forms.PictureBox();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.general_panel2 = new System.Windows.Forms.Panel();
            this.refresh_btn = new System.Windows.Forms.PictureBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.surName_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.generate_btn = new System.Windows.Forms.Button();
            this.kapcha_board = new System.Windows.Forms.PictureBox();
            this.kapcha_line = new System.Windows.Forms.TextBox();
            this.pass_text = new System.Windows.Forms.Label();
            this.login_text = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.minimized = new System.Windows.Forms.NotifyIcon(this.components);
            this.general_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general_Picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.general_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapcha_board)).BeginInit();
            this.SuspendLayout();
            // 
            // general_panel
            // 
            this.general_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.general_panel.Controls.Add(this.label1);
            this.general_panel.Controls.Add(this.general_Picture);
            this.general_panel.Controls.Add(this.minimize_btn);
            this.general_panel.Controls.Add(this.close_btn);
            this.general_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.general_panel.Location = new System.Drawing.Point(0, 0);
            this.general_panel.Name = "general_panel";
            this.general_panel.Size = new System.Drawing.Size(788, 108);
            this.general_panel.TabIndex = 0;
            this.general_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseDown);
            this.general_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseMove);
            this.general_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(156)))), ((int)(((byte)(14)))));
            this.label1.Location = new System.Drawing.Point(215, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registration  Bot";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseUp);
            // 
            // general_Picture
            // 
            this.general_Picture.Cursor = System.Windows.Forms.Cursors.Default;
            this.general_Picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.general_Picture.Image = ((System.Drawing.Image)(resources.GetObject("general_Picture.Image")));
            this.general_Picture.Location = new System.Drawing.Point(0, 0);
            this.general_Picture.Name = "general_Picture";
            this.general_Picture.Size = new System.Drawing.Size(209, 108);
            this.general_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.general_Picture.TabIndex = 2;
            this.general_Picture.TabStop = false;
            this.general_Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseDown);
            this.general_Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseMove);
            this.general_Picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.general_Drag_Drop_Panel_MouseUp);
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(707, 9);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(27, 29);
            this.minimize_btn.TabIndex = 1;
            this.minimize_btn.Text = "_";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            this.minimize_btn.MouseEnter += new System.EventHandler(this.Refresh_btn_MouseEnter);
            this.minimize_btn.MouseLeave += new System.EventHandler(this.Refresh_btn_MouseLeave);
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(745, 9);
            this.close_btn.Margin = new System.Windows.Forms.Padding(0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(31, 29);
            this.close_btn.TabIndex = 0;
            this.close_btn.Text = "X";
            this.close_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.close_btn.MouseEnter += new System.EventHandler(this.Refresh_btn_MouseEnter);
            this.close_btn.MouseLeave += new System.EventHandler(this.Refresh_btn_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.general_panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 426);
            this.panel1.TabIndex = 1;
            // 
            // general_panel2
            // 
            this.general_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.general_panel2.Controls.Add(this.refresh_btn);
            this.general_panel2.Controls.Add(this.ok_btn);
            this.general_panel2.Controls.Add(this.label2);
            this.general_panel2.Controls.Add(this.name_label);
            this.general_panel2.Controls.Add(this.surName_box);
            this.general_panel2.Controls.Add(this.name_box);
            this.general_panel2.Controls.Add(this.generate_btn);
            this.general_panel2.Controls.Add(this.kapcha_board);
            this.general_panel2.Controls.Add(this.kapcha_line);
            this.general_panel2.Controls.Add(this.pass_text);
            this.general_panel2.Controls.Add(this.login_text);
            this.general_panel2.Controls.Add(this.pass_box);
            this.general_panel2.Controls.Add(this.login_box);
            this.general_panel2.Location = new System.Drawing.Point(16, 17);
            this.general_panel2.Name = "general_panel2";
            this.general_panel2.Size = new System.Drawing.Size(760, 397);
            this.general_panel2.TabIndex = 0;
            this.general_panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.General_Panel2_MouseClick);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.Location = new System.Drawing.Point(671, 38);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(55, 53);
            this.refresh_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.refresh_btn.TabIndex = 14;
            this.refresh_btn.TabStop = false;
            this.refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            this.refresh_btn.MouseEnter += new System.EventHandler(this.Refresh_btn_MouseEnter);
            this.refresh_btn.MouseLeave += new System.EventHandler(this.Refresh_btn_MouseLeave);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.ok_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ok_btn.FlatAppearance.BorderSize = 5;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_btn.ForeColor = System.Drawing.Color.White;
            this.ok_btn.Location = new System.Drawing.Point(671, 205);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(55, 53);
            this.ok_btn.TabIndex = 13;
            this.ok_btn.Text = "Ok";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            this.ok_btn.MouseEnter += new System.EventHandler(this.Generate_btn_MouseEnter);
            this.ok_btn.MouseLeave += new System.EventHandler(this.Generate_btn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(29, 38);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(68, 25);
            this.name_label.TabIndex = 11;
            this.name_label.Text = "Name";
            // 
            // surName_box
            // 
            this.surName_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surName_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surName_box.Location = new System.Drawing.Point(164, 81);
            this.surName_box.Name = "surName_box";
            this.surName_box.ReadOnly = true;
            this.surName_box.Size = new System.Drawing.Size(228, 22);
            this.surName_box.TabIndex = 10;
            this.surName_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Name_box_MouseClick);
            // 
            // name_box
            // 
            this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(164, 35);
            this.name_box.Name = "name_box";
            this.name_box.ReadOnly = true;
            this.name_box.Size = new System.Drawing.Size(228, 22);
            this.name_box.TabIndex = 9;
            this.name_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Name_box_MouseClick);
            // 
            // generate_btn
            // 
            this.generate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.generate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.generate_btn.FlatAppearance.BorderSize = 5;
            this.generate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_btn.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_btn.ForeColor = System.Drawing.Color.White;
            this.generate_btn.Location = new System.Drawing.Point(289, 300);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(167, 62);
            this.generate_btn.TabIndex = 6;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = false;
            this.generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            this.generate_btn.MouseEnter += new System.EventHandler(this.Generate_btn_MouseEnter);
            this.generate_btn.MouseLeave += new System.EventHandler(this.Generate_btn_MouseLeave);
            // 
            // kapcha_board
            // 
            this.kapcha_board.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(71)))), ((int)(((byte)(133)))));
            this.kapcha_board.Cursor = System.Windows.Forms.Cursors.Cross;
            this.kapcha_board.Image = ((System.Drawing.Image)(resources.GetObject("kapcha_board.Image")));
            this.kapcha_board.Location = new System.Drawing.Point(419, 35);
            this.kapcha_board.Name = "kapcha_board";
            this.kapcha_board.Size = new System.Drawing.Size(230, 91);
            this.kapcha_board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kapcha_board.TabIndex = 7;
            this.kapcha_board.TabStop = false;
            // 
            // kapcha_line
            // 
            this.kapcha_line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kapcha_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kapcha_line.Location = new System.Drawing.Point(419, 219);
            this.kapcha_line.Name = "kapcha_line";
            this.kapcha_line.Size = new System.Drawing.Size(230, 28);
            this.kapcha_line.TabIndex = 8;
            this.kapcha_line.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Name_box_MouseClick);
            // 
            // pass_text
            // 
            this.pass_text.AutoSize = true;
            this.pass_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_text.ForeColor = System.Drawing.Color.White;
            this.pass_text.Location = new System.Drawing.Point(29, 223);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(106, 25);
            this.pass_text.TabIndex = 5;
            this.pass_text.Text = "Password";
            // 
            // login_text
            // 
            this.login_text.AutoSize = true;
            this.login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_text.ForeColor = System.Drawing.Color.White;
            this.login_text.Location = new System.Drawing.Point(29, 177);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(65, 25);
            this.login_text.TabIndex = 4;
            this.login_text.Text = "Login";
            // 
            // pass_box
            // 
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(164, 220);
            this.pass_box.Name = "pass_box";
            this.pass_box.ReadOnly = true;
            this.pass_box.Size = new System.Drawing.Size(228, 22);
            this.pass_box.TabIndex = 3;
            this.pass_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Name_box_MouseClick);
            // 
            // login_box
            // 
            this.login_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_box.Location = new System.Drawing.Point(164, 174);
            this.login_box.Name = "login_box";
            this.login_box.ReadOnly = true;
            this.login_box.Size = new System.Drawing.Size(228, 22);
            this.login_box.TabIndex = 2;
            this.login_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Name_box_MouseClick);
            // 
            // minimized
            // 
            this.minimized.Icon = ((System.Drawing.Icon)(resources.GetObject("minimized.Icon")));
            this.minimized.Text = "Mail.Ru Registration Bot";
            this.minimized.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Minimized_MouseDoubleClick);
            // 
            // Mailru_Registrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 534);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.general_panel);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mailru_Registrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail.Ru Registrator Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mailru_Registrator_FormClosing);
            this.Load += new System.EventHandler(this.Mailru_Registrator_Load);
            this.general_panel.ResumeLayout(false);
            this.general_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.general_Picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.general_panel2.ResumeLayout(false);
            this.general_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kapcha_board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel general_panel;
        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox general_Picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel general_panel2;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.PictureBox kapcha_board;
        private System.Windows.Forms.TextBox kapcha_line;
        private System.Windows.Forms.Label pass_text;
        private System.Windows.Forms.Label login_text;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.NotifyIcon minimized;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox surName_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.PictureBox refresh_btn;
        private System.Windows.Forms.Label close_btn;
    }
}

