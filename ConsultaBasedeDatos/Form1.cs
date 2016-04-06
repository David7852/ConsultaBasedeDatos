using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//David Gomez 20359596 y Brian Johnson 19496477
namespace ConsultaBasedeDatos
{
    public partial class Form1 : Form
    {
        //Variables
        private String cadenaConexion="Data Source=" +"USUARIO-PC\\SQLEXPRESS" /*global.nombremaestro*/+ "; Integrated Security=true; Initial Catalog=master";
        private String auxconsulta,auxshowing, showing, consultacorrecta,select1,select2;
        private int atonaux=0,atonshowing=0,atonconsulta=0;
        private bool w;
        private char paso1,paso2,paso3,tipo;
        private int t,ok,auxstate;

        //metodos anti error de nombre
        private void Transformintoform2(String message)
        {
            B_EJECUTE.Hide();
            CbBD.Hide();
            GridView.Hide();
            B_RESET.Hide();
            B_RESTRICCION.Hide();
            B_REUNION.Hide();
            Cbtabla.Hide();
            Cbcolumna.Hide();
            label2.Hide();
            label3.Hide();
            Bigual.Hide();
            Bmenor.Hide();
            Bmayor.Hide();
            Bmenorigual.Hide();
            Bmayorigual.Hide();
            Bdiferente.Hide();
            BOR.Hide();
            BAND.Hide();
            BNOT.Hide();
            BIS_NULL.Hide();
            B_IS_NOT_NULL.Hide();
            LOCKBUTTON.Hide();
            text.Hide();
            num.Hide();
            buttonadd.Hide();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre de la base de datos maestra";
            // 
            // B_PROYECCION
            // 
            this.B_PROYECCION.BackColor = System.Drawing.Color.White;
            this.B_PROYECCION.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.B_PROYECCION.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.B_PROYECCION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_PROYECCION.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_PROYECCION.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.B_PROYECCION.Location = new System.Drawing.Point(12, 263);
            this.B_PROYECCION.Size = new System.Drawing.Size(300, 30);
            this.B_PROYECCION.TabIndex = 8;
            this.B_PROYECCION.Text = "Listo!";
            this.B_PROYECCION.UseMnemonic = false;
            this.B_PROYECCION.UseVisualStyleBackColor = false;
            this.B_PROYECCION.Click += new System.EventHandler(this.reintentar);
            // 
            // textbox
            // 
            this.Escritura.BackColor = System.Drawing.Color.White;
            this.Escritura.Location = new System.Drawing.Point(12, 237);
            this.Escritura.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Escritura.Size = new System.Drawing.Size(300, 20);
            this.Escritura.TabIndex = 9;
            // 
            // textBox1
            // 
            this.PANEL_SHOW.Enabled = false;
            this.PANEL_SHOW.Location = new System.Drawing.Point(0, 0);
            this.PANEL_SHOW.Multiline = true;
            this.PANEL_SHOW.Size = new System.Drawing.Size(326, 194);
            this.PANEL_SHOW.TabIndex = 10;
            this.PANEL_SHOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PANEL_SHOW.Text = "Tenemos el siguiente problema: " + message;
            // 
            //       

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(325, 303);
            this.Controls.Add(this.B_PROYECCION);
            this.Controls.Add(this.label1);
            this.ShowIcon = false;
            this.Text = "Vamos a intentar correguir esto...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void reintentar(object sender, EventArgs e)
        {
            if (w&&!Escritura.Text.Equals(""))
            {
                global.nombremaestro = Escritura.Text;
                cadenaConexion = "Data Source=" + global.nombremaestro + "; Integrated Security=true; Initial Catalog=master";
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
                this.ShowIcon = true;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.MaximumSize = new System.Drawing.Size(605, 635);
                this.Name = "Form1";
                this.Text = "Consultor";
                ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

                B_EJECUTE.Show();
                CbBD.Show();
                GridView.Show();
                PANEL_SHOW.Show();
                B_RESET.Show();
                B_RESTRICCION.Show();
                B_PROYECCION.Show();
                B_REUNION.Show();
                Cbtabla.Show();
                Cbcolumna.Show();
                Escritura.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                Bigual.Show();
                Bmenor.Show();
                Bmayor.Show();
                Bmenorigual.Show();
                Bmayorigual.Show();
                Bdiferente.Show();
                BOR.Show();
                BAND.Show();
                BNOT.Show();
                BIS_NULL.Show();
                B_IS_NOT_NULL.Show();
                LOCKBUTTON.Show();
                text.Show();
                num.Show();
                buttonadd.Show();

                
                Conectar();
            }
        }
        private bool verificarComillasSimples(String cadena)
        {

            for (int i = 0; i<cadena.Length; i++)
            {
                if (cadena[i] == '\'')
                    return false;
            }
            return true;
        }

        //constructor
        public Form1()
        {
            t = -1; 
            ok = 0;
            auxstate = 0;
            auxconsulta = "";
            auxshowing = "";
            showing = ""; 
            consultacorrecta = "";
            paso1=' ';//si tiene un valor de I significa que esta iniciado pero no terminado y es el paso actual, F significa que se paso al siguiente paso. vacio no iniciado
            paso2 = ' ';
            paso3 = ' ';
            tipo = ' ';//tipo es un identificador para saber el tipo de operacion rellenando
            w = false;
            InitializeComponent();
            Conectar();
        }

        //probar la conexion principal.
        public void Conectar()
        {            
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            
            try
            {
                conexion.Open();
                String consulta = "Select name From Sysdatabases";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "master");
                CbBD.DataSource = ds;
                CbBD.DisplayMember = "master.name";
                CbBD.ValueMember = "master.name";
                CbBD.SelectedIndex = -1;
                CbBD.Text = "Elija la base de datos";
                restart();
            }
            catch (Exception EX)
            {
                w = true;
                Transformintoform2(EX.Message);
            }
        }

