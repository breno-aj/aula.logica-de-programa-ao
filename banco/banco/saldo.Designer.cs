namespace banco
{
    partial class saldo
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
            label1 = new Label();
            label2 = new Label();
            lblValor = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 51F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(119, 50);
            label1.Name = "label1";
            label1.Size = new Size(159, 83);
            label1.TabIndex = 0;
            label1.Text = "saldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 50F);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(114, 89);
            label2.TabIndex = 1;
            label2.Text = "R$";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 50F);
            lblValor.ForeColor = Color.Blue;
            lblValor.Location = new Point(119, 130);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(161, 89);
            lblValor.TabIndex = 2;
            lblValor.Text = "0,00";
            lblValor.Click += lblValor_Click;
            // 
            // saldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 355);
            Controls.Add(lblValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "saldo";
            Text = "saldo";
            Load += saldo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblValor;
    }
}