namespace EstructuraDeDatos
{
    partial class matricesTranspuestas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtLimSup = new System.Windows.Forms.TextBox();
            this.txtLimInf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtRenglon = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTransp = new System.Windows.Forms.Button();
            this.btnDimensioanr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLimSup
            // 
            this.txtLimSup.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLimSup.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimSup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtLimSup.Location = new System.Drawing.Point(729, 81);
            this.txtLimSup.Name = "txtLimSup";
            this.txtLimSup.Size = new System.Drawing.Size(273, 46);
            this.txtLimSup.TabIndex = 27;
            this.txtLimSup.Text = "100";
            this.txtLimSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLimSup.TextChanged += new System.EventHandler(this.txtLimSup_TextChanged);
            // 
            // txtLimInf
            // 
            this.txtLimInf.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLimInf.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimInf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtLimInf.Location = new System.Drawing.Point(729, 16);
            this.txtLimInf.Name = "txtLimInf";
            this.txtLimInf.Size = new System.Drawing.Size(273, 46);
            this.txtLimInf.TabIndex = 26;
            this.txtLimInf.Text = "-100";
            this.txtLimInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLimInf.TextChanged += new System.EventHandler(this.txtLimInf_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Victor Mono SemiBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(526, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "Limite sup.: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Victor Mono SemiBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(528, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 33);
            this.label4.TabIndex = 24;
            this.label4.Text = "Limite inf.:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtColumnas
            // 
            this.txtColumnas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtColumnas.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtColumnas.Location = new System.Drawing.Point(195, 81);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(273, 46);
            this.txtColumnas.TabIndex = 23;
            this.txtColumnas.Text = "3";
            this.txtColumnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColumnas.TextChanged += new System.EventHandler(this.txtColumnas_TextChanged);
            // 
            // txtRenglon
            // 
            this.txtRenglon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRenglon.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenglon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRenglon.Location = new System.Drawing.Point(195, 16);
            this.txtRenglon.Name = "txtRenglon";
            this.txtRenglon.Size = new System.Drawing.Size(273, 46);
            this.txtRenglon.TabIndex = 22;
            this.txtRenglon.Text = "7";
            this.txtRenglon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Victor Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(534, 176);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.RowHeadersWidth = 80;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Size = new System.Drawing.Size(487, 262);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Victor Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(22, 176);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersWidth = 80;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Size = new System.Drawing.Size(487, 262);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Victor Mono SemiBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(29, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Columnas: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Victor Mono SemiBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Renglones: ";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandom.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandom.Location = new System.Drawing.Point(183, 444);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(145, 40);
            this.btnRandom.TabIndex = 28;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTransp
            // 
            this.btnTransp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTransp.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTransp.Location = new System.Drawing.Point(619, 444);
            this.btnTransp.Name = "btnTransp";
            this.btnTransp.Size = new System.Drawing.Size(215, 40);
            this.btnTransp.TabIndex = 29;
            this.btnTransp.Text = "Transpuesta";
            this.btnTransp.UseVisualStyleBackColor = false;
            this.btnTransp.Click += new System.EventHandler(this.btnTransp_Click);
            // 
            // btnDimensioanr
            // 
            this.btnDimensioanr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDimensioanr.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDimensioanr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDimensioanr.Location = new System.Drawing.Point(403, 132);
            this.btnDimensioanr.Name = "btnDimensioanr";
            this.btnDimensioanr.Size = new System.Drawing.Size(233, 40);
            this.btnDimensioanr.TabIndex = 30;
            this.btnDimensioanr.Text = "Redimensionar";
            this.btnDimensioanr.UseVisualStyleBackColor = false;
            this.btnDimensioanr.Click += new System.EventHandler(this.btnDimensioanr_Click);
            // 
            // matricesTranspuestas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1035, 496);
            this.Controls.Add(this.btnDimensioanr);
            this.Controls.Add(this.btnTransp);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtLimSup);
            this.Controls.Add(this.txtLimInf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.txtRenglon);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "matricesTranspuestas";
            this.Text = "matricesTranspuestas";
            this.Load += new System.EventHandler(this.matricesTranspuestas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimSup;
        private System.Windows.Forms.TextBox txtLimInf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtRenglon;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTransp;
        private System.Windows.Forms.Button btnDimensioanr;
    }
}