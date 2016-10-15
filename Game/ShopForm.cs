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
        private CheckBox rabit_ChBx;
        private CheckBox duck_ChBx;
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
            this.rabit_ChBx = new System.Windows.Forms.CheckBox();
            this.duck_ChBx = new System.Windows.Forms.CheckBox();
            this.moneyShow_Lbl = new System.Windows.Forms.Label();
            this.traps_Panel.SuspendLayout();
            this.embryos_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // traps_Lbl
            // 
            this.traps_Lbl.AutoSize = true;
            this.traps_Lbl.Location = new System.Drawing.Point(41, 41);
            this.traps_Lbl.Name = "traps_Lbl";
            this.traps_Lbl.Size = new System.Drawing.Size(37, 13);
            this.traps_Lbl.TabIndex = 9;
            this.traps_Lbl.Text = "Traps:";
            // 
            // embryos_Lbl
            // 
            this.embryos_Lbl.AutoSize = true;
            this.embryos_Lbl.Location = new System.Drawing.Point(149, 41);
            this.embryos_Lbl.Name = "embryos_Lbl";
            this.embryos_Lbl.Size = new System.Drawing.Size(50, 13);
            this.embryos_Lbl.TabIndex = 10;
            this.embryos_Lbl.Text = "Embryos:";
            // 
            // buy_Btn
            // 
            this.buy_Btn.Location = new System.Drawing.Point(12, 175);
            this.buy_Btn.Name = "buy_Btn";
            this.buy_Btn.Size = new System.Drawing.Size(75, 23);
            this.buy_Btn.TabIndex = 11;
            this.buy_Btn.Text = "Buy";
            this.buy_Btn.UseVisualStyleBackColor = true;
            this.buy_Btn.Click += new System.EventHandler(this.buy_Btn_Click);
            // 
            // traps_Panel
            // 
            this.traps_Panel.Controls.Add(this.boar_ChBx);
            this.traps_Panel.Controls.Add(this.bear_ChBx);
            this.traps_Panel.Controls.Add(this.wolf_ChBx);
            this.traps_Panel.Controls.Add(this.fox_ChBx);
            this.traps_Panel.Location = new System.Drawing.Point(12, 67);
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
            this.wolf_ChBx.Size = new System.Drawing.Size(63, 17);
            this.wolf_ChBx.TabIndex = 15;
            this.wolf_ChBx.Text = "wolf    7";
            this.wolf_ChBx.UseVisualStyleBackColor = true;
            // 
            // fox_ChBx
            // 
            this.fox_ChBx.AutoSize = true;
            this.fox_ChBx.Location = new System.Drawing.Point(5, 5);
            this.fox_ChBx.Name = "fox_ChBx";
            this.fox_ChBx.Size = new System.Drawing.Size(61, 17);
            this.fox_ChBx.TabIndex = 15;
            this.fox_ChBx.Text = "fox     5";
            this.fox_ChBx.UseVisualStyleBackColor = true;
            // 
            // embryos_Panel
            // 
            this.embryos_Panel.Controls.Add(this.cock_ChBx);
            this.embryos_Panel.Controls.Add(this.hen_ChBx);
            this.embryos_Panel.Controls.Add(this.pig_ChBx);
            this.embryos_Panel.Controls.Add(this.rabit_ChBx);
            this.embryos_Panel.Controls.Add(this.duck_ChBx);
            this.embryos_Panel.Location = new System.Drawing.Point(131, 67);
            this.embryos_Panel.Name = "embryos_Panel";
            this.embryos_Panel.Size = new System.Drawing.Size(90, 117);
            this.embryos_Panel.TabIndex = 13;
            this.embryos_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Embrys_Panel_Paint);
            // 
            // cock_ChBx
            // 
            this.cock_ChBx.AutoSize = true;
            this.cock_ChBx.Location = new System.Drawing.Point(4, 95);
            this.cock_ChBx.Name = "cock_ChBx";
            this.cock_ChBx.Size = new System.Drawing.Size(65, 17);
            this.cock_ChBx.TabIndex = 15;
            this.cock_ChBx.Text = "cock   3";
            this.cock_ChBx.UseVisualStyleBackColor = true;
            // 
            // hen_ChBx
            // 
            this.hen_ChBx.AutoSize = true;
            this.hen_ChBx.Location = new System.Drawing.Point(4, 72);
            this.hen_ChBx.Name = "hen_ChBx";
            this.hen_ChBx.Size = new System.Drawing.Size(65, 17);
            this.hen_ChBx.TabIndex = 15;
            this.hen_ChBx.Text = "hen     1";
            this.hen_ChBx.UseVisualStyleBackColor = true;
            // 
            // pig_ChBx
            // 
            this.pig_ChBx.AutoSize = true;
            this.pig_ChBx.Location = new System.Drawing.Point(3, 49);
            this.pig_ChBx.Name = "pig_ChBx";
            this.pig_ChBx.Size = new System.Drawing.Size(64, 17);
            this.pig_ChBx.TabIndex = 15;
            this.pig_ChBx.Text = "pig      5";
            this.pig_ChBx.UseVisualStyleBackColor = true;
            // 
            // rabit_ChBx
            // 
            this.rabit_ChBx.AutoSize = true;
            this.rabit_ChBx.Location = new System.Drawing.Point(3, 26);
            this.rabit_ChBx.Name = "rabit_ChBx";
            this.rabit_ChBx.Size = new System.Drawing.Size(64, 17);
            this.rabit_ChBx.TabIndex = 15;
            this.rabit_ChBx.Text = "rabit    4";
            this.rabit_ChBx.UseVisualStyleBackColor = true;
            // 
            // duck_ChBx
            // 
            this.duck_ChBx.AutoSize = true;
            this.duck_ChBx.Location = new System.Drawing.Point(3, 3);
            this.duck_ChBx.Name = "duck_ChBx";
            this.duck_ChBx.Size = new System.Drawing.Size(65, 17);
            this.duck_ChBx.TabIndex = 15;
            this.duck_ChBx.Text = "duck   2";
            this.duck_ChBx.UseVisualStyleBackColor = true;
            // 
            // moneyShow_Lbl
            // 
            this.moneyShow_Lbl.AutoSize = true;
            this.moneyShow_Lbl.Location = new System.Drawing.Point(12, 13);
            this.moneyShow_Lbl.Name = "moneyShow_Lbl";
            this.moneyShow_Lbl.Size = new System.Drawing.Size(13, 13);
            this.moneyShow_Lbl.TabIndex = 14;
            this.moneyShow_Lbl.Text = "0";
            // 
            // ShopForm
            // 
            this.ClientSize = new System.Drawing.Size(230, 204);
            this.Controls.Add(this.moneyShow_Lbl);
            this.Controls.Add(this.embryos_Panel);
            this.Controls.Add(this.traps_Panel);
            this.Controls.Add(this.buy_Btn);
            this.Controls.Add(this.embryos_Lbl);
            this.Controls.Add(this.traps_Lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShopForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ShopForm_Paint);
            this.traps_Panel.ResumeLayout(false);
            this.traps_Panel.PerformLayout();
            this.embryos_Panel.ResumeLayout(false);
            this.embryos_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ShopForm_Paint(object sender, PaintEventArgs e)
        {
            moneyShow_Lbl.Text = GameValues.Money.ToString();

            Painter.Money(e.Graphics, moneyShow_Lbl.Location.X, moneyShow_Lbl.Location.Y, moneyShow_Lbl.Width, 1);
        }
        
        private void Traps_Panel_paint(object sender, PaintEventArgs e)
        {
            Painter.Money(e.Graphics, fox_ChBx.Location.X, fox_ChBx.Location.Y + 3, fox_ChBx.Size.Width, 2);
            Painter.Money(e.Graphics, wolf_ChBx.Location.X, wolf_ChBx.Location.Y + 3, wolf_ChBx.Width, 2);
            Painter.Money(e.Graphics, bear_ChBx.Location.X, bear_ChBx.Location.Y + 3, bear_ChBx.Width, 2);
            Painter.Money(e.Graphics, boar_ChBx.Location.X, boar_ChBx.Location.Y + 3, boar_ChBx.Width, 2);
        }

        private void Embrys_Panel_Paint(object sender, PaintEventArgs e)
        {
            Painter.Money(e.Graphics, rabit_ChBx.Location.X, rabit_ChBx.Location.Y + 3, rabit_ChBx.Width, 2);
            Painter.Money(e.Graphics, duck_ChBx.Location.X, duck_ChBx.Location.Y + 3, duck_ChBx.Width, 2);
            Painter.Money(e.Graphics, pig_ChBx.Location.X, pig_ChBx.Location.Y + 3, pig_ChBx.Width, 2);
            Painter.Money(e.Graphics, hen_ChBx.Location.X, hen_ChBx.Location.Y + 3, hen_ChBx.Width, 2);
            Painter.Money(e.Graphics, cock_ChBx.Location.X, cock_ChBx.Location.Y + 3, cock_ChBx.Width, 2);
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

            if (rabit_ChBx.Checked) { acquisitionValue += 4; chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.rabit)); }
            if (duck_ChBx.Checked) { acquisitionValue += 2;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.duck)); }
            if (pig_ChBx.Checked)  { acquisitionValue += 5;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.pig)); }
            if (hen_ChBx.Checked)  { acquisitionValue += 1;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.hen)); }
            if (cock_ChBx.Checked) { acquisitionValue += 3;  chosenEmbryons.Add(new HomeAnimal(HomeAnimal.Names.cock)); }


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
    }

}
