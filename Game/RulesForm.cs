using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game
{
    class RulesForm:Form
    {
        private Button exit_Btn;

        public RulesForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.exit_Btn = new System.Windows.Forms.Button();
            this.richTB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // exit_Btn
            // 
            this.exit_Btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.exit_Btn.FlatAppearance.BorderSize = 0;
            this.exit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.exit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Btn.Location = new System.Drawing.Point(415, 12);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(23, 23);
            this.exit_Btn.TabIndex = 0;
            this.exit_Btn.UseVisualStyleBackColor = true;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            this.exit_Btn.MouseLeave += new System.EventHandler(this.exit_Btn_MouseLeave);
            this.exit_Btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.exit_Btn_MouseMove);
            // 
            // richTB
            // 
            this.richTB.BackColor = System.Drawing.SystemColors.Control;
            this.richTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTB.Location = new System.Drawing.Point(12, 28);
            this.richTB.Name = "richTB";
            this.richTB.Size = new System.Drawing.Size(397, 321);
            this.richTB.TabIndex = 1;
            this.richTB.Text = "";
            // 
            // RulesForm
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.richTB);
            this.Controls.Add(this.exit_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RulesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RulesForm_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RulesForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Rules_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Rules_MouseMove);
            this.ResumeLayout(false);

        }

        int iFormX, iFormY, iMouseX, iMouseY;
        private RichTextBox richTB;

        private void exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RulesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.TimerStart();
        }

        private void exit_Btn_MouseLeave(object sender, EventArgs e)
        {
            exit_Btn.Image = Image.FromFile("exit2.png");
        }

        private void RulesForm_Paint(object sender, PaintEventArgs e)
        {
            exit_Btn.Image = Image.FromFile("exit2.png");
        }

        private void exit_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            exit_Btn.Image = Image.FromFile("exit3.png");
        }

        

        private void Rules_MouseDown(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void Rules_MouseMove(object sender, MouseEventArgs e)
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }
    }
}
