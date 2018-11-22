namespace SystemTeca
{
    partial class FmrDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrDevolucao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.PessoaTxt = new System.Windows.Forms.TextBox();
            this.MidiaTxt = new System.Windows.Forms.TextBox();
            this.QuantidadeTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataSaidaTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OperadorTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ObsEmprestimo = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.QuantidadeDevolvidaNumeric = new System.Windows.Forms.NumericUpDown();
            this.labelObsJust = new System.Windows.Forms.Label();
            this.ObservacaoTextArea = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeDevolvidaNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Devolução";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(383, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 59);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirmar Devolução";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 59);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ObservacaoTextArea);
            this.panel1.Controls.Add(this.labelObsJust);
            this.panel1.Controls.Add(this.QuantidadeDevolvidaNumeric);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(11, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 133);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Devolução de Material";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ObsEmprestimo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.OperadorTxt);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.DataSaidaTxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.QuantidadeTxt);
            this.panel2.Controls.Add(this.MidiaTxt);
            this.panel2.Controls.Add(this.PessoaTxt);
            this.panel2.Controls.Add(this.IdTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(11, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 268);
            this.panel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(50, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mídia Emprestada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(54, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Emprestado Para:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(77, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id Emprestimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Informações do Emprestimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(4, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Quantidade Emprestada:";
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(199, 18);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.ReadOnly = true;
            this.IdTxt.Size = new System.Drawing.Size(147, 20);
            this.IdTxt.TabIndex = 4;
            // 
            // PessoaTxt
            // 
            this.PessoaTxt.Location = new System.Drawing.Point(198, 44);
            this.PessoaTxt.Name = "PessoaTxt";
            this.PessoaTxt.ReadOnly = true;
            this.PessoaTxt.Size = new System.Drawing.Size(564, 20);
            this.PessoaTxt.TabIndex = 5;
            // 
            // MidiaTxt
            // 
            this.MidiaTxt.Location = new System.Drawing.Point(199, 71);
            this.MidiaTxt.Name = "MidiaTxt";
            this.MidiaTxt.ReadOnly = true;
            this.MidiaTxt.Size = new System.Drawing.Size(563, 20);
            this.MidiaTxt.TabIndex = 6;
            // 
            // QuantidadeTxt
            // 
            this.QuantidadeTxt.Location = new System.Drawing.Point(199, 98);
            this.QuantidadeTxt.Name = "QuantidadeTxt";
            this.QuantidadeTxt.ReadOnly = true;
            this.QuantidadeTxt.Size = new System.Drawing.Size(147, 20);
            this.QuantidadeTxt.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(41, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data do Empretimo:";
            // 
            // DataSaidaTxt
            // 
            this.DataSaidaTxt.Location = new System.Drawing.Point(199, 127);
            this.DataSaidaTxt.Name = "DataSaidaTxt";
            this.DataSaidaTxt.ReadOnly = true;
            this.DataSaidaTxt.Size = new System.Drawing.Size(147, 20);
            this.DataSaidaTxt.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Operador do Empretimo:";
            // 
            // OperadorTxt
            // 
            this.OperadorTxt.Location = new System.Drawing.Point(199, 156);
            this.OperadorTxt.Name = "OperadorTxt";
            this.OperadorTxt.ReadOnly = true;
            this.OperadorTxt.Size = new System.Drawing.Size(563, 20);
            this.OperadorTxt.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(92, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Observação:";
            // 
            // ObsEmprestimo
            // 
            this.ObsEmprestimo.Location = new System.Drawing.Point(199, 182);
            this.ObsEmprestimo.Name = "ObsEmprestimo";
            this.ObsEmprestimo.ReadOnly = true;
            this.ObsEmprestimo.Size = new System.Drawing.Size(563, 75);
            this.ObsEmprestimo.TabIndex = 13;
            this.ObsEmprestimo.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(13, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "*Quantidade Devolvida:";
            // 
            // QuantidadeDevolvidaNumeric
            // 
            this.QuantidadeDevolvidaNumeric.Location = new System.Drawing.Point(198, 16);
            this.QuantidadeDevolvidaNumeric.Name = "QuantidadeDevolvidaNumeric";
            this.QuantidadeDevolvidaNumeric.Size = new System.Drawing.Size(120, 20);
            this.QuantidadeDevolvidaNumeric.TabIndex = 15;
            this.QuantidadeDevolvidaNumeric.ValueChanged += new System.EventHandler(this.QuantidadeDevolvidaNumeric_ValueChanged);
            // 
            // labelObsJust
            // 
            this.labelObsJust.AutoSize = true;
            this.labelObsJust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelObsJust.Location = new System.Drawing.Point(89, 46);
            this.labelObsJust.Name = "labelObsJust";
            this.labelObsJust.Size = new System.Drawing.Size(100, 17);
            this.labelObsJust.TabIndex = 14;
            this.labelObsJust.Text = "Observação:";
            // 
            // ObservacaoTextArea
            // 
            this.ObservacaoTextArea.Location = new System.Drawing.Point(198, 45);
            this.ObservacaoTextArea.Name = "ObservacaoTextArea";
            this.ObservacaoTextArea.Size = new System.Drawing.Size(564, 76);
            this.ObservacaoTextArea.TabIndex = 16;
            this.ObservacaoTextArea.Text = "";
            // 
            // FmrDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmrDevolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemOteca - Sistema Gerenciador de Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeDevolvidaNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ObsEmprestimo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OperadorTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DataSaidaTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QuantidadeTxt;
        private System.Windows.Forms.TextBox MidiaTxt;
        private System.Windows.Forms.TextBox PessoaTxt;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox ObservacaoTextArea;
        private System.Windows.Forms.Label labelObsJust;
        private System.Windows.Forms.NumericUpDown QuantidadeDevolvidaNumeric;
        private System.Windows.Forms.Label label11;
    }
}