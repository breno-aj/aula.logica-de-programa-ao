namespace banco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaldo = new Button();
            label1 = new Label();
            btnDeposito = new Button();
            bntSaque = new Button();
            label2 = new Label();
            label3 = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btnSaldo
            // 
            btnSaldo.BackColor = Color.Blue;
            btnSaldo.ForeColor = SystemColors.ButtonHighlight;
            btnSaldo.Location = new Point(45, 211);
            btnSaldo.Name = "btnSaldo";
            btnSaldo.Size = new Size(75, 23);
            btnSaldo.TabIndex = 0;
            btnSaldo.Text = "saldo";
            btnSaldo.UseVisualStyleBackColor = false;
            btnSaldo.Click += btnSaldo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 25.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(45, 71);
            label1.Name = "label1";
            label1.Size = new Size(204, 42);
            label1.TabIndex = 1;
            label1.Text = "bem vindo ao ";
            // 
            // btnDeposito
            // 
            btnDeposito.BackColor = Color.Blue;
            btnDeposito.ForeColor = SystemColors.ButtonHighlight;
            btnDeposito.Location = new Point(166, 211);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(75, 23);
            btnDeposito.TabIndex = 2;
            btnDeposito.Text = "deposito";
            btnDeposito.UseVisualStyleBackColor = false;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // bntSaque
            // 
            bntSaque.BackColor = Color.Blue;
            bntSaque.ForeColor = SystemColors.ButtonHighlight;
            bntSaque.Location = new Point(281, 211);
            bntSaque.Name = "bntSaque";
            bntSaque.Size = new Size(75, 23);
            bntSaque.TabIndex = 3;
            bntSaque.Text = "saque";
            bntSaque.UseVisualStyleBackColor = false;
            bntSaque.Click += bntSaque_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("CommercialScript BT", 40.25F);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(81, 128);
            label2.Name = "label2";
            label2.Size = new Size(241, 62);
            label2.TabIndex = 4;
            label2.Text = "banco sena";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 278);
            label3.Name = "label3";
            label3.Size = new Size(235, 15);
            label3.TabIndex = 5;
            label3.Text = "Tratamos seu dinheiro como se fosse nosso";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 355);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bntSaque);
            Controls.Add(btnDeposito);
            Controls.Add(label1);
            Controls.Add(btnSaldo);
            Name = "Form1";
            Text = "banco sena";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaldo;
        private Label label1;
        private Button btnDeposito;
        private Button bntSaque;
        private Label label2;
        private Label label3;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
