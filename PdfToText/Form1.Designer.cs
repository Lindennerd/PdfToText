namespace PdfToText
{
    partial class Form1
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
            this.txtPDFPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPdfSearch = new System.Windows.Forms.Button();
            this.btnOutputSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rdAllPages = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdSpecificRange = new System.Windows.Forms.RadioButton();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPDFPath
            // 
            this.txtPDFPath.Location = new System.Drawing.Point(122, 23);
            this.txtPDFPath.Name = "txtPDFPath";
            this.txtPDFPath.Size = new System.Drawing.Size(299, 20);
            this.txtPDFPath.TabIndex = 0;
            this.txtPDFPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho para o PDF";
            // 
            // btnPdfSearch
            // 
            this.btnPdfSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPdfSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPdfSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfSearch.Location = new System.Drawing.Point(427, 21);
            this.btnPdfSearch.Name = "btnPdfSearch";
            this.btnPdfSearch.Size = new System.Drawing.Size(62, 23);
            this.btnPdfSearch.TabIndex = 2;
            this.btnPdfSearch.Text = "Procurar";
            this.btnPdfSearch.UseVisualStyleBackColor = true;
            this.btnPdfSearch.Click += new System.EventHandler(this.btnPdfSearch_Click);
            // 
            // btnOutputSearch
            // 
            this.btnOutputSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOutputSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOutputSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutputSearch.Location = new System.Drawing.Point(427, 59);
            this.btnOutputSearch.Name = "btnOutputSearch";
            this.btnOutputSearch.Size = new System.Drawing.Size(62, 23);
            this.btnOutputSearch.TabIndex = 5;
            this.btnOutputSearch.Text = "Procurar";
            this.btnOutputSearch.UseVisualStyleBackColor = true;
            this.btnOutputSearch.Click += new System.EventHandler(this.btnOutputSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caminho de Saída";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(122, 61);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(299, 20);
            this.txtOutputPath.TabIndex = 3;
            this.txtOutputPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProcess
            // 
            this.btnProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(12, 174);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(504, 54);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Processar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // rdAllPages
            // 
            this.rdAllPages.AutoSize = true;
            this.rdAllPages.Checked = true;
            this.rdAllPages.Location = new System.Drawing.Point(20, 24);
            this.rdAllPages.Name = "rdAllPages";
            this.rdAllPages.Size = new System.Drawing.Size(110, 17);
            this.rdAllPages.TabIndex = 7;
            this.rdAllPages.TabStop = true;
            this.rdAllPages.Text = "Todas as Páginas";
            this.rdAllPages.UseVisualStyleBackColor = true;
            this.rdAllPages.CheckedChanged += new System.EventHandler(this.rdAllPages_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOutputPath);
            this.groupBox1.Controls.Add(this.txtPDFPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOutputSearch);
            this.groupBox1.Controls.Add(this.btnPdfSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numTo);
            this.groupBox2.Controls.Add(this.numFrom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rdSpecificRange);
            this.groupBox2.Controls.Add(this.rdAllPages);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 65);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuração de Leitura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "De";
            // 
            // rdSpecificRange
            // 
            this.rdSpecificRange.AutoSize = true;
            this.rdSpecificRange.Location = new System.Drawing.Point(161, 24);
            this.rdSpecificRange.Name = "rdSpecificRange";
            this.rdSpecificRange.Size = new System.Drawing.Size(120, 17);
            this.rdSpecificRange.TabIndex = 8;
            this.rdSpecificRange.TabStop = true;
            this.rdSpecificRange.Text = "Intervalo Específico";
            this.rdSpecificRange.UseVisualStyleBackColor = true;
            this.rdSpecificRange.CheckedChanged += new System.EventHandler(this.rdSpecificRange_CheckedChanged);
            // 
            // numFrom
            // 
            this.numFrom.Enabled = false;
            this.numFrom.Location = new System.Drawing.Point(346, 24);
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(46, 20);
            this.numFrom.TabIndex = 13;
            // 
            // numTo
            // 
            this.numTo.Enabled = false;
            this.numTo.Location = new System.Drawing.Point(427, 24);
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(46, 20);
            this.numTo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 234);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProcess);
            this.Name = "Form1";
            this.Text = "PDF to Text Converter 0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPDFPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPdfSearch;
        private System.Windows.Forms.Button btnOutputSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.RadioButton rdAllPages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdSpecificRange;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.NumericUpDown numFrom;
    }
}

