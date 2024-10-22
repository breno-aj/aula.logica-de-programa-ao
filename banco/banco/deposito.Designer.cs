namespace banco
{
    partial class deposito
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
            bntDeposito = new Button();
            senha = new Label();
            tbxsenhaD = new TextBox();
            label2 = new Label();
            tbxvalorD = new TextBox();
            SuspendLayout();
            // 
            // bntDeposito
            // 
            bntDeposito.BackColor = Color.Blue;
            bntDeposito.ForeColor = SystemColors.ButtonHighlight;
            bntDeposito.Location = new Point(186, 199);
            bntDeposito.Name = "bntDeposito";
            bntDeposito.Size = new Size(99, 48);
            bntDeposito.TabIndex = 0;
            bntDeposito.Text = "depositar";
            bntDeposito.UseVisualStyleBackColor = false;
            bntDeposito.Click += bntDeposito_Click;
            // 
            // senha
            // 
            senha.AutoSize = true;
            senha.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic);
            senha.ForeColor = Color.Blue;
            senha.Location = new Point(39, 137);
            senha.Name = "senha";
            senha.Size = new Size(68, 33);
            senha.TabIndex = 1;
            senha.Text = "senha";
            // 
            // tbxsenhaD
            // 
            tbxsenhaD.Location = new Point(140, 147);
            tbxsenhaD.Name = "tbxsenhaD";
            tbxsenhaD.PasswordChar = '*';
            tbxsenhaD.Size = new Size(184, 23);
            tbxsenhaD.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(44, 68);
            label2.Name = "label2";
            label2.Size = new Size(63, 33);
            label2.TabIndex = 3;
            label2.Text = "valor";
            // 
            // tbxvalorD
            // 
            tbxvalorD.Location = new Point(140, 78);
            tbxvalorD.Name = "tbxvalorD";
            tbxvalorD.Size = new Size(184, 23);
            tbxvalorD.TabIndex = 4;
            // 
            // deposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 355);
            Controls.Add(tbxvalorD);
            Controls.Add(label2);
            Controls.Add(tbxsenhaD);
            Controls.Add(senha);
            Controls.Add(bntDeposito);
            Name = "deposito";
            Text = "deposito";
            Load += deposito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntDeposito;
        private Label senha;
        private TextBox tbxsenhaD;
        private Label label2;
        private TextBox tbxvalorD;
    }
}