        public void enviar(String consulta, String cadenaConexion)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("USE " + CbBD.SelectedValue.ToString() + " " + consultacorrecta, conexion);
                //cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                da.Fill(ds, Cbtabla.SelectedValue.ToString());
                GridView.DataSource = ds.Tables[Cbtabla.SelectedValue.ToString()].DefaultView;
                conexion.Close();
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void EJECUTE(object sender, EventArgs e)
        {
            //try{
            //aca agarra la cadena y la manda a consultar
            if (!LOCKBUTTON.Checked)
                consultacorrecta = PANEL_SHOW.Text;


             enviar(consultacorrecta, cadenaConexion);


            //}catch()


            //ahora se limpia todo menos el datagrid, que solo le limpia por reset.
            B_RESET.Enabled = true;
            B_RESTRICCION.Enabled = false;
            B_PROYECCION.Enabled = false;
            B_REUNION.Enabled = false;
            Cbtabla.Enabled = false;
            Cbcolumna.Enabled = false;
            Escritura.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            Bigual.Enabled = false;
            Bmenor.Enabled = false;
            Bmayor.Enabled = false;
            Bmenorigual.Enabled = false;
            Bmayorigual.Enabled = false;
            Bdiferente.Enabled = false;
            BOR.Enabled = false;
            BAND.Enabled = false;
            BNOT.Enabled = false;
            BIS_NULL.Enabled = false;
            B_IS_NOT_NULL.Enabled = false;
            //LOCKBUTTON.Enabled = false;
            text.Enabled = false;
            num.Enabled = false;
            buttonadd.Enabled = false;
            t = -1;
            ok = 0;
            auxstate = 0;
            auxconsulta = "";
            auxshowing = "";
            showing = "";
            consultacorrecta = "";
            paso1 = 'I';
            paso2 = ' ';
            paso3 = ' ';
            w = false;
            atonaux = 0;
            atonshowing = 0;
            atonconsulta = 0;
            if (t != ok)
                B_EJECUTE.Enabled = false;
            else
                B_EJECUTE.Enabled = true;
        }

        //Reseteo
        public void restart()
        {
            PANEL_SHOW.ResetText();
            CbBD.Enabled = false;
            //limpiar el GridView.
            GridView.DataSource = null;
            B_RESET.Enabled = true;
            B_RESTRICCION.Enabled = true;
            B_PROYECCION.Enabled = true;
            B_REUNION.Enabled = true;
            Cbtabla.Enabled = false;
            Cbcolumna.Enabled = false;
            Escritura.ResetText();
            Escritura.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            Bigual.Enabled = false;
            Bmenor.Enabled = false;
            Bmayor.Enabled = false;
            Bmenorigual.Enabled = false;
            Bmayorigual.Enabled = false;
            Bdiferente.Enabled = false;
            BOR.Enabled = false;
            BAND.Enabled = false;
            BNOT.Enabled = false;
            BIS_NULL.Enabled = false;
            B_IS_NOT_NULL.Enabled = false;
            text.Enabled = false;
            num.Enabled = false;
            buttonadd.Enabled = false;
            t = -1;
            ok = 0;
            auxstate = 0;
            auxconsulta = "";
            auxshowing = "";
            showing = "";
            consultacorrecta = "";
            paso1 = 'I';
            paso2 = ' ';
            paso3 = ' ';
            select1 = "";
            select2 = "";
            w = false;
            atonaux = 0; 
            atonshowing = 0; 
            atonconsulta = 0;
            if(t!=ok)
                B_EJECUTE.Enabled = false;
            else
                B_EJECUTE.Enabled = true ;
        }

        private void RESET(object sender, EventArgs e)
        {
            restart();
        }
        
        private void GO_RESTRICCION(object sender, EventArgs e)
        {
            if (paso1 == 'I')
            {
                ok += 2;
                t++;
                auxstate = 0;
                tipo = 'R';

                if (atonshowing < showing.Length)
                    showing = showing.Insert(atonshowing, "RES()");
                else
                    showing = "RES()";

                atonshowing += 4;
                consultacorrecta = "SELECT * FROM ";
                atonconsulta = consultacorrecta.Length;
                paso1 = 'F';
                
                B_REUNION.Enabled = false;
                B_RESTRICCION.Enabled = false;
                CbBD.Enabled = true;
                Cbtabla.Enabled = true;
                label2.Enabled = true;
                PANEL_SHOW.Text = showing;
                paso2 = 'I';
            }
            else
            {
                B_RESTRICCION.Enabled = false;
                B_REUNION.Enabled = false;
                CbBD.Enabled = true;
                Cbtabla.Enabled = true;
                ok += 2;//
                t++;
                auxstate = 0;
                tipo = 'R';
                showing = showing+ " RES(lo anterior por)[]";
                atonshowing = showing.Length-1;
                consultacorrecta = consultacorrecta + " WHERE ";
                atonconsulta = consultacorrecta.Length;
                paso1 = 'F';
                paso2 = 'F';
                paso3 = 'I';
                CbBD.Enabled = false;
                Cbtabla.Enabled = true;
                Cbcolumna.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                PANEL_SHOW.Text = showing;
            }
        }

