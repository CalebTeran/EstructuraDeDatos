namespace EstructuraDeDatos
{
    partial class notacionPostfija
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
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Operandos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // txtColumnas
            // 
            this.txtColumnas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtColumnas.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtColumnas.Location = new System.Drawing.Point(228, -229);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(273, 46);
            this.txtColumnas.TabIndex = 45;
            this.txtColumnas.Text = "3";
            this.txtColumnas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExpresion
            // 
            this.txtExpresion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtExpresion.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpresion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtExpresion.Location = new System.Drawing.Point(204, 43);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(594, 46);
            this.txtExpresion.TabIndex = 48;
            this.txtExpresion.Text = "00000000000";
            this.txtExpresion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Victor Mono SemiBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(48, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 33);
            this.label4.TabIndex = 47;
            this.label4.Text = "Expresión";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandom.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRandom.Location = new System.Drawing.Point(830, 182);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(145, 40);
            this.btnRandom.TabIndex = 49;
            this.btnRandom.Text = "Evaluar";
            this.btnRandom.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Victor Mono SemiBold", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(379, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "Resultado:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(830, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 51;
            this.button1.Text = "Pasos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(830, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 40);
            this.button2.TabIndex = 52;
            this.button2.Text = "Ejemplo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(830, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 40);
            this.button3.TabIndex = 53;
            this.button3.Text = "Ejemplo2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(830, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 40);
            this.button4.TabIndex = 54;
            this.button4.Text = "Ejemplo3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Victor Mono", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(830, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 40);
            this.button5.TabIndex = 55;
            this.button5.Text = "Random";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Victor Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView5.ColumnHeadersHeight = 40;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operandos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView5.Location = new System.Drawing.Point(12, 141);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView5.RowHeadersWidth = 80;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Victor Mono Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView5.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView5.Size = new System.Drawing.Size(225, 380);
            this.dataGridView5.TabIndex = 46;
            // 
            // Operandos
            // 
            this.Operandos.HeaderText = "Operandos";
            this.Operandos.Name = "Operandos";
            this.Operandos.ReadOnly = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(245, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(574, 334);
            this.richTextBox1.TabIndex = 56;
            this.richTextBox1.Text = "";
            // 
            // notacionPostfija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 536);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.txtColumnas);
            this.Name = "notacionPostfija";
            this.Text = "notacionPostfija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operandos;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}