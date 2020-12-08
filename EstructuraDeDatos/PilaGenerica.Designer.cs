namespace EstructuraDeDatos
{
    partial class PilaGenerica
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnElementAt = new System.Windows.Forms.Button();
            this.btnReversa = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.lblPila = new System.Windows.Forms.Label();
            this.lbl10Elementos = new System.Windows.Forms.Label();
            this.btnPop = new System.Windows.Forms.Button();
            this.txtCaptura = new System.Windows.Forms.TextBox();
            this.btnPilita = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTope = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIndice
            // 
            this.txtIndice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIndice.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndice.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIndice.Location = new System.Drawing.Point(828, 112);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(245, 37);
            this.txtIndice.TabIndex = 37;
            // 
            // btnElementAt
            // 
            this.btnElementAt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElementAt.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElementAt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnElementAt.Location = new System.Drawing.Point(631, 98);
            this.btnElementAt.Name = "btnElementAt";
            this.btnElementAt.Size = new System.Drawing.Size(191, 45);
            this.btnElementAt.TabIndex = 36;
            this.btnElementAt.Text = "pilita.ElementAt()";
            this.btnElementAt.UseVisualStyleBackColor = false;
            // 
            // btnReversa
            // 
            this.btnReversa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReversa.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReversa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReversa.Location = new System.Drawing.Point(631, 156);
            this.btnReversa.Name = "btnReversa";
            this.btnReversa.Size = new System.Drawing.Size(191, 45);
            this.btnReversa.TabIndex = 35;
            this.btnReversa.Text = "pilita.Reverse()";
            this.btnReversa.UseVisualStyleBackColor = false;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGet.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGet.Location = new System.Drawing.Point(807, 223);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(191, 45);
            this.btnGet.TabIndex = 34;
            this.btnGet.Text = "pilita.getType()";
            this.btnGet.UseVisualStyleBackColor = false;
            // 
            // btnContains
            // 
            this.btnContains.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContains.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContains.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContains.Location = new System.Drawing.Point(591, 223);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(191, 45);
            this.btnContains.TabIndex = 33;
            this.btnContains.Text = "pilita.Contains()";
            this.btnContains.UseVisualStyleBackColor = false;
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPila.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPila.Location = new System.Drawing.Point(507, 25);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(324, 26);
            this.lblPila.TabIndex = 32;
            this.lblPila.Text = "En el tope de la pila hay:";
            // 
            // lbl10Elementos
            // 
            this.lbl10Elementos.AutoSize = true;
            this.lbl10Elementos.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10Elementos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl10Elementos.Location = new System.Drawing.Point(22, 25);
            this.lbl10Elementos.Name = "lbl10Elementos";
            this.lbl10Elementos.Size = new System.Drawing.Size(360, 26);
            this.lbl10Elementos.TabIndex = 31;
            this.lbl10Elementos.Text = "La pila contiene 10 elementos";
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPop.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPop.Location = new System.Drawing.Point(294, 364);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(201, 43);
            this.btnPop.TabIndex = 30;
            this.btnPop.Text = "pilita.Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            // 
            // txtCaptura
            // 
            this.txtCaptura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCaptura.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCaptura.Location = new System.Drawing.Point(501, 306);
            this.txtCaptura.Name = "txtCaptura";
            this.txtCaptura.Size = new System.Drawing.Size(245, 46);
            this.txtCaptura.TabIndex = 29;
            // 
            // btnPilita
            // 
            this.btnPilita.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPilita.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPilita.Location = new System.Drawing.Point(294, 300);
            this.btnPilita.Name = "btnPilita";
            this.btnPilita.Size = new System.Drawing.Size(201, 43);
            this.btnPilita.TabIndex = 28;
            this.btnPilita.Text = "pilita.Push()";
            this.btnPilita.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(414, 223);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(171, 45);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "pilita.Clear()";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandom.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRandom.Location = new System.Drawing.Point(268, 223);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(137, 45);
            this.btnRandom.TabIndex = 26;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            // 
            // txtSuperior
            // 
            this.txtSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSuperior.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuperior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSuperior.Location = new System.Drawing.Point(442, 150);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(171, 46);
            this.txtSuperior.TabIndex = 25;
            this.txtSuperior.Text = "100";
            // 
            // txtInferior
            // 
            this.txtInferior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInferior.Font = new System.Drawing.Font("Victor Mono Medium", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInferior.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInferior.Location = new System.Drawing.Point(442, 105);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(171, 46);
            this.txtInferior.TabIndex = 24;
            this.txtInferior.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Limite Superior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Limite Inferior";
            // 
            // lblTope
            // 
            this.lblTope.AutoSize = true;
            this.lblTope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTope.Location = new System.Drawing.Point(-125, 93);
            this.lblTope.Name = "lblTope";
            this.lblTope.Size = new System.Drawing.Size(45, 20);
            this.lblTope.TabIndex = 21;
            this.lblTope.Text = "Tope";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(27, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(223, 443);
            this.dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pilas";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // PilaGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1091, 551);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnElementAt);
            this.Controls.Add(this.btnReversa);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.lbl10Elementos);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.txtCaptura);
            this.Controls.Add(this.btnPilita);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtSuperior);
            this.Controls.Add(this.txtInferior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTope);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PilaGenerica";
            this.Text = "PilaGenerica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.Button btnElementAt;
        private System.Windows.Forms.Button btnReversa;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.Label lbl10Elementos;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.TextBox txtCaptura;
        private System.Windows.Forms.Button btnPilita;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtSuperior;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTope;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}