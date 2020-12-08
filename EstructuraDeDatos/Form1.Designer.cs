namespace EstructuraDeDatos
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.unidadConceptosBásicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad2ArreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triangularYDeterminanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidad4PilasYColasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.estructuraAbstracta7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizInversaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizTranspuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieDeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Imagen1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pilaGenericaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torresDeHanoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notacionPostfijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unidadConceptosBásicosToolStripMenuItem,
            this.unidad2ArreglosToolStripMenuItem,
            this.unidad4PilasYColasToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(841, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // unidadConceptosBásicosToolStripMenuItem
            // 
            this.unidadConceptosBásicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructuraAbstracta7ToolStripMenuItem,
            this.tiposDeDatosToolStripMenuItem,
            this.serieDeFibonacciToolStripMenuItem});
            this.unidadConceptosBásicosToolStripMenuItem.Name = "unidadConceptosBásicosToolStripMenuItem";
            this.unidadConceptosBásicosToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.unidadConceptosBásicosToolStripMenuItem.Text = "Unidad 1: Conceptos básicos";
            // 
            // unidad2ArreglosToolStripMenuItem
            // 
            this.unidad2ArreglosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.triangularYDeterminanteToolStripMenuItem,
            this.matrizToolStripMenuItem,
            this.matrizInversaToolStripMenuItem,
            this.matrizTranspuestaToolStripMenuItem,
            this.memoramaToolStripMenuItem});
            this.unidad2ArreglosToolStripMenuItem.Name = "unidad2ArreglosToolStripMenuItem";
            this.unidad2ArreglosToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.unidad2ArreglosToolStripMenuItem.Text = "Unidad 2: Arreglos";
            // 
            // triangularYDeterminanteToolStripMenuItem
            // 
            this.triangularYDeterminanteToolStripMenuItem.Name = "triangularYDeterminanteToolStripMenuItem";
            this.triangularYDeterminanteToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.triangularYDeterminanteToolStripMenuItem.Text = "Triangular y Determinante";
            this.triangularYDeterminanteToolStripMenuItem.Click += new System.EventHandler(this.triangularYDeterminanteToolStripMenuItem_Click);
            // 
            // unidad4PilasYColasToolStripMenuItem
            // 
            this.unidad4PilasYColasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilaGenericaToolStripMenuItem,
            this.torresDeHanoiToolStripMenuItem,
            this.notacionPostfijaToolStripMenuItem});
            this.unidad4PilasYColasToolStripMenuItem.Name = "unidad4PilasYColasToolStripMenuItem";
            this.unidad4PilasYColasToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.unidad4PilasYColasToolStripMenuItem.Text = "Unidad 4: Pilas";
            this.unidad4PilasYColasToolStripMenuItem.Click += new System.EventHandler(this.unidad4PilasYColasToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Competencias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Victor Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Objetivo De Aprendizaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Victor Mono", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(57, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 80);
            this.label3.TabIndex = 4;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Victor Mono", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(57, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 64);
            this.label4.TabIndex = 5;
            this.label4.Text = "El alumno empleará estructuras de datos abstractas \r\nen el desarrollo de aplicaci" +
    "ones multiplataforma \r\nusando el paradigma orientado a objetos para \r\nagilizar e" +
    "l acceso a los datos.";
            // 
            // estructuraAbstracta7ToolStripMenuItem
            // 
            this.estructuraAbstracta7ToolStripMenuItem.Name = "estructuraAbstracta7ToolStripMenuItem";
            this.estructuraAbstracta7ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.estructuraAbstracta7ToolStripMenuItem.Text = "Estructura Abstracta7";
            this.estructuraAbstracta7ToolStripMenuItem.Click += new System.EventHandler(this.estructuraAbstracta7ToolStripMenuItem_Click);
            // 
            // tiposDeDatosToolStripMenuItem
            // 
            this.tiposDeDatosToolStripMenuItem.Name = "tiposDeDatosToolStripMenuItem";
            this.tiposDeDatosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.tiposDeDatosToolStripMenuItem.Text = "Tipos de datos";
            this.tiposDeDatosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeDatosToolStripMenuItem_Click);
            // 
            // matrizToolStripMenuItem
            // 
            this.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem";
            this.matrizToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.matrizToolStripMenuItem.Text = "Matriz";
            this.matrizToolStripMenuItem.Click += new System.EventHandler(this.matrizToolStripMenuItem_Click);
            // 
            // matrizInversaToolStripMenuItem
            // 
            this.matrizInversaToolStripMenuItem.Name = "matrizInversaToolStripMenuItem";
            this.matrizInversaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.matrizInversaToolStripMenuItem.Text = "Matriz Inversa";
            this.matrizInversaToolStripMenuItem.Click += new System.EventHandler(this.matrizInversaToolStripMenuItem_Click);
            // 
            // matrizTranspuestaToolStripMenuItem
            // 
            this.matrizTranspuestaToolStripMenuItem.Name = "matrizTranspuestaToolStripMenuItem";
            this.matrizTranspuestaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.matrizTranspuestaToolStripMenuItem.Text = "Matriz Transpuesta";
            this.matrizTranspuestaToolStripMenuItem.Click += new System.EventHandler(this.matrizTranspuestaToolStripMenuItem_Click);
            // 
            // memoramaToolStripMenuItem
            // 
            this.memoramaToolStripMenuItem.Name = "memoramaToolStripMenuItem";
            this.memoramaToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.memoramaToolStripMenuItem.Text = "Memorama";
            this.memoramaToolStripMenuItem.Click += new System.EventHandler(this.memoramaToolStripMenuItem_Click);
            // 
            // serieDeFibonacciToolStripMenuItem
            // 
            this.serieDeFibonacciToolStripMenuItem.Name = "serieDeFibonacciToolStripMenuItem";
            this.serieDeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.serieDeFibonacciToolStripMenuItem.Text = "Serie de Fibonacci";
            this.serieDeFibonacciToolStripMenuItem.Click += new System.EventHandler(this.serieDeFibonacciToolStripMenuItem_Click);
            // 
            // Imagen1
            // 
            this.Imagen1.Image = global::EstructuraDeDatos.Properties.Resources._1_Ut55XNszCQPxCG9qaEQfAw;
            this.Imagen1.Location = new System.Drawing.Point(449, 125);
            this.Imagen1.Name = "Imagen1";
            this.Imagen1.Size = new System.Drawing.Size(391, 300);
            this.Imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imagen1.TabIndex = 7;
            this.Imagen1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EstructuraDeDatos.Properties.Resources._14;
            this.pictureBox1.Location = new System.Drawing.Point(-586, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 343);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pilaGenericaToolStripMenuItem
            // 
            this.pilaGenericaToolStripMenuItem.Name = "pilaGenericaToolStripMenuItem";
            this.pilaGenericaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilaGenericaToolStripMenuItem.Text = "Pila Generica";
            this.pilaGenericaToolStripMenuItem.Click += new System.EventHandler(this.pilaGenericaToolStripMenuItem_Click);
            // 
            // torresDeHanoiToolStripMenuItem
            // 
            this.torresDeHanoiToolStripMenuItem.Name = "torresDeHanoiToolStripMenuItem";
            this.torresDeHanoiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.torresDeHanoiToolStripMenuItem.Text = "Torres de Hanoi";
            this.torresDeHanoiToolStripMenuItem.Click += new System.EventHandler(this.torresDeHanoiToolStripMenuItem_Click);
            // 
            // notacionPostfijaToolStripMenuItem
            // 
            this.notacionPostfijaToolStripMenuItem.Name = "notacionPostfijaToolStripMenuItem";
            this.notacionPostfijaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notacionPostfijaToolStripMenuItem.Text = "Notacion Postfija";
            this.notacionPostfijaToolStripMenuItem.Click += new System.EventHandler(this.notacionPostfijaToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(841, 537);
            this.Controls.Add(this.Imagen1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura De Datos Aplicada";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem unidadConceptosBásicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad2ArreglosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidad4PilasYColasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Imagen1;
        private System.Windows.Forms.ToolStripMenuItem triangularYDeterminanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraAbstracta7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizInversaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizTranspuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieDeFibonacciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaGenericaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torresDeHanoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notacionPostfijaToolStripMenuItem;
    }
}