        private void GO_PROYECTAR(object sender, EventArgs e)
        {
            if (!w)
            {
                restart();
                ok += 2;//
                t++;//
                auxstate = 0;
                tipo = 'P';

                if (atonshowing < showing.Length)
                    showing = showing.Insert(atonshowing, "PRO()");
                else
                    showing = "PRO()";

                atonshowing += 4;//sera?
                consultacorrecta = "SELECT ";
                atonconsulta = consultacorrecta.Length;
                paso1 = 'F';
                B_PROYECCION.Enabled = false;
                B_RESTRICCION.Enabled = false;
                B_REUNION.Enabled = false;
                CbBD.Enabled = true;
                Cbtabla.Enabled = true;
                label2.Enabled = true;
                PANEL_SHOW.Text = showing;
            }
        }

        private void GO_REUNIR(object sender, EventArgs e)
        {
            if (paso1 == 'I')
            {
                ok += 2;
                t++;
                auxstate = 0;
                tipo = 'U';

                if (atonshowing < showing.Length)
                    showing = showing.Insert(atonshowing, "REU()");
                else
                    showing = "REU()";
                atonshowing += 4;//sera?
                consultacorrecta = "SELECT * FROM ";
                atonconsulta = consultacorrecta.Length;
                paso1 = 'F';
                B_REUNION.Enabled = false;
                B_RESTRICCION.Enabled = false;
                CbBD.Enabled = true;
                Cbtabla.Enabled = true;
                //Cbcolumna.Enabled = true;
                label2.Enabled = true;
                PANEL_SHOW.Text = showing;
                paso2 = 'I';
            }
            else
            {
                ok += 2;//
                auxstate = 1;
                tipo = 'U';
                showing = showing+ " REU()";
                atonshowing = showing.Length-1;
                consultacorrecta = consultacorrecta + " JOIN ";
                atonconsulta = consultacorrecta.Length;
                paso1 = 'F';
                B_REUNION.Enabled = false;
                B_RESTRICCION.Enabled = true;
                CbBD.Enabled = false;
                Cbcolumna.Enabled = false;
                Cbtabla.Enabled = true;
                label2.Enabled = true;
                PANEL_SHOW.Text = showing;
                paso2 = 'I';
                if (t != ok)
                    B_EJECUTE.Enabled = false;
                else
                    B_EJECUTE.Enabled = true;
            }
        }

