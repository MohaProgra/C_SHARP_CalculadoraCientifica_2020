namespace CalculadoraCientifica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Retroceder = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplicación = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Cuadrado = new System.Windows.Forms.Button();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vISTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.aYUDAToolStripMenuItem,
            this.vISTAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(12, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.archivoToolStripMenuItem.Text = "ARCHIVO";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Retroceder
            // 
            this.Retroceder.BackColor = System.Drawing.Color.IndianRed;
            this.Retroceder.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Retroceder.FlatAppearance.BorderSize = 3;
            this.Retroceder.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Retroceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Retroceder.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retroceder.ForeColor = System.Drawing.Color.Black;
            this.Retroceder.Location = new System.Drawing.Point(12, 93);
            this.Retroceder.Name = "Retroceder";
            this.Retroceder.Size = new System.Drawing.Size(106, 50);
            this.Retroceder.TabIndex = 2;
            this.Retroceder.Text = "RETROCEDER";
            this.Retroceder.UseVisualStyleBackColor = false;
            this.Retroceder.Click += new System.EventHandler(this.Retroceso_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num7.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num7.FlatAppearance.BorderSize = 3;
            this.num7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num7.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(12, 149);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(50, 50);
            this.num7.TabIndex = 3;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num4.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num4.FlatAppearance.BorderSize = 3;
            this.num4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num4.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(12, 205);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(50, 50);
            this.num4.TabIndex = 4;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num1.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num1.FlatAppearance.BorderSize = 3;
            this.num1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(12, 261);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 50);
            this.num1.TabIndex = 5;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num2.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num2.FlatAppearance.BorderSize = 3;
            this.num2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num2.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(68, 261);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(50, 50);
            this.num2.TabIndex = 9;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num5.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num5.FlatAppearance.BorderSize = 3;
            this.num5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num5.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(68, 205);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(50, 50);
            this.num5.TabIndex = 8;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num8.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num8.FlatAppearance.BorderSize = 3;
            this.num8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num8.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(68, 149);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(50, 50);
            this.num8.TabIndex = 7;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.IndianRed;
            this.Borrar.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Borrar.FlatAppearance.BorderSize = 3;
            this.Borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Borrar.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.ForeColor = System.Drawing.Color.Black;
            this.Borrar.Location = new System.Drawing.Point(124, 93);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(50, 50);
            this.Borrar.TabIndex = 6;
            this.Borrar.Text = "CE";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num3.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num3.FlatAppearance.BorderSize = 3;
            this.num3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num3.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(124, 261);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(50, 50);
            this.num3.TabIndex = 13;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num6.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num6.FlatAppearance.BorderSize = 3;
            this.num6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num6.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(124, 205);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(50, 50);
            this.num6.TabIndex = 12;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num9.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num9.FlatAppearance.BorderSize = 3;
            this.num9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num9.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(124, 149);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(50, 50);
            this.num9.TabIndex = 11;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.Color.IndianRed;
            this.Suma.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Suma.FlatAppearance.BorderSize = 3;
            this.Suma.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Suma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Suma.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.ForeColor = System.Drawing.Color.Black;
            this.Suma.Location = new System.Drawing.Point(180, 205);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(50, 50);
            this.Suma.TabIndex = 17;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.BackColor = System.Drawing.Color.IndianRed;
            this.Resta.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Resta.FlatAppearance.BorderSize = 3;
            this.Resta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Resta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Resta.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.ForeColor = System.Drawing.Color.Black;
            this.Resta.Location = new System.Drawing.Point(233, 205);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(50, 50);
            this.Resta.TabIndex = 16;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = false;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.IndianRed;
            this.Division.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Division.FlatAppearance.BorderSize = 3;
            this.Division.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Division.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Division.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.ForeColor = System.Drawing.Color.Black;
            this.Division.Location = new System.Drawing.Point(180, 149);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(50, 50);
            this.Division.TabIndex = 15;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Multiplicación
            // 
            this.Multiplicación.BackColor = System.Drawing.Color.IndianRed;
            this.Multiplicación.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Multiplicación.FlatAppearance.BorderSize = 3;
            this.Multiplicación.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Multiplicación.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplicación.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicación.ForeColor = System.Drawing.Color.Black;
            this.Multiplicación.Location = new System.Drawing.Point(180, 93);
            this.Multiplicación.Name = "Multiplicación";
            this.Multiplicación.Size = new System.Drawing.Size(50, 50);
            this.Multiplicación.TabIndex = 14;
            this.Multiplicación.Text = "*";
            this.Multiplicación.UseVisualStyleBackColor = false;
            this.Multiplicación.Click += new System.EventHandler(this.Multiplicación_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.LightSteelBlue;
            this.num0.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.num0.FlatAppearance.BorderSize = 3;
            this.num0.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.num0.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(12, 317);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(106, 50);
            this.num0.TabIndex = 18;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Punto
            // 
            this.Punto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Punto.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Punto.FlatAppearance.BorderSize = 3;
            this.Punto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Punto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Punto.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punto.Location = new System.Drawing.Point(124, 317);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(50, 50);
            this.Punto.TabIndex = 19;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = false;
            // 
            // Igual
            // 
            this.Igual.BackColor = System.Drawing.Color.IndianRed;
            this.Igual.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Igual.FlatAppearance.BorderSize = 3;
            this.Igual.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Igual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Igual.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.ForeColor = System.Drawing.Color.Black;
            this.Igual.Location = new System.Drawing.Point(180, 261);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(103, 106);
            this.Igual.TabIndex = 20;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Raiz
            // 
            this.Raiz.BackColor = System.Drawing.Color.IndianRed;
            this.Raiz.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Raiz.FlatAppearance.BorderSize = 3;
            this.Raiz.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Raiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Raiz.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raiz.ForeColor = System.Drawing.Color.Black;
            this.Raiz.Location = new System.Drawing.Point(233, 149);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(50, 50);
            this.Raiz.TabIndex = 21;
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Cuadrado
            // 
            this.Cuadrado.BackColor = System.Drawing.Color.IndianRed;
            this.Cuadrado.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.Cuadrado.FlatAppearance.BorderSize = 3;
            this.Cuadrado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Cuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cuadrado.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuadrado.ForeColor = System.Drawing.Color.Black;
            this.Cuadrado.Location = new System.Drawing.Point(233, 93);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Size = new System.Drawing.Size(50, 50);
            this.Cuadrado.TabIndex = 22;
            this.Cuadrado.Text = "x^2";
            this.Cuadrado.UseVisualStyleBackColor = false;
            this.Cuadrado.Click += new System.EventHandler(this.Cuadrado_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenToolStripMenuItem});
            this.abrirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.abrirToolStripMenuItem.Text = "ABRIR";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aYUDAToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // imagenToolStripMenuItem
            // 
            this.imagenToolStripMenuItem.Name = "imagenToolStripMenuItem";
            this.imagenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagenToolStripMenuItem.Text = "Imagen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadoraCientifica.Properties.Resources.yedi;
            this.pictureBox1.Location = new System.Drawing.Point(292, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // vISTAToolStripMenuItem
            // 
            this.vISTAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vISTAToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.vISTAToolStripMenuItem.Name = "vISTAToolStripMenuItem";
            this.vISTAToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.vISTAToolStripMenuItem.Text = "VISTA";
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.Color.White;
            this.Pantalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pantalla.Enabled = false;
            this.Pantalla.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.ForeColor = System.Drawing.Color.Red;
            this.Pantalla.Location = new System.Drawing.Point(12, 37);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pantalla.Size = new System.Drawing.Size(271, 50);
            this.Pantalla.TabIndex = 1;
            this.Pantalla.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(499, 377);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cuadrado);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicación);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.Retroceder);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Científica";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button Retroceder;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplicación;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Cuadrado;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem vISTAToolStripMenuItem;
        private System.Windows.Forms.TextBox Pantalla;
    }
}

