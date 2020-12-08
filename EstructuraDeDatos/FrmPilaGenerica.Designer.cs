namespace EstructuraDeDatos
{
    partial class FrmPilaGenerica
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTope = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInferior = new System.Windows.Forms.TextBox();
            this.txtSuperior = new System.Windows.Forms.TextBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPilita = new System.Windows.Forms.Button();
            this.txtCaptura = new System.Windows.Forms.TextBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.lbl10Elementos = new System.Windows.Forms.Label();
            this.lblPila = new System.Windows.Forms.Label();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnReversa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnElement = new System.Windows.Forms.Button();
            this.txtIndice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(66, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(177, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pilas";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // lblTope
            // 
            this.lblTope.AutoSize = true;
            this.lblTope.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTope.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTope.Location = new System.Drawing.Point(15, 91);
            this.lblTope.Name = "lblTope";
            this.lblTope.Size = new System.Drawing.Size(44, 18);
            this.lblTope.TabIndex = 2;
            this.lblTope.Text = "Tope";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(257, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Limite Inferior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(257, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Limite Superior";
            // 
            // txtInferior
            // 
            this.txtInferior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInferior.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInferior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInferior.Location = new System.Drawing.Point(435, 103);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(171, 29);
            this.txtInferior.TabIndex = 5;
            this.txtInferior.Text = "1";
            // 
            // txtSuperior
            // 
            this.txtSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSuperior.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuperior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSuperior.Location = new System.Drawing.Point(435, 148);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(171, 29);
            this.txtSuperior.TabIndex = 6;
            this.txtSuperior.Text = "100";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandom.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRandom.Location = new System.Drawing.Point(800, 91);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(191, 45);
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(800, 290);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(191, 45);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "pilita.Clear()";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPilita
            // 
            this.btnPilita.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPilita.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPilita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilita.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPilita.Location = new System.Drawing.Point(249, 192);
            this.btnPilita.Name = "btnPilita";
            this.btnPilita.Size = new System.Drawing.Size(172, 43);
            this.btnPilita.TabIndex = 9;
            this.btnPilita.Text = "pilita.Push()";
            this.btnPilita.UseVisualStyleBackColor = false;
            this.btnPilita.Click += new System.EventHandler(this.btnPilita_Click);
            // 
            // txtCaptura
            // 
            this.txtCaptura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptura.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtCaptura.Location = new System.Drawing.Point(435, 204);
            this.txtCaptura.Name = "txtCaptura";
            this.txtCaptura.Size = new System.Drawing.Size(171, 31);
            this.txtCaptura.TabIndex = 10;
            this.txtCaptura.Text = "000000";
            this.txtCaptura.TextChanged += new System.EventHandler(this.txtCaptura_TextChanged);
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPop.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPop.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPop.Location = new System.Drawing.Point(800, 425);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(191, 43);
            this.btnPop.TabIndex = 11;
            this.btnPop.Text = "pilita.Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // lbl10Elementos
            // 
            this.lbl10Elementos.AutoSize = true;
            this.lbl10Elementos.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10Elementos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl10Elementos.Location = new System.Drawing.Point(15, 23);
            this.lbl10Elementos.Name = "lbl10Elementos";
            this.lbl10Elementos.Size = new System.Drawing.Size(269, 18);
            this.lbl10Elementos.TabIndex = 13;
            this.lbl10Elementos.Text = "La pila contiene 10 elementos";
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPila.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPila.Location = new System.Drawing.Point(390, 23);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(242, 18);
            this.lblPila.TabIndex = 14;
            this.lblPila.Text = "En el tope de la pila hay:";
            // 
            // btnContains
            // 
            this.btnContains.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContains.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnContains.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContains.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContains.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnContains.Location = new System.Drawing.Point(800, 360);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(191, 45);
            this.btnContains.TabIndex = 15;
            this.btnContains.Text = "pilita.Contains()";
            this.btnContains.UseVisualStyleBackColor = false;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGet.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGet.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGet.Location = new System.Drawing.Point(800, 221);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(191, 45);
            this.btnGet.TabIndex = 16;
            this.btnGet.Text = "pilita.getType()";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnReversa
            // 
            this.btnReversa.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReversa.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReversa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReversa.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReversa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReversa.Location = new System.Drawing.Point(800, 154);
            this.btnReversa.Name = "btnReversa";
            this.btnReversa.Size = new System.Drawing.Size(191, 45);
            this.btnReversa.TabIndex = 17;
            this.btnReversa.Text = "pilita.Reverse()";
            this.btnReversa.UseVisualStyleBackColor = false;
            this.btnReversa.Click += new System.EventHandler(this.btnReversa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(823, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Metodos de pilas";
            // 
            // btnElement
            // 
            this.btnElement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnElement.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElement.Font = new System.Drawing.Font("Victor Mono Medium", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnElement.Location = new System.Drawing.Point(249, 290);
            this.btnElement.Name = "btnElement";
            this.btnElement.Size = new System.Drawing.Size(172, 43);
            this.btnElement.TabIndex = 19;
            this.btnElement.Text = "element";
            this.btnElement.UseVisualStyleBackColor = false;
            this.btnElement.Click += new System.EventHandler(this.btnElement_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndice.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtIndice.Location = new System.Drawing.Point(435, 290);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(171, 31);
            this.txtIndice.TabIndex = 20;
            this.txtIndice.Text = "000000";
            // 
            // FrmPilaGenerica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1036, 502);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnElement);
            this.Controls.Add(this.label3);
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
            this.Name = "FrmPilaGenerica";
            this.Text = "FrmPilaGenerica";
            this.Load += new System.EventHandler(this.FrmPilaGenerica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblTope;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInferior;
        private System.Windows.Forms.TextBox txtSuperior;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPilita;
        private System.Windows.Forms.TextBox txtCaptura;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Label lbl10Elementos;
        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnReversa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnElement;
        private System.Windows.Forms.TextBox txtIndice;
    }
}