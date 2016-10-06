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
   public partial class Shop: Form
    {
        private Label label1;
        private Label label2;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Trap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Embryos";
            // 
            // Shop
            // 
            this.ClientSize = new System.Drawing.Size(347, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Tb_Mouse_Click(object sender, MouseEventArgs e)
        {
            int i = 0;
            if (i>0) ;
            else;
        }
    }

}