        private void NuevaBase(object sender, EventArgs e)
        {
            String consulta = "USE " + CbBD.SelectedValue + " Select name from sys.tables";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, CbBD.SelectedValue.ToString());
                Cbtabla.DataSource = ds;
                Cbtabla.DisplayMember = CbBD.SelectedValue + ".name";
                Cbtabla.ValueMember = CbBD.SelectedValue + ".name";
                Cbtabla.SelectedIndex = -1;
                Cbtabla.Text = "Elija la tabla";
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void Nuevatabla(object sender, EventArgs e)
        {
            String consulta = "use " + CbBD.SelectedValue + " select column_name from information_schema.columns where table_name" + "='" + Cbtabla.SelectedValue + "'";
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, Cbtabla.SelectedValue.ToString());
                Cbcolumna.DataSource = ds;
                Cbcolumna.DisplayMember = Cbtabla.SelectedValue + ".COLUMN_NAME";
                Cbcolumna.ValueMember = Cbtabla.SelectedValue + ".COLUMN_NAME";
                Cbcolumna.SelectedIndex = -1;
                Cbcolumna.Text = "Elija la Columna";
                CbBD.Enabled = false;
                ///////////////////////////
                if (tipo == 'R' && paso3 != 'I')
                {
                    if (atonshowing <= showing.Length)
                    {
                        if (paso2 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, Cbtabla.SelectedValue.ToString())+"[]";
                            atonshowing = showing.Length-1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + Cbtabla.SelectedValue +" WHERE ";
                        }
                        else
                        {

                            showing = auxshowing.Insert(atonaux, Cbtabla.SelectedValue.ToString())+"[]";
                            atonshowing  = atonaux;
                            atonshowing = showing.Length-1;
                            consultacorrecta = auxconsulta + Cbtabla.SelectedValue + " WHERE ";
                        }
                    }
                    if (paso2 == 'F')
                        t--;
                    paso2 = 'F';
                    t++;
                    label3.Enabled = true;
                    PANEL_SHOW.Text = showing;
                    CbBD.Enabled = false;
                    Cbcolumna.Enabled = true;
                    //Escritura.Enabled = true;
                    label2.Enabled = true;
                    label3.Enabled = true;
                    //Bigual.Enabled = true;
                    // Bmenor.Enabled = true;
                    //Bmayor.Enabled = true;
                    //Bmenorigual.Enabled = true;
                    //Bmayorigual.Enabled = true;
                    //Bdiferente.Enabled = true;
                    //BOR.Enabled = true;
                    //BAND.Enabled = true;
                    BNOT.Enabled = true;
                    //BIS_NULL.Enabled = true;
                    //B_IS_NOT_NULL.Enabled = true;
                    //text.Enabled = true;
                    //num.Enabled = true;
                    //bol.Enabled = true;
                    //buttonadd.Enabled = true;
                }else///////////////////////////////////
                    if (tipo == 'P'&&paso2!='F')
                        {
                                select1 = Cbtabla.SelectedValue.ToString();
                                if (paso2 == ' ')
                                {
                                    auxshowing = showing;
                                    atonaux = atonshowing;
                                    showing = showing.Insert(atonshowing, Cbtabla.SelectedValue.ToString()) + "[]";
                                    atonshowing = showing.Length-1;
                                    auxconsulta = consultacorrecta;
                                    consultacorrecta = consultacorrecta +" FROM "+ Cbtabla.SelectedValue;
                                }
                                else if(paso2=='I')
                                {

                                    showing = auxshowing.Insert(atonaux, Cbtabla.SelectedValue.ToString()) + "[]";
                                    atonshowing = atonaux;
                                    atonshowing = showing.Length - 1;
                                    consultacorrecta = auxconsulta +" FROM "+ Cbtabla.SelectedValue;                                    
                                }
                               
                                    if (paso2 == 'I')
                                    {
                                        t--;
                                        if (t == 1)
                                            t--;
                                    }

                            paso2 = 'I';
                            t++;
                            PANEL_SHOW.Text = showing;
                            CbBD.Enabled = false;
                            Cbcolumna.Enabled = true;
                            label2.Enabled = true;
                        }else
                        if(tipo=='U')
                        {
                            if (paso2 != 'F'&&auxstate==0)
                                {
                                    select1 = Cbtabla.SelectedValue.ToString();
                                    auxshowing = showing;
                                    atonaux = atonshowing;
                                    showing = showing.Insert(atonshowing, Cbtabla.SelectedValue.ToString());
                                    atonshowing = showing.Length - 1;
                                    auxconsulta = consultacorrecta;
                                    consultacorrecta = consultacorrecta + Cbtabla.SelectedValue + " JOIN ";
                                    atonconsulta = consultacorrecta.Length;
                                    auxstate=1;
                                }
                                else if(auxstate==1&&select1!=Cbtabla.SelectedValue.ToString())
                                {
                                    t++;
                                    auxstate=0;
                                    select2 = Cbtabla.SelectedValue.ToString();
                                    showing = showing.Insert(atonshowing, " con " + Cbtabla.SelectedValue.ToString())+"[ ]";
                                    atonshowing = showing.Length - 1;
                                    auxconsulta = consultacorrecta;
                                    consultacorrecta = consultacorrecta.Insert(atonconsulta, Cbtabla.SelectedValue.ToString() ) + "  ";
                                    paso2 = 'F';

                                    consulta = "use " + CbBD.SelectedValue + " select column_name from information_schema.columns where table_name" + "='" + select1 + "'";
                                    conexion = new SqlConnection(cadenaConexion);
                                    conexion.Open();
                                    cmd = new SqlCommand(consulta, conexion);
                                    cmd.ExecuteNonQuery();
                                    ds = new DataSet();
                                    da = new SqlDataAdapter(cmd);
                                    da.Fill(ds, Cbtabla.SelectedValue.ToString());
                                    Cbcolumna.DataSource = ds;
                                    Cbcolumna.DisplayMember = Cbtabla.SelectedValue + ".COLUMN_NAME";
                                    Cbcolumna.ValueMember = Cbtabla.SelectedValue + ".COLUMN_NAME";
                                    Cbcolumna.SelectedIndex = -1;
                                    Cbcolumna.Text = "Elija la Columna";


                                    label3.Enabled = true;
                                    CbBD.Enabled = false;
                                    Cbtabla.Enabled = false;
                                    Cbcolumna.Enabled = true;
                                    label3.Enabled = true;
                                    BNOT.Enabled = true;
                                }
                            PANEL_SHOW.Text = showing;

                        }
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void Nuevacolumna(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 'R' && paso2 == 'F')
                {
                    if(paso3==' ')
                        paso3 = 'I';
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = false;
                    CbBD.Enabled = false;
                    if (atonshowing <= showing.Length)
                    {
                        if (t!=ok)
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, Cbcolumna.SelectedValue.ToString());
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + Cbtabla.SelectedValue.ToString() + "." + Cbcolumna.SelectedValue;
                            //
                            Bigual.Enabled = true;
                            Bmenor.Enabled = true;
                            Bmayor.Enabled = true;
                            Bmenorigual.Enabled = true;
                            Bmayorigual.Enabled = true;
                            Bdiferente.Enabled = true;
                            BNOT.Enabled = false;
                            BIS_NULL.Enabled = true;
                            B_IS_NOT_NULL.Enabled = true;
                            if (t != ok)
                                B_EJECUTE.Enabled = false;
                            else
                                B_EJECUTE.Enabled = true;

                            if (paso3 == 'F')
                            {
                                t++;
                                Escritura.Enabled = false;
                                Bigual.Enabled = false;
                                Bmenor.Enabled = false;
                                Bmayor.Enabled = false;
                                Bmenorigual.Enabled = false;
                                Bmayorigual.Enabled = false;
                                Bdiferente.Enabled = false;
                                BOR.Enabled = true;
                                BAND.Enabled = true;
                                BNOT.Enabled = false;
                                BIS_NULL.Enabled = false;
                                B_IS_NOT_NULL.Enabled = false;
                                text.Enabled = false;
                                num.Enabled = false;
                                buttonadd.Enabled = false;
                                if (t != ok)
                                    B_EJECUTE.Enabled = false;
                                else
                                    B_EJECUTE.Enabled = true;
                            }
                        }
                        
                    }
                    PANEL_SHOW.Text = showing;
                }else
                    if (tipo == 'P')
                    {
                        CbBD.Enabled = false;
                        B_RESTRICCION.Enabled = true;
                        if (paso2=='I')
                        {
                            paso2 = 'F';
                            t++;
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, Cbcolumna.SelectedValue.ToString());
                            atonshowing = showing.Length - 1;
                            atonconsulta = auxconsulta.Length;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta.Insert(atonconsulta, Cbtabla.SelectedValue.ToString()+"."+Cbcolumna.SelectedValue.ToString());
                            if (t != ok)
                                B_EJECUTE.Enabled = false;
                            else
                                B_EJECUTE.Enabled = true;
                        }
                        else
                        {
                            showing = showing.Insert(atonaux, Cbcolumna.SelectedValue.ToString()+" ,");
                            atonshowing = atonaux;
                            atonshowing = showing.Length;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta.Insert(atonconsulta, Cbtabla.SelectedValue.ToString() + "." + Cbcolumna.SelectedValue.ToString() + " ,");
                        }
                        B_REUNION.Enabled = true;
                        PANEL_SHOW.Text = showing;
                    }else


                        if (tipo == 'U' && paso2 == 'F')
                        {
                            if (paso3 == ' ')
                                paso3 = 'I';
                            Cbtabla.Enabled = false;
                            Cbcolumna.Enabled = false;
                            CbBD.Enabled = false;
                            if (atonshowing <= showing.Length)
                            {

                                if (t != ok)
                                {
                                    if (auxstate == 0)
                                    {
                                        auxshowing = showing;
                                        atonaux = atonshowing;
                                        showing = showing.Insert(atonshowing, select1 +"."+ Cbcolumna.SelectedValue.ToString());
                                        atonshowing = showing.Length - 1;
                                        auxconsulta = consultacorrecta;
                                        consultacorrecta = consultacorrecta + " ON " + select1 + "." + Cbcolumna.SelectedValue;
                                        auxstate = 1;
                                        String consulta = "use " + CbBD.SelectedValue + " select column_name from information_schema.columns where table_name" + "='" + select2 + "'";
                                        SqlConnection conexion = new SqlConnection(cadenaConexion);
                                        conexion.Open();
                                        SqlCommand cmd = new SqlCommand(consulta, conexion);
                                        cmd.ExecuteNonQuery();
                                        DataSet ds = new DataSet();
                                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                                        da.Fill(ds, Cbtabla.SelectedValue.ToString());
                                        Cbcolumna.DataSource = ds;
                                        Cbcolumna.DisplayMember = Cbtabla.SelectedValue + ".COLUMN_NAME";
                                        Cbcolumna.ValueMember = Cbtabla.SelectedValue + ".COLUMN_NAME";
                                        Cbcolumna.SelectedIndex = -1;
                                        Cbcolumna.Text = "Elija la Columna";


                                    }else
                                        if (auxstate == 1)
                                        {

                                            auxshowing = showing;
                                            atonaux = atonshowing;
                                            showing = showing.Insert(atonshowing, select2 + "." + Cbcolumna.SelectedValue.ToString());
                                            atonshowing = showing.Length - 1;
                                            auxconsulta = consultacorrecta;
                                            consultacorrecta = consultacorrecta + select2 + "." + Cbcolumna.SelectedValue;
                                        }

                                    Bigual.Enabled = true;
                                    Bmenor.Enabled = true;
                                    Bmayor.Enabled = true;
                                    Bmenorigual.Enabled = true;
                                    Bmayorigual.Enabled = true;
                                    Bdiferente.Enabled = true;
                                    BNOT.Enabled = false;
                                    BIS_NULL.Enabled = true;
                                    B_IS_NOT_NULL.Enabled = true;
                                    if (t != ok)
                                        B_EJECUTE.Enabled = false;
                                    else
                                        B_EJECUTE.Enabled = true;

                                    if (paso3 == 'F')
                                    {
                                        t++;
                                        Escritura.Enabled = false;
                                        Bigual.Enabled = false;
                                        Bmenor.Enabled = false;
                                        Bmayor.Enabled = false;
                                        Bmenorigual.Enabled = false;
                                        Bmayorigual.Enabled = false;
                                        Bdiferente.Enabled = false;
                                        BOR.Enabled = true;
                                        BAND.Enabled = true;
                                        BNOT.Enabled = false;
                                        BIS_NULL.Enabled = false;
                                        B_IS_NOT_NULL.Enabled = false;
                                        text.Enabled = false;
                                        num.Enabled = false;
                                        buttonadd.Enabled = false;
                                        if (t != ok)
                                            B_EJECUTE.Enabled = false;
                                        else
                                            B_EJECUTE.Enabled = true;
                                    }
                                }
                                
                            }

                            PANEL_SHOW.Text = showing;
                        }


            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void LOCKING(object sender, EventArgs e)
        {
            if (LOCKBUTTON.Checked)
            {
                restart();
                PANEL_SHOW.Enabled = false;
            }
            else
            {
                restart();
                PANEL_SHOW.Enabled = true;
                B_EJECUTE.Enabled = true;
            }
        }

        //aca se toman los valores del textbox escritura
        private void Addingmanualdata(object sender, EventArgs e)
        {
            try
            {
                if (paso2 == 'F')
                {
                    
                    if (atonshowing <= showing.Length)
                    {
                        if (text.Checked)
                            if (t != ok && verificarComillasSimples(Escritura.Text))
                            {
                                auxshowing = showing;
                                atonaux = atonshowing;
                                showing = showing.Insert(atonshowing, " '"+Escritura.Text+"' ");
                                atonshowing = showing.Length - 1;
                                auxconsulta = consultacorrecta;
                                consultacorrecta = consultacorrecta + " '" + Escritura.Text + "' ";
                                if (paso3 == 'I')
                                    paso3 = 'F';
                                t++;
                                Cbtabla.Enabled = false;
                                CbBD.Enabled = false;
                                Cbcolumna.Enabled = false;
                                Escritura.Enabled = false;
                                Bigual.Enabled = false;
                                Bmenor.Enabled = false;
                                Bmayor.Enabled = false;
                                Bmenorigual.Enabled = false;
                                Bmayorigual.Enabled = false;
                                Bdiferente.Enabled = false;
                                BOR.Enabled = true;
                                BAND.Enabled = true;
                                BNOT.Enabled = false;
                                BIS_NULL.Enabled = false;
                                B_IS_NOT_NULL.Enabled = false;
                                text.Enabled = false;
                                num.Enabled = false;
                                buttonadd.Enabled = false;
                                if (t != ok)
                                    B_EJECUTE.Enabled = false;
                                else
                                    B_EJECUTE.Enabled = true;
                            }
                            else
                            {
                                Escritura.Text = "''ERROR DE ESCRITURA''";
                            }
                        else
                        {
                                auxshowing = showing;
                                atonaux = atonshowing;
                                showing = showing.Insert(atonshowing, " "+Escritura.Text+" ");
                                atonshowing = showing.Length - 1;
                                auxconsulta = consultacorrecta;
                                consultacorrecta = consultacorrecta + " "+Escritura.Text+" ";
                                if (paso3 == 'I')
                                    paso3 = 'F';
                                t++;
                                Cbtabla.Enabled = false;
                                CbBD.Enabled = false;
                                Cbcolumna.Enabled = false;
                                Escritura.Enabled = false;
                                Bigual.Enabled = false;
                                Bmenor.Enabled = false;
                                Bmayor.Enabled = false;
                                Bmenorigual.Enabled = false;
                                Bmayorigual.Enabled = false;
                                Bdiferente.Enabled = false;
                                BOR.Enabled = true;
                                BAND.Enabled = true;
                                BNOT.Enabled = false;
                                BIS_NULL.Enabled = false;
                                B_IS_NOT_NULL.Enabled = false;
                                text.Enabled = false;
                                num.Enabled = false;
                                buttonadd.Enabled = false;
                                if (t != ok)
                                    B_EJECUTE.Enabled = false;
                                else
                                    B_EJECUTE.Enabled = true;
                        }
                    }
                    PANEL_SHOW.Text = showing;
                }

            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opigual(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 'R' && paso2 == 'F')
                {
                    paso3 = 'I';
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = true;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = false;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true;
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;

                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " = ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " = ";
                        }
                    PANEL_SHOW.Text = showing;
                    paso3 = 'F';
                }else
                    if (tipo == 'U' && paso2 == 'F')
                    {
                        paso3 = 'I';
                        Cbtabla.Enabled = false;
                        Cbcolumna.Enabled = true;
                        Escritura.Enabled = true;
                        Bigual.Enabled = false;
                        Bmenor.Enabled = false;
                        Bmayor.Enabled = false;
                        Bmenorigual.Enabled = false;
                        Bmayorigual.Enabled = false;
                        Bdiferente.Enabled = false;
                        BOR.Enabled = false;
                        BAND.Enabled = false;
                        BNOT.Enabled = false;
                        BIS_NULL.Enabled = false;
                        B_IS_NOT_NULL.Enabled = false;
                        text.Enabled = true;
                        num.Enabled = true;
                        buttonadd.Enabled = true;
                        if (t != ok)
                            B_EJECUTE.Enabled = false;
                        else
                            B_EJECUTE.Enabled = true;
                        if (atonshowing <= showing.Length)
                        {
                            if (paso3 != 'F')
                            {
                                auxshowing = showing;
                                atonaux = atonshowing;
                                showing = showing.Insert(atonshowing, " = ");
                                atonshowing = showing.Length - 1;
                                auxconsulta = consultacorrecta;
                                consultacorrecta = consultacorrecta + " = ";
                            }
                        }
                        PANEL_SHOW.Text = showing;
                        paso3 = 'F';
                    }


            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opimenor(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 'R' && paso2 == 'F')
                {
                    paso3 = 'I';
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = true;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = false;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true;
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;
                    if (atonshowing <= showing.Length)
                    {
                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " < ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " < ";
                        }
                    }
                    PANEL_SHOW.Text = showing;
                    paso3 = 'F';
                }
                else
                    if (tipo == 'U' && paso2 == 'F')
                    {
                        paso3 = 'I';
                        Cbtabla.Enabled = false;
                        Cbcolumna.Enabled = true;
                        Escritura.Enabled = true;
                        Bigual.Enabled = false;
                        Bmenor.Enabled = false;
                        Bmayor.Enabled = false;
                        Bmenorigual.Enabled = false;
                        Bmayorigual.Enabled = false;
                        Bdiferente.Enabled = false;
                        BOR.Enabled = false;
                        BAND.Enabled = false;
                        BNOT.Enabled = false;
                        BIS_NULL.Enabled = false;
                        B_IS_NOT_NULL.Enabled = false;
                        text.Enabled = true;
                        num.Enabled = true;
                        buttonadd.Enabled = true;
                        if (t != ok)
                            B_EJECUTE.Enabled = false;
                        else
                            B_EJECUTE.Enabled = true;
                        if (atonshowing <= showing.Length)
                        {
                            if (paso3 != 'F')
                            {
                                auxshowing = showing;
                                atonaux = atonshowing;
                                showing = showing.Insert(atonshowing, " < ");
                                atonshowing = showing.Length - 1;
                                auxconsulta = consultacorrecta;
                                consultacorrecta = consultacorrecta + " < ";
                            }
                        }
                        PANEL_SHOW.Text = showing;
                        paso3 = 'F';
                    }


            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opimayor(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 'R' && paso2 == 'F')
                {
                    paso3 = 'I';
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = true;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = false;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true; 
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;
                    if (atonshowing <= showing.Length)
                    {
                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " > ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " > ";
                        }
                    }
                    PANEL_SHOW.Text = showing;
                    paso3 = 'F';
                }
                else
                    if (tipo == 'U' && paso2 == 'F')
                    {
                        paso3 = 'I';
                        Cbtabla.Enabled = false;
                        Cbcolumna.Enabled = true;
                        Escritura.Enabled = true;
                        Bigual.Enabled = false;
                        Bmenor.Enabled = false;
                        Bmayor.Enabled = false;
                        Bmenorigual.Enabled = false;
                        Bmayorigual.Enabled = false;
                        Bdiferente.Enabled = false;
                        BOR.Enabled = false;
                        BAND.Enabled = false;
                        BNOT.Enabled = false;
                        BIS_NULL.Enabled = false;
                        B_IS_NOT_NULL.Enabled = false;
                        text.Enabled = true;
                        num.Enabled = true;
                        buttonadd.Enabled = true;
                        if (t != ok)
                            B_EJECUTE.Enabled = false;
                        else
                            B_EJECUTE.Enabled = true;
                        if (atonshowing <= showing.Length)
                        {
                            if (paso3 != 'F')
                            {
                                auxshowing = showing;
                                atonaux = atonshowing;
                                showing = showing.Insert(atonshowing, " > ");
                                atonshowing = showing.Length - 1;
                                auxconsulta = consultacorrecta;
                                consultacorrecta = consultacorrecta + " > ";
                            }
                        }
                        PANEL_SHOW.Text = showing;
                        paso3 = 'F';
                    }


            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opimenorigual(object sender, EventArgs e)
        {
            try
            {
                if (tipo == 'R' && paso2 == 'F')
                {
                    paso3 = 'I';
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = true;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = false;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true; 
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;
                    if (atonshowing <= showing.Length)
                    {
                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " <= ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " <= ";
                        }
                    }
                    PANEL_SHOW.Text = showing;
                    paso3 = 'F';
                }
                else
                    if (tipo == 'U' && paso2 == 'F')
                    {
                        paso3 = 'I';
                        Cbtabla.Enabled = false;
                        Cbcolumna.Enabled = true;
                        Escritura.Enabled = true;
                        Bigual.Enabled = false;
                        Bmenor.Enabled = false;
                        Bmayor.Enabled = false;
                        Bmenorigual.Enabled = false;
                        Bmayorigual.Enabled = false;
                        Bdiferente.Enabled = false;
                        BOR.Enabled = false;
                        BAND.Enabled = false;
                        BNOT.Enabled = false;
                        BIS_NULL.Enabled = false;
                        B_IS_NOT_NULL.Enabled = false;
                        text.Enabled = true;
                        num.Enabled = true;
                        buttonadd.Enabled = true;
                        if (t != ok)
                            B_EJECUTE.Enabled = false;
                        else
                            B_EJECUTE.Enabled = true;
                        if (atonshowing <= showing.Length)
                        {
                            if (paso3 != 'F')
                            {
                                auxshowing = showing;
                                atonaux = atonshowing;
                                showing = showing.Insert(atonshowing, " <= ");
                                atonshowing = showing.Length - 1;
                                auxconsulta = consultacorrecta;
                                consultacorrecta = consultacorrecta + " <= ";
                            }
                        }
                        PANEL_SHOW.Text = showing;
                        paso3 = 'F';
                    }


            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opimayorigual(object sender, EventArgs e)
        {
            try
            {
                if (paso2 == 'F')
                {
                    paso3 = 'I';
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = true;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = false;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true; 
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;
                    if (atonshowing <= showing.Length)
                    {
                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " >= ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " >= ";
                        }
                    }
                    PANEL_SHOW.Text = showing;
                    paso3 = 'F';
                }
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opidife(object sender, EventArgs e)
        {
            try
            {
                if (paso2 == 'F')
                {
                    paso3 = 'I';
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = true;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = false;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true; 
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;
                    if (atonshowing <= showing.Length)
                    {
                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " <> ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " <> ";
                        }
                    }
                    PANEL_SHOW.Text = showing;
                    paso3 = 'F';
                }
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opisnotnull(object sender, EventArgs e)
        {
            try
            {
                if (paso2 == 'F')
                {
                    Cbtabla.Enabled = false;
                    CbBD.Enabled = false;
                    Cbcolumna.Enabled=false;
                    if (atonshowing <= showing.Length)
                    {

                        if (t!=ok)
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " IS NOT NULL ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " IS NOT NULL ";
                            if(paso3=='I')
                                paso3 = 'F';
                            t++;
                            Escritura.Enabled = false;
                            Bigual.Enabled = false;
                            Bmenor.Enabled = false;
                            Bmayor.Enabled = false;
                            Bmenorigual.Enabled = false;
                            Bmayorigual.Enabled = false;
                            Bdiferente.Enabled = false;
                            BOR.Enabled = true;
                            BAND.Enabled = true;
                            BNOT.Enabled = false;
                            BIS_NULL.Enabled = false;
                            B_IS_NOT_NULL.Enabled = false;
                            text.Enabled = false;
                            num.Enabled = false;
                            buttonadd.Enabled = false;
                            if (t != ok)
                               B_EJECUTE.Enabled = false;
                            else
                               B_EJECUTE.Enabled = true;
                        }             
                    }
                    PANEL_SHOW.Text = showing;
                }
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return;} 
        }

        private void opisnull(object sender, EventArgs e)
        {
            try
            {
                if (paso2 == 'F')
                {
                    Cbtabla.Enabled = false;
                    CbBD.Enabled = false;
                    Cbcolumna.Enabled = false;
                    if (atonshowing <= showing.Length)
                    {
                        if (t != ok)
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " IS NULL ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " IS NULL ";
                            if (paso3 == 'I')
                                paso3 = 'F';
                            t++;
                            Escritura.Enabled = false;
                            Bigual.Enabled = false;
                            Bmenor.Enabled = false;
                            Bmayor.Enabled = false;
                            Bmenorigual.Enabled = false;
                            Bmayorigual.Enabled = false;
                            Bdiferente.Enabled = false;
                            BOR.Enabled = true;
                            BAND.Enabled = true;
                            BNOT.Enabled = false;
                            BIS_NULL.Enabled = false;
                            B_IS_NOT_NULL.Enabled = false;
                            text.Enabled = false;
                            num.Enabled = false;
                            buttonadd.Enabled = false;
                            if (t != ok)
                                B_EJECUTE.Enabled = false;
                            else
                                B_EJECUTE.Enabled = true;
                        }
                    }
                    PANEL_SHOW.Text = showing;
                }
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opinot(object sender, EventArgs e)
        {
                try
                {
                    if (paso2 == 'F')
                    {
                        paso3 = 'I';
                        Cbtabla.Enabled = false;
                        CbBD.Enabled = false;
                        if (atonshowing <= showing.Length)
                        {

                            if (paso3 != 'F')
                            {
                                auxshowing = showing;
                                atonaux = atonshowing;
                                showing = showing.Insert(atonshowing, "NOT ");
                                atonshowing = showing.Length - 1;
                                auxconsulta = consultacorrecta;
                                consultacorrecta = consultacorrecta + " NOT";
                            }
                        }
                        PANEL_SHOW.Text = showing;
                    }
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                }
                catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
            
        }

        private void opior(object sender, EventArgs e)
        {
            try
            {
                if (paso2 == 'F')
                {
                    paso3 = 'I';
                    t --;
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = false;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = true;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true;
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;
                    if (atonshowing <= showing.Length)
                    {
                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " OR ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " OR ";
                        }
                    }
                    PANEL_SHOW.Text = showing;
                }
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }

        private void opiand(object sender, EventArgs e)
        {
            try
            {
                if (paso2 == 'F')
                {
                    paso3 = 'I';
                    t--;
                    Cbtabla.Enabled = false;
                    Cbcolumna.Enabled = true;
                    Escritura.Enabled = false;
                    Bigual.Enabled = false;
                    Bmenor.Enabled = false;
                    Bmayor.Enabled = false;
                    Bmenorigual.Enabled = false;
                    Bmayorigual.Enabled = false;
                    Bdiferente.Enabled = false;
                    BOR.Enabled = false;
                    BAND.Enabled = false;
                    BNOT.Enabled = true;
                    BIS_NULL.Enabled = false;
                    B_IS_NOT_NULL.Enabled = false;
                    text.Enabled = true;
                    num.Enabled = true;
                    buttonadd.Enabled = true;
                    if (t != ok)
                        B_EJECUTE.Enabled = false;
                    else
                        B_EJECUTE.Enabled = true;
                    if (atonshowing <= showing.Length)
                    {
                        if (paso3 != 'F')
                        {
                            auxshowing = showing;
                            atonaux = atonshowing;
                            showing = showing.Insert(atonshowing, " AND ");
                            atonshowing = showing.Length - 1;
                            auxconsulta = consultacorrecta;
                            consultacorrecta = consultacorrecta + " AND ";
                        }
                    }
                    PANEL_SHOW.Text = showing;
                }
            }
            catch (Exception mistery) { MessageBox.Show(mistery.Message, "No sabemos porque, pero algo salio mal :("); return; }
        }
    }
}