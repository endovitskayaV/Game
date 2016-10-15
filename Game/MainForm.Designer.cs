namespace Game
{
    partial class MainForm
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
            this.Shop_Btn = new System.Windows.Forms.Button();
            this.moneyShow_Lbl = new System.Windows.Forms.Label();
            this.byuings_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Shop_Btn
            // 
            this.Shop_Btn.Location = new System.Drawing.Point(12, 4);
            this.Shop_Btn.Name = "Shop_Btn";
            this.Shop_Btn.Size = new System.Drawing.Size(43, 23);
            this.Shop_Btn.TabIndex = 0;
            this.Shop_Btn.Text = "Shop";
            this.Shop_Btn.UseVisualStyleBackColor = true;
            this.Shop_Btn.Click += new System.EventHandler(this.Shop_Btn_Click);
            // 
            // moneyShow_Lbl
            // 
            this.moneyShow_Lbl.AutoSize = true;
            this.moneyShow_Lbl.Location = new System.Drawing.Point(76, 9);
            this.moneyShow_Lbl.Name = "moneyShow_Lbl";
            this.moneyShow_Lbl.Size = new System.Drawing.Size(13, 13);
            this.moneyShow_Lbl.TabIndex = 1;
            this.moneyShow_Lbl.Text = "0";
            // 
            // byuings_Panel
            // 
            this.byuings_Panel.Location = new System.Drawing.Point(12, 33);
            this.byuings_Panel.Name = "byuings_Panel";
            this.byuings_Panel.Size = new System.Drawing.Size(108, 278);
            this.byuings_Panel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 323);
            this.Controls.Add(this.byuings_Panel);
            this.Controls.Add(this.moneyShow_Lbl);
            this.Controls.Add(this.Shop_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Shop_Btn;
        private System.Windows.Forms.Label moneyShow_Lbl;
        private System.Windows.Forms.Panel byuings_Panel;
    }
}

