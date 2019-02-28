using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailRuCreator
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graph = new GraphicsPath();
            graph.AddEllipse(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height));
            this.Region = new Region(graph);
            base.OnPaint(e);
        }

        private void loader_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            Mailru_Registrator bot = new Mailru_Registrator();
            bot.Visible = true;
            bot.Enabled = true;
            bot.BringToFront();
            this.Refresh();
            this.Enabled = false;
            this.Visible = false;
            loader.Enabled = false;
        }
    }
}
