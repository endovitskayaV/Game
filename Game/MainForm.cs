using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        private Timer timer;

        public MainForm()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            
        }


        private void Shop_Btn_Click(object sender, EventArgs e)
        {
            ShopForm form = new ShopForm();
            form.ShowDialog();
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            this.Text = " " + e.X + " " + e.Y;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Painter.Money(e.Graphics);
        }
    }
}
