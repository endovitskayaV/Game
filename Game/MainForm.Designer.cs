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
            this.rules_Btn = new System.Windows.Forms.Button();
            this.exit_Btn = new System.Windows.Forms.Button();
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
            this.byuings_Panel.Location = new System.Drawing.Point(40, 126);
            this.byuings_Panel.Name = "byuings_Panel";
            this.byuings_Panel.Size = new System.Drawing.Size(36, 19);
            this.byuings_Panel.TabIndex = 2;
            // 
            // rules_Btn
            // 
            this.rules_Btn.Location = new System.Drawing.Point(12, 33);
            this.rules_Btn.Name = "rules_Btn";
            this.rules_Btn.Size = new System.Drawing.Size(43, 23);
            this.rules_Btn.TabIndex = 3;
            this.rules_Btn.Text = "Rules";
            this.rules_Btn.UseVisualStyleBackColor = true;
            this.rules_Btn.Click += new System.EventHandler(this.rules_Btn_Click);
            // 
            // exit_Btn
            // 
            this.exit_Btn.Location = new System.Drawing.Point(13, 63);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(42, 23);
            this.exit_Btn.TabIndex = 4;
            this.exit_Btn.Text = "Exit";
            this.exit_Btn.UseVisualStyleBackColor = true;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.exit_Btn);
            this.Controls.Add(this.rules_Btn);
            this.Controls.Add(this.byuings_Panel);
            this.Controls.Add(this.moneyShow_Lbl);
            this.Controls.Add(this.Shop_Btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mouse_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Shop_Btn;
        private System.Windows.Forms.Label moneyShow_Lbl;
        private System.Windows.Forms.Panel byuings_Panel;
        private System.Windows.Forms.Button rules_Btn;
        private System.Windows.Forms.Button exit_Btn;
    }
}

