namespace ConsultaBasedeDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.B_EJECUTE = new System.Windows.Forms.Button();
            this.CbBD = new System.Windows.Forms.ComboBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.PANEL_SHOW = new System.Windows.Forms.TextBox();
            this.B_RESET = new System.Windows.Forms.Button();
            this.B_RESTRICCION = new System.Windows.Forms.Button();
            this.B_PROYECCION = new System.Windows.Forms.Button();
            this.B_REUNION = new System.Windows.Forms.Button();
            this.Cbtabla = new System.Windows.Forms.ComboBox();
            this.Cbcolumna = new System.Windows.Forms.ComboBox();
            this.Escritura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bigual = new System.Windows.Forms.Button();
            this.Bmenor = new System.Windows.Forms.Button();
            this.Bmayor = new System.Windows.Forms.Button();
            this.Bmenorigual = new System.Windows.Forms.Button();
            this.Bmayorigual = new System.Windows.Forms.Button();
            this.Bdiferente = new System.Windows.Forms.Button();
            this.BOR = new System.Windows.Forms.Button();
            this.BAND = new System.Windows.Forms.Button();
            this.BNOT = new System.Windows.Forms.Button();
            this.BIS_NULL = new System.Windows.Forms.Button();
            this.B_IS_NOT_NULL = new System.Windows.Forms.Button();
            this.LOCKBUTTON = new System.Windows.Forms.CheckBox();
            this.text = new System.Windows.Forms.RadioButton();
            this.num = new System.Windows.Forms.RadioButton();
            this.buttonadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // B_EJECUTE
            // 
            this.B_EJECUTE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_EJECUTE.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.B_EJECUTE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.B_EJECUTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_EJECUTE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_EJECUTE.ForeColor = System.Drawing.Color.Olive;
            this.B_EJECUTE.Location = new System.Drawing.Point(510, 438);
            this.B_EJECUTE.Name = "B_EJECUTE";
            this.B_EJECUTE.Size = new System.Drawing.Size(75, 75);
            this.B_EJECUTE.TabIndex = 0;
            this.B_EJECUTE.Text = "Ejecutar";
            this.B_EJECUTE.UseVisualStyleBackColor = false;
            this.B_EJECUTE.Click += new System.EventHandler(this.EJECUTE);
            // 
            // CbBD
            // 
            this.CbBD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CbBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbBD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBD.ForeColor = System.Drawing.Color.Gray;
            this.CbBD.FormattingEnabled = true;
            this.CbBD.Location = new System.Drawing.Point(4, 254);
            this.CbBD.Name = "CbBD";
            this.CbBD.Size = new System.Drawing.Size(581, 23);
            this.CbBD.TabIndex = 1;
            this.CbBD.Text = "Elija la base de datos";
            this.CbBD.SelectionChangeCommitted += new System.EventHandler(this.NuevaBase);
            // 
            // GridView
            // 
            this.GridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.GridColor = System.Drawing.Color.White;
            this.GridView.Location = new System.Drawing.Point(4, 4);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(581, 147);
            this.GridView.TabIndex = 3;
            // 
            // PANEL_SHOW
            // 
            this.PANEL_SHOW.BackColor = System.Drawing.Color.White;
            this.PANEL_SHOW.Enabled = false;
            this.PANEL_SHOW.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PANEL_SHOW.Location = new System.Drawing.Point(4, 438);
            this.PANEL_SHOW.Multiline = true;
            this.PANEL_SHOW.Name = "PANEL_SHOW";
            this.PANEL_SHOW.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PANEL_SHOW.Size = new System.Drawing.Size(501, 155);
            this.PANEL_SHOW.TabIndex = 4;
            this.PANEL_SHOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B_RESET
            // 
            this.B_RESET.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_RESET.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.B_RESET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.B_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_RESET.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_RESET.ForeColor = System.Drawing.Color.Maroon;
            this.B_RESET.Location = new System.Drawing.Point(510, 518);
            this.B_RESET.Name = "B_RESET";
            this.B_RESET.Size = new System.Drawing.Size(75, 75);
            this.B_RESET.TabIndex = 5;
            this.B_RESET.Text = "Reset";
            this.B_RESET.UseVisualStyleBackColor = false;
            this.B_RESET.Click += new System.EventHandler(this.RESET);
            // 
            // B_RESTRICCION
            // 
            this.B_RESTRICCION.BackColor = System.Drawing.Color.White;
            this.B_RESTRICCION.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.B_RESTRICCION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_RESTRICCION.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_RESTRICCION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.B_RESTRICCION.Location = new System.Drawing.Point(4, 194);
            this.B_RESTRICCION.Name = "B_RESTRICCION";
            this.B_RESTRICCION.Size = new System.Drawing.Size(190, 30);
            this.B_RESTRICCION.TabIndex = 6;
            this.B_RESTRICCION.Text = "RESTRICCION";
            this.B_RESTRICCION.UseVisualStyleBackColor = false;
            this.B_RESTRICCION.Click += new System.EventHandler(this.GO_RESTRICCION);
            // 
            // B_PROYECCION
            // 
            this.B_PROYECCION.BackColor = System.Drawing.Color.White;
            this.B_PROYECCION.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.B_PROYECCION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_PROYECCION.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_PROYECCION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.B_PROYECCION.Location = new System.Drawing.Point(199, 194);
            this.B_PROYECCION.Name = "B_PROYECCION";
            this.B_PROYECCION.Size = new System.Drawing.Size(190, 30);
            this.B_PROYECCION.TabIndex = 7;
            this.B_PROYECCION.Text = "PROYECCION";
            this.B_PROYECCION.UseMnemonic = false;
            this.B_PROYECCION.UseVisualStyleBackColor = false;
            this.B_PROYECCION.Click += new System.EventHandler(this.GO_PROYECTAR);
            // 
            // B_REUNION
            // 
            this.B_REUNION.BackColor = System.Drawing.Color.White;
            this.B_REUNION.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.B_REUNION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_REUNION.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_REUNION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.B_REUNION.Location = new System.Drawing.Point(395, 194);
            this.B_REUNION.Name = "B_REUNION";
            this.B_REUNION.Size = new System.Drawing.Size(190, 30);
            this.B_REUNION.TabIndex = 8;
            this.B_REUNION.Text = "REUNION";
            this.B_REUNION.UseVisualStyleBackColor = false;
            this.B_REUNION.Click += new System.EventHandler(this.GO_REUNIR);
            // 
            // Cbtabla
            // 
            this.Cbtabla.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cbtabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbtabla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbtabla.ForeColor = System.Drawing.Color.Gray;
            this.Cbtabla.FormattingEnabled = true;
            this.Cbtabla.Location = new System.Drawing.Point(4, 283);
            this.Cbtabla.Name = "Cbtabla";
            this.Cbtabla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Cbtabla.Size = new System.Drawing.Size(288, 23);
            this.Cbtabla.TabIndex = 11;
            this.Cbtabla.Text = "Tabla";
            this.Cbtabla.SelectionChangeCommitted += new System.EventHandler(this.Nuevatabla);
            // 
            // Cbcolumna
            // 
            this.Cbcolumna.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cbcolumna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbcolumna.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbcolumna.ForeColor = System.Drawing.Color.Gray;
            this.Cbcolumna.FormattingEnabled = true;
            this.Cbcolumna.Location = new System.Drawing.Point(297, 283);
            this.Cbcolumna.Name = "Cbcolumna";
            this.Cbcolumna.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cbcolumna.Size = new System.Drawing.Size(288, 23);
            this.Cbcolumna.TabIndex = 12;
            this.Cbcolumna.Text = "Columna";
            this.Cbcolumna.SelectionChangeCommitted += new System.EventHandler(this.Nuevacolumna);
            // 
            // Escritura
            // 
            this.Escritura.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escritura.Location = new System.Drawing.Point(4, 386);
            this.Escritura.Name = "Escritura";
            this.Escritura.Size = new System.Drawing.Size(234, 23);
            this.Escritura.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(192, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Paso 1: Elija la operacion.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(172, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Paso 2: Elija la Tabla/Columna.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(169, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Paso 3: Ingrese las condiciones.";
            // 
            // Bigual
            // 
            this.Bigual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bigual.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Bigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Bigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bigual.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bigual.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Bigual.Location = new System.Drawing.Point(4, 346);
            this.Bigual.Name = "Bigual";
            this.Bigual.Size = new System.Drawing.Size(34, 34);
            this.Bigual.TabIndex = 17;
            this.Bigual.Text = "=";
            this.Bigual.UseVisualStyleBackColor = false;
            this.Bigual.Click += new System.EventHandler(this.opigual);
            // 
            // Bmenor
            // 
            this.Bmenor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bmenor.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Bmenor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Bmenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bmenor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmenor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Bmenor.Location = new System.Drawing.Point(44, 346);
            this.Bmenor.Name = "Bmenor";
            this.Bmenor.Size = new System.Drawing.Size(34, 34);
            this.Bmenor.TabIndex = 18;
            this.Bmenor.Text = "<";
            this.Bmenor.UseVisualStyleBackColor = false;
            this.Bmenor.Click += new System.EventHandler(this.opimenor);
            // 
            // Bmayor
            // 
            this.Bmayor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bmayor.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Bmayor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Bmayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bmayor.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmayor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Bmayor.Location = new System.Drawing.Point(84, 346);
            this.Bmayor.Name = "Bmayor";
            this.Bmayor.Size = new System.Drawing.Size(34, 34);
            this.Bmayor.TabIndex = 19;
            this.Bmayor.Text = ">";
            this.Bmayor.UseVisualStyleBackColor = false;
            this.Bmayor.Click += new System.EventHandler(this.opimayor);
            // 
            // Bmenorigual
            // 
            this.Bmenorigual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bmenorigual.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Bmenorigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Bmenorigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bmenorigual.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmenorigual.ForeColor = System.Drawing.Color.SlateBlue;
            this.Bmenorigual.Location = new System.Drawing.Point(124, 346);
            this.Bmenorigual.Name = "Bmenorigual";
            this.Bmenorigual.Size = new System.Drawing.Size(34, 34);
            this.Bmenorigual.TabIndex = 20;
            this.Bmenorigual.Text = "<=";
            this.Bmenorigual.UseVisualStyleBackColor = false;
            this.Bmenorigual.Click += new System.EventHandler(this.opimenorigual);
            // 
            // Bmayorigual
            // 
            this.Bmayorigual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bmayorigual.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Bmayorigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Bmayorigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bmayorigual.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmayorigual.ForeColor = System.Drawing.Color.BlueViolet;
            this.Bmayorigual.Location = new System.Drawing.Point(164, 346);
            this.Bmayorigual.Name = "Bmayorigual";
            this.Bmayorigual.Size = new System.Drawing.Size(34, 34);
            this.Bmayorigual.TabIndex = 21;
            this.Bmayorigual.Text = ">=";
            this.Bmayorigual.UseVisualStyleBackColor = false;
            this.Bmayorigual.Click += new System.EventHandler(this.opimayorigual);
            // 
            // Bdiferente
            // 
            this.Bdiferente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bdiferente.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.Bdiferente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.Bdiferente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bdiferente.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdiferente.ForeColor = System.Drawing.Color.DarkViolet;
            this.Bdiferente.Location = new System.Drawing.Point(204, 346);
            this.Bdiferente.Name = "Bdiferente";
            this.Bdiferente.Size = new System.Drawing.Size(34, 34);
            this.Bdiferente.TabIndex = 22;
            this.Bdiferente.Text = "<>";
            this.Bdiferente.UseVisualStyleBackColor = false;
            this.Bdiferente.Click += new System.EventHandler(this.opidife);
            // 
            // BOR
            // 
            this.BOR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BOR.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BOR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOR.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOR.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.BOR.Location = new System.Drawing.Point(477, 346);
            this.BOR.Name = "BOR";
            this.BOR.Size = new System.Drawing.Size(51, 34);
            this.BOR.TabIndex = 23;
            this.BOR.Text = "OR";
            this.BOR.UseVisualStyleBackColor = false;
            this.BOR.Click += new System.EventHandler(this.opior);
            // 
            // BAND
            // 
            this.BAND.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BAND.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BAND.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BAND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAND.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAND.ForeColor = System.Drawing.Color.IndianRed;
            this.BAND.Location = new System.Drawing.Point(534, 346);
            this.BAND.Name = "BAND";
            this.BAND.Size = new System.Drawing.Size(51, 34);
            this.BAND.TabIndex = 24;
            this.BAND.Text = "AND";
            this.BAND.UseVisualStyleBackColor = false;
            this.BAND.Click += new System.EventHandler(this.opiand);
            // 
            // BNOT
            // 
            this.BNOT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BNOT.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BNOT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BNOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNOT.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNOT.ForeColor = System.Drawing.Color.HotPink;
            this.BNOT.Location = new System.Drawing.Point(420, 346);
            this.BNOT.Name = "BNOT";
            this.BNOT.Size = new System.Drawing.Size(51, 34);
            this.BNOT.TabIndex = 25;
            this.BNOT.Text = "NOT";
            this.BNOT.UseVisualStyleBackColor = false;
            this.BNOT.Click += new System.EventHandler(this.opinot);
            // 
            // BIS_NULL
            // 
            this.BIS_NULL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BIS_NULL.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BIS_NULL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BIS_NULL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIS_NULL.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIS_NULL.ForeColor = System.Drawing.Color.MediumOrchid;
            this.BIS_NULL.Location = new System.Drawing.Point(332, 346);
            this.BIS_NULL.Name = "BIS_NULL";
            this.BIS_NULL.Size = new System.Drawing.Size(82, 34);
            this.BIS_NULL.TabIndex = 26;
            this.BIS_NULL.Text = "IS NULL";
            this.BIS_NULL.UseVisualStyleBackColor = false;
            this.BIS_NULL.Click += new System.EventHandler(this.opisnull);
            // 
            // B_IS_NOT_NULL
            // 
            this.B_IS_NOT_NULL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.B_IS_NOT_NULL.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.B_IS_NOT_NULL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.B_IS_NOT_NULL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_IS_NOT_NULL.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_IS_NOT_NULL.ForeColor = System.Drawing.Color.Purple;
            this.B_IS_NOT_NULL.Location = new System.Drawing.Point(244, 346);
            this.B_IS_NOT_NULL.Name = "B_IS_NOT_NULL";
            this.B_IS_NOT_NULL.Size = new System.Drawing.Size(82, 34);
            this.B_IS_NOT_NULL.TabIndex = 27;
            this.B_IS_NOT_NULL.Text = "NOT NULL";
            this.B_IS_NOT_NULL.UseVisualStyleBackColor = false;
            this.B_IS_NOT_NULL.Click += new System.EventHandler(this.opisnotnull);
            // 
            // LOCKBUTTON
            // 
            this.LOCKBUTTON.AutoSize = true;
            this.LOCKBUTTON.Checked = true;
            this.LOCKBUTTON.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LOCKBUTTON.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LOCKBUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOCKBUTTON.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOCKBUTTON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LOCKBUTTON.Location = new System.Drawing.Point(4, 419);
            this.LOCKBUTTON.Name = "LOCKBUTTON";
            this.LOCKBUTTON.Size = new System.Drawing.Size(92, 19);
            this.LOCKBUTTON.TabIndex = 28;
            this.LOCKBUTTON.Text = "Modo seguro";
            this.LOCKBUTTON.UseVisualStyleBackColor = true;
            this.LOCKBUTTON.CheckedChanged += new System.EventHandler(this.LOCKING);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text.Location = new System.Drawing.Point(378, 388);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(93, 17);
            this.text.TabIndex = 29;
            this.text.Text = "Ingrese Texto";
            this.text.UseVisualStyleBackColor = true;
            // 
            // num
            // 
            this.num.AutoSize = true;
            this.num.Checked = true;
            this.num.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.num.Location = new System.Drawing.Point(244, 388);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(124, 17);
            this.num.TabIndex = 30;
            this.num.TabStop = true;
            this.num.Text = "Ingrese un Numero";
            this.num.UseVisualStyleBackColor = true;
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.White;
            this.buttonadd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonadd.Location = new System.Drawing.Point(477, 386);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(108, 23);
            this.buttonadd.TabIndex = 32;
            this.buttonadd.Text = "Agregar";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.Addingmanualdata);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(589, 597);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.num);
            this.Controls.Add(this.text);
            this.Controls.Add(this.LOCKBUTTON);
            this.Controls.Add(this.B_IS_NOT_NULL);
            this.Controls.Add(this.BIS_NULL);
            this.Controls.Add(this.BNOT);
            this.Controls.Add(this.BAND);
            this.Controls.Add(this.BOR);
            this.Controls.Add(this.Bdiferente);
            this.Controls.Add(this.Bmayorigual);
            this.Controls.Add(this.Bmenorigual);
            this.Controls.Add(this.Bmayor);
            this.Controls.Add(this.Bmenor);
            this.Controls.Add(this.Bigual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Escritura);
            this.Controls.Add(this.Cbcolumna);
            this.Controls.Add(this.Cbtabla);
            this.Controls.Add(this.B_REUNION);
            this.Controls.Add(this.B_PROYECCION);
            this.Controls.Add(this.B_RESTRICCION);
            this.Controls.Add(this.B_RESET);
            this.Controls.Add(this.PANEL_SHOW);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.CbBD);
            this.Controls.Add(this.B_EJECUTE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(605, 635);
            this.Name = "Form1";
            this.Text = "Consultor";
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_EJECUTE;
        private System.Windows.Forms.ComboBox CbBD;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox PANEL_SHOW;
        private System.Windows.Forms.Button B_RESET;
        private System.Windows.Forms.Button B_RESTRICCION;
        private System.Windows.Forms.Button B_PROYECCION;
        private System.Windows.Forms.Button B_REUNION;
        private System.Windows.Forms.ComboBox Cbtabla;
        private System.Windows.Forms.ComboBox Cbcolumna;
        private System.Windows.Forms.TextBox Escritura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bigual;
        private System.Windows.Forms.Button Bmenor;
        private System.Windows.Forms.Button Bmayor;
        private System.Windows.Forms.Button Bmenorigual;
        private System.Windows.Forms.Button Bmayorigual;
        private System.Windows.Forms.Button Bdiferente;
        private System.Windows.Forms.Button BOR;
        private System.Windows.Forms.Button BAND;
        private System.Windows.Forms.Button BNOT;
        private System.Windows.Forms.Button BIS_NULL;
        private System.Windows.Forms.Button B_IS_NOT_NULL;
        private System.Windows.Forms.CheckBox LOCKBUTTON;
        private System.Windows.Forms.RadioButton text;
        private System.Windows.Forms.RadioButton num;
        private System.Windows.Forms.Button buttonadd;
    }
}

