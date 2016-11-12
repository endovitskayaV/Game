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
    public partial class ShopForm : Form
    {
        private Label traps_Lbl;
        private Button buy_Btn;
        private Panel traps_Panel;
        private Panel embryos_Panel;
        private Label moneyShow_Lbl;
        private CheckBox fox_ChBx;
        private CheckBox boar_ChBx;
        private CheckBox bear_ChBx;
        private CheckBox wolf_ChBx;
        private CheckBox cock_ChBx;
        private CheckBox hen_ChBx;
        private CheckBox pig_ChBx;
        private CheckBox duck_ChBx;
        private Label food_Lbl;
        private Panel food_Panel;
        private CheckBox cockF_ChBx;
        private CheckBox henF_ChBx;
        private CheckBox pigF_ChBx;
        private CheckBox duckF_ChBx;
        private Button exit_Btn;
        private Label embryos_Lbl;

        public ShopForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.traps_Lbl = new System.Windows.Forms.Label();
            this.embryos_Lbl = new System.Windows.Forms.Label();
            this.buy_Btn = new System.Windows.Forms.Button();
            this.traps_Panel = new System.Windows.Forms.Panel();
            this.boar_ChBx = new System.Windows.Forms.CheckBox();
            this.bear_ChBx = new System.Windows.Forms.CheckBox();
            this.wolf_ChBx = new System.Windows.Forms.CheckBox();
            this.fox_ChBx = new System.Windows.Forms.CheckBox();
            this.embryos_Panel = new System.Windows.Forms.Panel();
            this.cock_ChBx = new System.Windows.Forms.CheckBox();
            this.hen_ChBx = new System.Windows.Forms.CheckBox();
            this.pig_ChBx = new System.Windows.Forms.CheckBox();
            this.duck_ChBx = new System.Windows.Forms.CheckBox();
            this.moneyShow_Lbl = new System.Windows.Forms.Label();
            this.food_Lbl = new System.Windows.Forms.Label();
            this.food_Panel = new System.Windows.Forms.Panel();
            this.cockF_ChBx = new System.Windows.Forms.CheckBox();
            this.henF_ChBx = new System.Windows.Forms.CheckBox();
            this.pigF_ChBx = new System.Windows.Forms.CheckBox();
            this.duckF_ChBx = new System.Windows.Forms.CheckBox();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.traps_Panel.SuspendLayout();
            this.embryos_Panel.SuspendLayout();
            this.food_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // traps_Lbl
            // 
            this.traps_Lbl.AutoSize = true;
            this.traps_Lbl.Location = new System.Drawing.Point(131, 113);
            this.traps_Lbl.Name = "traps_Lbl";
            this.traps_Lbl.Size = new System.Drawing.Size(37, 13);
            this.traps_Lbl.TabIndex = 9;
            this.traps_Lbl.Text = "Traps:";
            // 
            // embryos_Lbl
            // 
            this.embryos_Lbl.AutoSize = true;
            this.embryos_Lbl.Location = new System.Drawing.Point(212, 113);
            this.embryos_Lbl.Name = "embryos_Lbl";
            this.embryos_Lbl.Size = new System.Drawing.Size(50, 13);
            this.embryos_Lbl.TabIndex = 10;
            this.embryos_Lbl.Text = "Embryos:";
            // 
            // buy_Btn
            // 
            this.buy_Btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buy_Btn.FlatAppearance.BorderSize = 0;
            this.buy_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.buy_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buy_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy_Btn.Location = new System.Drawing.Point(215, 242);
            this.buy_Btn.Name = "buy_Btn";
            this.buy_Btn.Size = new System.Drawing.Size(33, 30);
            this.buy_Btn.TabIndex = 11;
            this.buy_Btn.UseVisualStyleBackColor = true;
            this.buy_Btn.Click += new System.EventHandler(this.buy_Btn_Click);
            this.buy_Btn.MouseLeave += new System.EventHandler(this.buy_Btn_MouseLeave);
            this.buy_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buy_Btn_MouseMove);
            // 
            // traps_Panel
            // 
            this.traps_Panel.Controls.Add(this.boar_ChBx);
            this.traps_Panel.Controls.Add(this.bear_ChBx);
            this.traps_Panel.Controls.Add(this.wolf_ChBx);
            this.traps_Panel.Controls.Add(this.fox_ChBx);
            this.traps_Panel.Location = new System.Drawing.Point(102, 136);
            this.traps_Panel.Name = "traps_Panel";
            this.traps_Panel.Size = new System.Drawing.Size(94, 100);
            this.traps_Panel.TabIndex = 12;
            this.traps_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Traps_Panel_paint);
            // 
            // boar_ChBx
            // 
            this.boar_ChBx.AutoSize = true;
            this.boar_ChBx.Location = new System.Drawing.Point(5, 74);
            this.boar_ChBx.Name = "boar_ChBx";
            this.boar_ChBx.Size = new System.Drawing.Size(71, 17);
            this.boar_ChBx.TabIndex = 15;
            this.boar_ChBx.Text = "boar    13";
            this.boar_ChBx.UseVisualStyleBackColor = true;
            // 
            // bear_ChBx
            // 
            this.bear_ChBx.AutoSize = true;
            this.bear_ChBx.Location = new System.Drawing.Point(5, 51);
            this.bear_ChBx.Name = "bear_ChBx";
            this.bear_ChBx.Size = new System.Drawing.Size(71, 17);
            this.bear_ChBx.TabIndex = 15;
            this.bear_ChBx.Text = "bear    20";
            this.bear_ChBx.UseVisualStyleBackColor = true;
            // 
            // wolf_ChBx
            // 
            this.wolf_ChBx.AutoSize = true;
            this.wolf_ChBx.Location = new System.Drawing.Point(5, 28);
            this.wolf_ChBx.Name = "wolf_ChBx";
            this.wolf_ChBx.Size = new System.Drawing.Size(72, 17);
            this.wolf_ChBx.TabIndex = 15;
            this.wolf_ChBx.Text = "wolf      7 ";
            this.wolf_ChBx.UseVisualStyleBackColor = true;
            // 
            // fox_ChBx
            // 
            this.fox_ChBx.AutoSize = true;
            this.fox_ChBx.Location = new System.Drawing.Point(5, 5);
            this.fox_ChBx.Name = "fox_ChBx";
            this.fox_ChBx.Size = new System.Drawing.Size(73, 17);
            this.fox_ChBx.TabIndex = 15;
            this.fox_ChBx.Text = "fox        5 ";
            this.fox_ChBx.UseVisualStyleBackColor = true;
            // 
            // embryos_Panel
            // 
            this.embryos_Panel.Controls.Add(this.cock_ChBx);
            this.embryos_Panel.Controls.Add(this.hen_ChBx);
            this.embryos_Panel.Controls.Add(this.pig_ChBx);
            this.embryos_Panel.Controls.Add(this.duck_ChBx);
            this.embryos_Panel.Location = new System.Drawing.Point(202, 136);
            this.embryos_Panel.Name = "embryos_Panel";
            this.embryos_Panel.Size = new System.Drawing.Size(90, 100);
            this.embryos_Panel.TabIndex = 13;
            this.embryos_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Embrys_Panel_Paint);
            // 
            // cock_ChBx
            // 
            this.cock_ChBx.AutoSize = true;
            this.cock_ChBx.Location = new System.Drawing.Point(5, 74);
            this.cock_ChBx.Name = "cock_ChBx";
            this.cock_ChBx.Size = new System.Drawing.Size(65, 17);
            this.cock_ChBx.TabIndex = 15;
            this.cock_ChBx.Text = "cock   3";
            this.cock_ChBx.UseVisualStyleBackColor = true;
            // 
            // hen_ChBx
            // 
            this.hen_ChBx.AutoSize = true;
            this.hen_ChBx.Location = new System.Drawing.Point(5, 51);
            this.hen_ChBx.Name = "hen_ChBx";
            this.hen_ChBx.Size = new System.Drawing.Size(65, 17);
            this.hen_ChBx.TabIndex = 15;
            this.hen_ChBx.Text = "hen     1";
            this.hen_ChBx.UseVisualStyleBackColor = true;
            // 
            // pig_ChBx
            // 
            this.pig_ChBx.AutoSize = true;
            this.pig_ChBx.Location = new System.Drawing.Point(5, 28);
            this.pig_ChBx.Name = "pig_ChBx";
            this.pig_ChBx.Size = new System.Drawing.Size(64, 17);
            this.pig_ChBx.TabIndex = 15;
            this.pig_ChBx.Text = "pig      5";
            this.pig_ChBx.UseVisualStyleBackColor = true;
            // 
            // duck_ChBx
            // 
            this.duck_ChBx.AutoSize = true;
            this.duck_ChBx.Location = new System.Drawing.Point(4, 5);
            this.duck_ChBx.Name = "duck_ChBx";
            this.duck_ChBx.Size = new System.Drawing.Size(65, 17);
            this.duck_ChBx.TabIndex = 15;
            this.duck_ChBx.Text = "duck   2";
            this.duck_ChBx.UseVisualStyleBackColor = true;
            // 
            // moneyShow_Lbl
            // 
            this.moneyShow_Lbl.AutoSize = true;
            this.moneyShow_Lbl.ForeColor = System.Drawing.Color.White;
            this.moneyShow_Lbl.Location = new System.Drawing.Point(25, 18);
            this.moneyShow_Lbl.Name = "moneyShow_Lbl";
            this.moneyShow_Lbl.Size = new System.Drawing.Size(13, 13);
            this.moneyShow_Lbl.TabIndex = 14;
            this.moneyShow_Lbl.Text = "0";
            // 
            // food_Lbl
            // 
            this.food_Lbl.AutoSize = true;
            this.food_Lbl.Location = new System.Drawing.Point(329, 113);
            this.food_Lbl.Name = "food_Lbl";
            this.food_Lbl.Size = new System.Drawing.Size(34, 13);
            this.food_Lbl.TabIndex = 15;
            this.food_Lbl.Text = "Food:";
            // 
            // food_Panel
            // 
            this.food_Panel.Controls.Add(this.cockF_ChBx);
            this.food_Panel.Controls.Add(this.henF_ChBx);
            this.food_Panel.Controls.Add(this.pigF_ChBx);
            this.food_Panel.Controls.Add(this.duckF_ChBx);
            this.food_Panel.Location = new System.Drawing.Point(298, 136);
            this.food_Panel.Name = "food_Panel";
            this.food_Panel.Size = new System.Drawing.Size(101, 100);
            this.food_Panel.TabIndex = 16;
            this.food_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.food_Panel_Paint);
            // 
            // cockF_ChBx
            // 
            this.cockF_ChBx.AutoSize = true;
            this.cockF_ChBx.Location = new System.Drawing.Point(5, 74);
            this.cockF_ChBx.Name = "cockF_ChBx";
            this.cockF_ChBx.Size = new System.Drawing.Size(71, 17);
            this.cockF_ChBx.TabIndex = 4;
            this.cockF_ChBx.Text = "cock   13";
            this.cockF_ChBx.UseVisualStyleBackColor = true;
            // 
            // henF_ChBx
            // 
            this.henF_ChBx.AutoSize = true;
            this.henF_ChBx.Location = new System.Drawing.Point(5, 51);
            this.henF_ChBx.Name = "henF_ChBx";
            this.henF_ChBx.Size = new System.Drawing.Size(71, 17);
            this.henF_ChBx.TabIndex = 3;
            this.henF_ChBx.Text = "hen     11";
            this.henF_ChBx.UseVisualStyleBackColor = true;
            // 
            // pigF_ChBx
            // 
            this.pigF_ChBx.AutoSize = true;
            this.pigF_ChBx.Location = new System.Drawing.Point(5, 28);
            this.pigF_ChBx.Name = "pigF_ChBx";
            this.pigF_ChBx.Size = new System.Drawing.Size(70, 17);
            this.pigF_ChBx.TabIndex = 2;
            this.pigF_ChBx.Text = "pig      15";
            this.pigF_ChBx.UseVisualStyleBackColor = true;
            // 
            // duckF_ChBx
            // 
            this.duckF_ChBx.AutoSize = true;
            this.duckF_ChBx.Location = new System.Drawing.Point(5, 5);
            this.duckF_ChBx.Name = "duckF_ChBx";
            this.duckF_ChBx.Size = new System.Drawing.Size(71, 17);
            this.duckF_ChBx.TabIndex = 0;
            this.duckF_ChBx.Text = "duck   12";
            this.duckF_ChBx.UseVisualStyleBackColor = true;
            // 
            // exit_Btn
            // 
            this.exit_Btn.FlatAppearance.BorderSize = 0;
            this.exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Btn.Location = new System.Drawing.Point(455, 13);
            this.exit_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(23, 23);
            this.exit_Btn.TabIndex = 17;
            this.exit_Btn.UseVisualStyleBackColor = true;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            this.exit_Btn.MouseLeave += new System.EventHandler(this.exit_Btn_MouseLeave);
            this.exit_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_Btn_MouseMove);
            // 
            // ShopForm
            // 
            this.ClientSize = new System.Drawing.Size(499, 379);
            this.Controls.Add(this.exit_Btn);
            this.Controls.Add(this.food_Panel);
            this.Controls.Add(this.food_Lbl);
            this.Controls.Add(this.moneyShow_Lbl);
            this.Controls.Add(this.embryos_Panel);
            this.Controls.Add(this.traps_Panel);
            this.Controls.Add(this.buy_Btn);
            this.Controls.Add(this.embryos_Lbl);
            this.Controls.Add(this.traps_Lbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShopForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShopForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShopForm_MouseMove);
            this.traps_Panel.ResumeLayout(false);
            this.traps_Panel.PerformLayout();
            this.embryos_Panel.ResumeLayout(false);
            this.embryos_Panel.PerformLayout();
            this.food_Panel.ResumeLayout(false);
            this.food_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ShopForm_Paint(object sender, PaintEventArgs e)
        {
            Painter.DrawShopFormBackground(e.Graphics, this.Height, this.Width);

            moneyShow_Lbl.BackColor = Color.FromArgb(20, 20, 20);
            moneyShow_Lbl.Text = GameValues.Money.ToString();
            Painter.DrawMoney(e.Graphics, moneyShow_Lbl.Location.X, moneyShow_Lbl.Location.Y, moneyShow_Lbl.Width, 2);
          
            //exit_Btn
            exit_Btn.Image = Image.FromFile("exit2.png");
            exit_Btn.BackColor = Color.FromArgb(20,20,20);
            exit_Btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            exit_Btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 20, 20);
            exit_Btn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 20);

            buy_Btn.Image = Image.FromFile("buy2.png");
           

        }
        
        private void Traps_Panel_paint(object sender, PaintEventArgs e)
        {
            Painter.DrawMoney(e.Graphics, fox_ChBx.Location.X, fox_ChBx.Location.Y + 3, fox_ChBx.Size.Width, 1);
            Painter.DrawMoney(e.Graphics, wolf_ChBx.Location.X, wolf_ChBx.Location.Y + 3, wolf_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, bear_ChBx.Location.X, bear_ChBx.Location.Y + 3, bear_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, boar_ChBx.Location.X, boar_ChBx.Location.Y + 3, boar_ChBx.Width, 1);
        }

        private void Embrys_Panel_Paint(object sender, PaintEventArgs e)
        {
            Painter.DrawMoney(e.Graphics, duck_ChBx.Location.X, duck_ChBx.Location.Y + 3, duck_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, pig_ChBx.Location.X, pig_ChBx.Location.Y + 3, pig_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, hen_ChBx.Location.X, hen_ChBx.Location.Y + 3, hen_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, cock_ChBx.Location.X, cock_ChBx.Location.Y + 3, cock_ChBx.Width, 1);
        }

        private void buy_Btn_Click(object sender, EventArgs e)
        {
            int acquisitionValue = 0;
            List<HomeAnimal> chosenEmbryons = new List<HomeAnimal>();
            List<WildAnimal> chosenTraps = new List<WildAnimal>();

            if (fox_ChBx.Checked)  { acquisitionValue += 5;  chosenTraps.Add(new WildAnimal(WildAnimal.Names.fox)); }
            if (wolf_ChBx.Checked) { acquisitionValue += 7;  chosenTraps.Add(new WildAnimal(WildAnimal.Names.wolf)); }
            if (bear_ChBx.Checked) { acquisitionValue += 20; chosenTraps.Add(new WildAnimal(WildAnimal.Names.bear)); }
            if (boar_ChBx.Checked) { acquisitionValue += 13; chosenTraps.Add(new WildAnimal(WildAnimal.Names.boar)); }

            if (duck_ChBx.Checked) { acquisitionValue += 2;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.duck)); }
            if (pig_ChBx.Checked)  { acquisitionValue += 5;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.pig)); }
            if (hen_ChBx.Checked)  { acquisitionValue += 1;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.hen)); }
            if (cock_ChBx.Checked) { acquisitionValue += 3;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.cock)); }

            //delete chosenEmbryons.Add(new Ho...
            //add method frm HomeAnimal
            if (duckF_ChBx.Checked) { acquisitionValue += 12; chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.duck)); }
            if (pigF_ChBx.Checked) { acquisitionValue += 15; chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.pig)); }
            if (henF_ChBx.Checked) { acquisitionValue += 11; chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.hen)); }
            if (cockF_ChBx.Checked) { acquisitionValue += 13; chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.cock)); }



            if (acquisitionValue <= 0) MessageBox.Show("Select you buyings!");

            else if (GameValues.Money - acquisitionValue >= 0)
            {
               if (chosenEmbryons.Count > 0) chosenEmbryons.AddRange(GameValues.embryosBought);
               if (chosenTraps.Count > 0)    chosenTraps.AddRange(GameValues.trapsBought);

                GameValues.Money -= acquisitionValue;
                MessageBox.Show("Bought");
                this.Refresh();
            }

            else MessageBox.Show("You have not enough money!");
        }

        private void ShopForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.TimerStart();
        }

        private void food_Panel_Paint(object sender, PaintEventArgs e)
        {
            Painter.DrawMoney(e.Graphics, duckF_ChBx.Location.X, duckF_ChBx.Location.Y + 3, duckF_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, pigF_ChBx.Location.X, pigF_ChBx.Location.Y + 3, pigF_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, henF_ChBx.Location.X, henF_ChBx.Location.Y + 3, henF_ChBx.Width, 1);
            Painter.DrawMoney(e.Graphics, cockF_ChBx.Location.X, cockF_ChBx.Location.Y + 3, cockF_ChBx.Width, 1);
        }

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Btn_MouseLeave(object sender, EventArgs e)
        {
            exit_Btn.Image = Image.FromFile("exit2.png");
        }

        private void exit_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            exit_Btn.Image = Image.FromFile("exit3.png");
        }

        private void buy_Btn_MouseLeave(object sender, EventArgs e)
        {
            buy_Btn.Image = Image.FromFile("buy2.png");
        }

        private void buy_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            buy_Btn.Image = Image.FromFile("buy3.png");
        }

        private int iFormX, iFormY, iMouseX, iMouseY;
        private void ShopForm_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void ShopForm_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));

        }
    }

}
