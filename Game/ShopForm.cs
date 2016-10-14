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
   public partial class ShopForm: Form
    {
        
        private Label traps_Lbl;
        private Button buy_Btn;
        private Panel panel1;
        private RadioButton boar_RBtn;
        private RadioButton bear_RBtn;
        private RadioButton wolf_RBtn;
        private RadioButton fox_RBtn;
        private Panel panel2;
        private RadioButton duck_RBtn;
        private RadioButton cock_RBtn;
        private RadioButton hen_RBtn;
        private RadioButton pig_RBtn;
        private RadioButton rabit_RBtn;
        private Label label2;
        
        private void InitializeComponent()
        { 
            this.traps_Lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buy_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boar_RBtn = new System.Windows.Forms.RadioButton();
            this.bear_RBtn = new System.Windows.Forms.RadioButton();
            this.wolf_RBtn = new System.Windows.Forms.RadioButton();
            this.fox_RBtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.duck_RBtn = new System.Windows.Forms.RadioButton();
            this.cock_RBtn = new System.Windows.Forms.RadioButton();
            this.hen_RBtn = new System.Windows.Forms.RadioButton();
            this.pig_RBtn = new System.Windows.Forms.RadioButton();
            this.rabit_RBtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // traps_Lbl
            // 
            this.traps_Lbl.AutoSize = true;
            this.traps_Lbl.Location = new System.Drawing.Point(27, 13);
            this.traps_Lbl.Name = "traps_Lbl";
            this.traps_Lbl.Size = new System.Drawing.Size(37, 13);
            this.traps_Lbl.TabIndex = 9;
            this.traps_Lbl.Text = "Traps:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Embryos";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.boar_RBtn);
            this.panel1.Controls.Add(this.bear_RBtn);
            this.panel1.Controls.Add(this.wolf_RBtn);
            this.panel1.Controls.Add(this.fox_RBtn);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 100);
            this.panel1.TabIndex = 12;
            // 
            // boar_RBtn
            // 
            this.boar_RBtn.AutoSize = true;
            this.boar_RBtn.Location = new System.Drawing.Point(4, 75);
            this.boar_RBtn.Name = "boar_RBtn";
            this.boar_RBtn.Size = new System.Drawing.Size(46, 17);
            this.boar_RBtn.TabIndex = 3;
            this.boar_RBtn.TabStop = true;
            this.boar_RBtn.Text = "boar";
            this.boar_RBtn.UseVisualStyleBackColor = true;
            // 
            // bear_RBtn
            // 
            this.bear_RBtn.AutoSize = true;
            this.bear_RBtn.Location = new System.Drawing.Point(4, 51);
            this.bear_RBtn.Name = "bear_RBtn";
            this.bear_RBtn.Size = new System.Drawing.Size(46, 17);
            this.bear_RBtn.TabIndex = 2;
            this.bear_RBtn.TabStop = true;
            this.bear_RBtn.Text = "bear";
            this.bear_RBtn.UseVisualStyleBackColor = true;
            // 
            // wolf_RBtn
            // 
            this.wolf_RBtn.AutoSize = true;
            this.wolf_RBtn.Location = new System.Drawing.Point(4, 28);
            this.wolf_RBtn.Name = "wolf_RBtn";
            this.wolf_RBtn.Size = new System.Drawing.Size(44, 17);
            this.wolf_RBtn.TabIndex = 1;
            this.wolf_RBtn.TabStop = true;
            this.wolf_RBtn.Text = "wolf";
            this.wolf_RBtn.UseVisualStyleBackColor = true;
            // 
            // fox_RBtn
            // 
            this.fox_RBtn.AutoSize = true;
            this.fox_RBtn.Location = new System.Drawing.Point(4, 4);
            this.fox_RBtn.Name = "fox_RBtn";
            this.fox_RBtn.Size = new System.Drawing.Size(39, 17);
            this.fox_RBtn.TabIndex = 0;
            this.fox_RBtn.TabStop = true;
            this.fox_RBtn.Text = "fox";
            this.fox_RBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.duck_RBtn);
            this.panel2.Controls.Add(this.cock_RBtn);
            this.panel2.Controls.Add(this.hen_RBtn);
            this.panel2.Controls.Add(this.pig_RBtn);
            this.panel2.Controls.Add(this.rabit_RBtn);
            this.panel2.Location = new System.Drawing.Point(140, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 126);
            this.panel2.TabIndex = 13;
            // 
            // duck_RBtn
            // 
            this.duck_RBtn.AutoSize = true;
            this.duck_RBtn.Location = new System.Drawing.Point(3, 30);
            this.duck_RBtn.Name = "duck_RBtn";
            this.duck_RBtn.Size = new System.Drawing.Size(49, 17);
            this.duck_RBtn.TabIndex = 5;
            this.duck_RBtn.TabStop = true;
            this.duck_RBtn.Text = "duck";
            this.duck_RBtn.UseVisualStyleBackColor = true;
            // 
            // cock_RBtn
            // 
            this.cock_RBtn.AutoSize = true;
            this.cock_RBtn.Location = new System.Drawing.Point(3, 100);
            this.cock_RBtn.Name = "cock_RBtn";
            this.cock_RBtn.Size = new System.Drawing.Size(49, 17);
            this.cock_RBtn.TabIndex = 4;
            this.cock_RBtn.TabStop = true;
            this.cock_RBtn.Text = "cock";
            this.cock_RBtn.UseVisualStyleBackColor = true;
            // 
            // hen_RBtn
            // 
            this.hen_RBtn.AutoSize = true;
            this.hen_RBtn.Location = new System.Drawing.Point(3, 77);
            this.hen_RBtn.Name = "hen_RBtn";
            this.hen_RBtn.Size = new System.Drawing.Size(43, 17);
            this.hen_RBtn.TabIndex = 3;
            this.hen_RBtn.TabStop = true;
            this.hen_RBtn.Text = "hen";
            this.hen_RBtn.UseVisualStyleBackColor = true;
            // 
            // pig_RBtn
            // 
            this.pig_RBtn.AutoSize = true;
            this.pig_RBtn.Location = new System.Drawing.Point(3, 54);
            this.pig_RBtn.Name = "pig_RBtn";
            this.pig_RBtn.Size = new System.Drawing.Size(39, 17);
            this.pig_RBtn.TabIndex = 2;
            this.pig_RBtn.TabStop = true;
            this.pig_RBtn.Text = "pig";
            this.pig_RBtn.UseVisualStyleBackColor = true;
            // 
            // rabit_RBtn
            // 
            this.rabit_RBtn.AutoSize = true;
            this.rabit_RBtn.Location = new System.Drawing.Point(3, 7);
            this.rabit_RBtn.Name = "rabit_RBtn";
            this.rabit_RBtn.Size = new System.Drawing.Size(45, 17);
            this.rabit_RBtn.TabIndex = 1;
            this.rabit_RBtn.TabStop = true;
            this.rabit_RBtn.Text = "rabit";
            this.rabit_RBtn.UseVisualStyleBackColor = true;
            // 
            // ShopForm
            // 
            this.ClientSize = new System.Drawing.Size(227, 204);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buy_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.traps_Lbl);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            

        }

        private void Tb_Mouse_Click(object sender, MouseEventArgs e)
        {
            int i = 0;
            if (i>0) ;
            else;
        }

        private void buy_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }

}
