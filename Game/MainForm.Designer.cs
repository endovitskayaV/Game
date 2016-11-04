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
            this.rules_Btn = new System.Windows.Forms.Button();
            this.exit_Btn = new System.Windows.Forms.Button();
            this.money_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Shop_Btn
            // 
            this.Shop_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Shop_Btn.FlatAppearance.BorderSize = 0;
            this.Shop_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shop_Btn.Location = new System.Drawing.Point(12, 110);
            this.Shop_Btn.Name = "Shop_Btn";
            this.Shop_Btn.Size = new System.Drawing.Size(55, 55);
            this.Shop_Btn.TabIndex = 0;
            this.Shop_Btn.UseVisualStyleBackColor = true;
            this.Shop_Btn.Click += new System.EventHandler(this.Shop_Btn_Click);
            // 
            // rules_Btn
            // 
            this.rules_Btn.FlatAppearance.BorderSize = 0;
            this.rules_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rules_Btn.Location = new System.Drawing.Point(12, 171);
            this.rules_Btn.Name = "rules_Btn";
            this.rules_Btn.Size = new System.Drawing.Size(55, 55);
            this.rules_Btn.TabIndex = 3;
            this.rules_Btn.UseVisualStyleBackColor = true;
            this.rules_Btn.Click += new System.EventHandler(this.rules_Btn_Click);
            // 
            // exit_Btn
            // 
            this.exit_Btn.FlatAppearance.BorderSize = 0;
            this.exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Btn.Location = new System.Drawing.Point(21, 12);
            this.exit_Btn.Name = "exit_Btn";
            this.exit_Btn.Size = new System.Drawing.Size(23, 23);
            this.exit_Btn.TabIndex = 4;
            this.exit_Btn.UseVisualStyleBackColor = true;
            this.exit_Btn.Click += new System.EventHandler(this.exit_Btn_Click);
            // 
            // money_Lbl
            // 
            this.money_Lbl.AutoSize = true;
            this.money_Lbl.Location = new System.Drawing.Point(31, 96);
            this.money_Lbl.Name = "money_Lbl";
            this.money_Lbl.Size = new System.Drawing.Size(13, 13);
            this.money_Lbl.TabIndex = 5;
            this.money_Lbl.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.money_Lbl);
            this.Controls.Add(this.exit_Btn);
            this.Controls.Add(this.rules_Btn);
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
        private System.Windows.Forms.Button rules_Btn;
        private System.Windows.Forms.Button exit_Btn;
        private System.Windows.Forms.Label money_Lbl;
    }
}

