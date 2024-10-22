namespace banco
{
    partial class saque
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
            tbxvalorS = new TextBox();
            label2 = new Label();
            tbxsenhaS = new TextBox();
            senha = new Label();
            bntsaque = new Button();
            SuspendLayout();
            // 
            // tbxvalorS
            // 
            tbxvalorS.Location = new Point(140, 78);
            tbxvalorS.Name = "tbxvalorS";
            tbxvalorS.Size = new Size(184, 23);
            tbxvalorS.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(44, 68);
            label2.Name = "label2";
            label2.Size = new Size(63, 33);
            label2.TabIndex = 8;
            label2.Text = "valor";
            // 
            // tbxsenhaS
            // 
            tbxsenhaS.Location = new Point(140, 147);
            tbxsenhaS.Name = "tbxsenhaS";
            tbxsenhaS.PasswordChar = '*';
            tbxsenhaS.Size = new Size(184, 23);
            tbxsenhaS.TabIndex = 7;
            // 
            // senha
            // 
            senha.AutoSize = true;
            senha.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic);
            senha.ForeColor = Color.Blue;
            senha.Location = new Point(39, 137);
            senha.Name = "senha";
            senha.Size = new Size(68, 33);
            senha.TabIndex = 6;
            senha.Text = "senha";
            // 
            // bntsaque
            // 
            bntsaque.BackColor = Color.Blue;
            bntsaque.ForeColor = SystemColors.ButtonHighlight;
            bntsaque.Location = new Point(186, 199);
            bntsaque.Name = "bntsaque";
            bntsaque.Size = new Size(99, 48);
            bntsaque.TabIndex = 5;
            bntsaque.Text = "sacar";
            bntsaque.UseVisualStyleBackColor = false;
            // 
            // saque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 355);
            Controls.Add(tbxvalorS);
            Controls.Add(label2);
            Controls.Add(tbxsenhaS);
            Controls.Add(senha);
            Controls.Add(bntsaque);
            Name = "saque";
            Text = "saque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxvalorS;
        private Label label2;
        private TextBox tbxsenhaS;
        private Label senha;
        private Button bntsaque;
    }
}