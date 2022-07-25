
namespace QuarkCotizador
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.PantalonesRadioBtn = new System.Windows.Forms.RadioButton();
            this.camisaRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelUnidadStock = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioBtnPremium = new System.Windows.Forms.RadioButton();
            this.radioBtnStandard = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labelPrecioUnitario = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Cod_vendedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre_y_apellido = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DireccionTienda = new System.Windows.Forms.Label();
            this.nombre_tienda = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "COTIZADOR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCuelloMao);
            this.groupBox1.Controls.Add(this.checkBoxMangaCorta);
            this.groupBox1.Controls.Add(this.checkBoxChupin);
            this.groupBox1.Controls.Add(this.PantalonesRadioBtn);
            this.groupBox1.Controls.Add(this.camisaRadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prendas";
            // 
            // checkBoxCuelloMao
            // 
            this.checkBoxCuelloMao.AutoSize = true;
            this.checkBoxCuelloMao.Location = new System.Drawing.Point(330, 51);
            this.checkBoxCuelloMao.Name = "checkBoxCuelloMao";
            this.checkBoxCuelloMao.Size = new System.Drawing.Size(89, 17);
            this.checkBoxCuelloMao.TabIndex = 6;
            this.checkBoxCuelloMao.Text = "Cuello Mao";
            this.checkBoxCuelloMao.UseVisualStyleBackColor = true;
            this.checkBoxCuelloMao.CheckedChanged += new System.EventHandler(this.checkBoxCuelloMao_CheckedChanged);
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(220, 51);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(98, 17);
            this.checkBoxMangaCorta.TabIndex = 5;
            this.checkBoxMangaCorta.Text = "Manga Corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            this.checkBoxMangaCorta.CheckedChanged += new System.EventHandler(this.checkBoxMangaCorta_CheckedChanged);
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(220, 100);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(65, 17);
            this.checkBoxChupin.TabIndex = 4;
            this.checkBoxChupin.Text = "Chupin";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            this.checkBoxChupin.CheckedChanged += new System.EventHandler(this.checkBoxChupin_CheckedChanged);
            // 
            // PantalonesRadioBtn
            // 
            this.PantalonesRadioBtn.AutoSize = true;
            this.PantalonesRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PantalonesRadioBtn.Location = new System.Drawing.Point(42, 94);
            this.PantalonesRadioBtn.Name = "PantalonesRadioBtn";
            this.PantalonesRadioBtn.Size = new System.Drawing.Size(121, 28);
            this.PantalonesRadioBtn.TabIndex = 1;
            this.PantalonesRadioBtn.TabStop = true;
            this.PantalonesRadioBtn.Text = "Pantalones";
            this.PantalonesRadioBtn.UseVisualStyleBackColor = true;
            this.PantalonesRadioBtn.CheckedChanged += new System.EventHandler(this.PantalonesRadioBtn_CheckedChanged);
            // 
            // camisaRadioBtn
            // 
            this.camisaRadioBtn.AutoSize = true;
            this.camisaRadioBtn.Checked = true;
            this.camisaRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camisaRadioBtn.Location = new System.Drawing.Point(42, 45);
            this.camisaRadioBtn.Name = "camisaRadioBtn";
            this.camisaRadioBtn.Size = new System.Drawing.Size(88, 26);
            this.camisaRadioBtn.TabIndex = 0;
            this.camisaRadioBtn.TabStop = true;
            this.camisaRadioBtn.Text = "Camisa";
            this.camisaRadioBtn.UseVisualStyleBackColor = true;
            this.camisaRadioBtn.CheckedChanged += new System.EventHandler(this.camisaRadioBtn_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelUnidadStock);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(81, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 50);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // LabelUnidadStock
            // 
            this.LabelUnidadStock.AutoSize = true;
            this.LabelUnidadStock.Location = new System.Drawing.Point(342, 17);
            this.LabelUnidadStock.Name = "LabelUnidadStock";
            this.LabelUnidadStock.Size = new System.Drawing.Size(0, 13);
            this.LabelUnidadStock.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unidades de Stock Disponibles :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioBtnPremium);
            this.groupBox3.Controls.Add(this.radioBtnStandard);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(81, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 83);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calidad de Prenda";
            // 
            // radioBtnPremium
            // 
            this.radioBtnPremium.AutoSize = true;
            this.radioBtnPremium.Location = new System.Drawing.Point(64, 60);
            this.radioBtnPremium.Name = "radioBtnPremium";
            this.radioBtnPremium.Size = new System.Drawing.Size(72, 17);
            this.radioBtnPremium.TabIndex = 1;
            this.radioBtnPremium.TabStop = true;
            this.radioBtnPremium.Text = "Premium";
            this.radioBtnPremium.UseVisualStyleBackColor = true;
            this.radioBtnPremium.CheckedChanged += new System.EventHandler(this.radioBtnPremium_CheckedChanged);
            // 
            // radioBtnStandard
            // 
            this.radioBtnStandard.AutoSize = true;
            this.radioBtnStandard.Checked = true;
            this.radioBtnStandard.Location = new System.Drawing.Point(64, 36);
            this.radioBtnStandard.Name = "radioBtnStandard";
            this.radioBtnStandard.Size = new System.Drawing.Size(76, 17);
            this.radioBtnStandard.TabIndex = 0;
            this.radioBtnStandard.TabStop = true;
            this.radioBtnStandard.Text = "Standard";
            this.radioBtnStandard.UseVisualStyleBackColor = true;
            this.radioBtnStandard.CheckedChanged += new System.EventHandler(this.radioBtnStandard_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCantidad);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.labelPrecioUnitario);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(327, 415);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 83);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio Unitario y Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(143, 37);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(45, 20);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cantidad :";
            // 
            // labelPrecioUnitario
            // 
            this.labelPrecioUnitario.AutoSize = true;
            this.labelPrecioUnitario.Location = new System.Drawing.Point(22, 40);
            this.labelPrecioUnitario.Name = "labelPrecioUnitario";
            this.labelPrecioUnitario.Size = new System.Drawing.Size(14, 13);
            this.labelPrecioUnitario.TabIndex = 1;
            this.labelPrecioUnitario.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "$";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelTotal);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btnCotizar);
            this.panel3.Location = new System.Drawing.Point(0, 517);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 85);
            this.panel3.TabIndex = 6;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Blue;
            this.labelTotal.Location = new System.Drawing.Point(464, 33);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 22);
            this.labelTotal.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(399, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "$";
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCotizar.Location = new System.Drawing.Point(80, 19);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(200, 53);
            this.btnCotizar.TabIndex = 0;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Controls.Add(this.Cod_vendedor);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.nombre_y_apellido);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 150);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(586, 57);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vendedor";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(446, 26);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(111, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Historial Vendedor";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Cod_vendedor
            // 
            this.Cod_vendedor.AutoSize = true;
            this.Cod_vendedor.Location = new System.Drawing.Point(146, 26);
            this.Cod_vendedor.Name = "Cod_vendedor";
            this.Cod_vendedor.Size = new System.Drawing.Size(89, 13);
            this.Cod_vendedor.TabIndex = 3;
            this.Cod_vendedor.Text = "Cod_vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "|";
            // 
            // nombre_y_apellido
            // 
            this.nombre_y_apellido.AutoSize = true;
            this.nombre_y_apellido.Location = new System.Drawing.Point(16, 26);
            this.nombre_y_apellido.Name = "nombre_y_apellido";
            this.nombre_y_apellido.Size = new System.Drawing.Size(108, 13);
            this.nombre_y_apellido.TabIndex = 0;
            this.nombre_y_apellido.Text = "Nombre y apellido";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DireccionTienda);
            this.groupBox6.Controls.Add(this.nombre_tienda);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 102);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(586, 42);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            // 
            // DireccionTienda
            // 
            this.DireccionTienda.AutoSize = true;
            this.DireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTienda.Location = new System.Drawing.Point(373, 17);
            this.DireccionTienda.Name = "DireccionTienda";
            this.DireccionTienda.Size = new System.Drawing.Size(152, 15);
            this.DireccionTienda.TabIndex = 1;
            this.DireccionTienda.Text = "Direccion de la Tienda";
            // 
            // nombre_tienda
            // 
            this.nombre_tienda.AutoSize = true;
            this.nombre_tienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_tienda.Location = new System.Drawing.Point(5, 11);
            this.nombre_tienda.Name = "nombre_tienda";
            this.nombre_tienda.Size = new System.Drawing.Size(187, 22);
            this.nombre_tienda.TabIndex = 0;
            this.nombre_tienda.Text = "nombre de la tienda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recargarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // recargarToolStripMenuItem
            // 
            this.recargarToolStripMenuItem.Name = "recargarToolStripMenuItem";
            this.recargarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.recargarToolStripMenuItem.Text = "recargar";
            this.recargarToolStripMenuItem.Click += new System.EventHandler(this.recargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(610, 602);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuarkCotizador";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label Cod_vendedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nombre_y_apellido;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton PantalonesRadioBtn;
        private System.Windows.Forms.RadioButton camisaRadioBtn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label nombre_tienda;
        private System.Windows.Forms.Label DireccionTienda;
        private System.Windows.Forms.CheckBox checkBoxChupin;
        private System.Windows.Forms.CheckBox checkBoxCuelloMao;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.Label LabelUnidadStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioBtnPremium;
        private System.Windows.Forms.RadioButton radioBtnStandard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelPrecioUnitario;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

