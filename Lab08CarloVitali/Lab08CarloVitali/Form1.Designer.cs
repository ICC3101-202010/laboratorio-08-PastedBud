using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08CarloVitali
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Principal = new System.Windows.Forms.Panel();
            this.pAgregar = new System.Windows.Forms.Panel();
            this.pInfoNuevoLocal = new System.Windows.Forms.Panel();
            this.confirmacionAgregado = new System.Windows.Forms.Panel();
            this.pInfoNuevoRecreacional = new System.Windows.Forms.Panel();
            this.bAgregarNuevoRecreacional = new System.Windows.Forms.Button();
            this.bAtrasInfoNuevoRecreacional = new System.Windows.Forms.Button();
            this.pInfoNuevoRestaurant = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.bAgregarRestaurant = new System.Windows.Forms.Button();
            this.bAtrasInfoRestaurant = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputMesa = new System.Windows.Forms.TextBox();
            this.pInfoNuevaTienda = new System.Windows.Forms.Panel();
            this.batrasTienda = new System.Windows.Forms.Button();
            this.bAgregarTienda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.input_Categorias = new System.Windows.Forms.TextBox();
            this.input_Horario = new System.Windows.Forms.TextBox();
            this.pInfoNuevoCine = new System.Windows.Forms.Panel();
            this.bAtrasInfoCine = new System.Windows.Forms.Button();
            this.bAgregarNuevoCine = new System.Windows.Forms.Button();
            this.inputCantSalas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_Numero_Identificador = new System.Windows.Forms.TextBox();
            this.input_Nombre_Dueño = new System.Windows.Forms.TextBox();
            this.bRecreacional = new System.Windows.Forms.Button();
            this.bCine = new System.Windows.Forms.Button();
            this.bRestaurante = new System.Windows.Forms.Button();
            this.bTienda = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bLista = new System.Windows.Forms.Button();
            this.bRevisar = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.pLista = new System.Windows.Forms.Panel();
            this.Lista = new System.Windows.Forms.RichTextBox();
            this.bAtrasLista = new System.Windows.Forms.Button();
            this.Principal.SuspendLayout();
            this.pAgregar.SuspendLayout();
            this.pInfoNuevoLocal.SuspendLayout();
            this.pInfoNuevoRecreacional.SuspendLayout();
            this.pInfoNuevoRestaurant.SuspendLayout();
            this.pInfoNuevaTienda.SuspendLayout();
            this.pInfoNuevoCine.SuspendLayout();
            this.pLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // Principal
            // 
            this.Principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Principal.BackgroundImage")));
            this.Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Principal.Controls.Add(this.pLista);
            this.Principal.Controls.Add(this.pAgregar);
            this.Principal.Controls.Add(this.bLista);
            this.Principal.Controls.Add(this.bRevisar);
            this.Principal.Controls.Add(this.bAgregar);
            this.Principal.Location = new System.Drawing.Point(0, 0);
            this.Principal.Name = "Principal";
            this.Principal.Size = new System.Drawing.Size(517, 375);
            this.Principal.TabIndex = 0;
            // 
            // pAgregar
            // 
            this.pAgregar.BackColor = System.Drawing.Color.White;
            this.pAgregar.Controls.Add(this.pInfoNuevoLocal);
            this.pAgregar.Controls.Add(this.bRecreacional);
            this.pAgregar.Controls.Add(this.bCine);
            this.pAgregar.Controls.Add(this.bRestaurante);
            this.pAgregar.Controls.Add(this.bTienda);
            this.pAgregar.Controls.Add(this.label9);
            this.pAgregar.Controls.Add(this.label10);
            this.pAgregar.Location = new System.Drawing.Point(0, 12);
            this.pAgregar.Name = "pAgregar";
            this.pAgregar.Size = new System.Drawing.Size(514, 363);
            this.pAgregar.TabIndex = 3;
            this.pAgregar.Visible = false;
            // 
            // pInfoNuevoLocal
            // 
            this.pInfoNuevoLocal.BackColor = System.Drawing.Color.White;
            this.pInfoNuevoLocal.Controls.Add(this.confirmacionAgregado);
            this.pInfoNuevoLocal.Controls.Add(this.pInfoNuevoRecreacional);
            this.pInfoNuevoLocal.Controls.Add(this.pInfoNuevoRestaurant);
            this.pInfoNuevoLocal.Controls.Add(this.pInfoNuevaTienda);
            this.pInfoNuevoLocal.Controls.Add(this.input_Horario);
            this.pInfoNuevoLocal.Controls.Add(this.pInfoNuevoCine);
            this.pInfoNuevoLocal.Controls.Add(this.label4);
            this.pInfoNuevoLocal.Controls.Add(this.label3);
            this.pInfoNuevoLocal.Controls.Add(this.label2);
            this.pInfoNuevoLocal.Controls.Add(this.label1);
            this.pInfoNuevoLocal.Controls.Add(this.input_Numero_Identificador);
            this.pInfoNuevoLocal.Controls.Add(this.input_Nombre_Dueño);
            this.pInfoNuevoLocal.Location = new System.Drawing.Point(0, 12);
            this.pInfoNuevoLocal.Name = "pInfoNuevoLocal";
            this.pInfoNuevoLocal.Size = new System.Drawing.Size(503, 366);
            this.pInfoNuevoLocal.TabIndex = 5;
            this.pInfoNuevoLocal.Visible = false;
            this.pInfoNuevoLocal.Paint += new System.Windows.Forms.PaintEventHandler(this.pInfoNuevaTienda_Paint);
            // 
            // confirmacionAgregado
            // 
            this.confirmacionAgregado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmacionAgregado.BackgroundImage")));
            this.confirmacionAgregado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmacionAgregado.Location = new System.Drawing.Point(12, 12);
            this.confirmacionAgregado.Name = "confirmacionAgregado";
            this.confirmacionAgregado.Size = new System.Drawing.Size(478, 324);
            this.confirmacionAgregado.TabIndex = 2;
            this.confirmacionAgregado.Visible = false;
            // 
            // pInfoNuevoRecreacional
            // 
            this.pInfoNuevoRecreacional.Controls.Add(this.bAgregarNuevoRecreacional);
            this.pInfoNuevoRecreacional.Controls.Add(this.bAtrasInfoNuevoRecreacional);
            this.pInfoNuevoRecreacional.Location = new System.Drawing.Point(0, 210);
            this.pInfoNuevoRecreacional.Name = "pInfoNuevoRecreacional";
            this.pInfoNuevoRecreacional.Size = new System.Drawing.Size(514, 162);
            this.pInfoNuevoRecreacional.TabIndex = 10;
            this.pInfoNuevoRecreacional.Visible = false;
            // 
            // bAgregarNuevoRecreacional
            // 
            this.bAgregarNuevoRecreacional.Location = new System.Drawing.Point(272, 100);
            this.bAgregarNuevoRecreacional.Name = "bAgregarNuevoRecreacional";
            this.bAgregarNuevoRecreacional.Size = new System.Drawing.Size(157, 23);
            this.bAgregarNuevoRecreacional.TabIndex = 1;
            this.bAgregarNuevoRecreacional.Text = "Agregar Nuevo Recreacional";
            this.bAgregarNuevoRecreacional.UseVisualStyleBackColor = true;
            this.bAgregarNuevoRecreacional.Click += new System.EventHandler(this.bAgregarNuevoRecreacional_Click);
            // 
            // bAtrasInfoNuevoRecreacional
            // 
            this.bAtrasInfoNuevoRecreacional.Location = new System.Drawing.Point(84, 100);
            this.bAtrasInfoNuevoRecreacional.Name = "bAtrasInfoNuevoRecreacional";
            this.bAtrasInfoNuevoRecreacional.Size = new System.Drawing.Size(157, 23);
            this.bAtrasInfoNuevoRecreacional.TabIndex = 0;
            this.bAtrasInfoNuevoRecreacional.Text = "atrás";
            this.bAtrasInfoNuevoRecreacional.UseVisualStyleBackColor = true;
            this.bAtrasInfoNuevoRecreacional.Click += new System.EventHandler(this.bAtrasInfoNuevoRecreacional_Click);
            // 
            // pInfoNuevoRestaurant
            // 
            this.pInfoNuevoRestaurant.Controls.Add(this.label11);
            this.pInfoNuevoRestaurant.Controls.Add(this.bAgregarRestaurant);
            this.pInfoNuevoRestaurant.Controls.Add(this.bAtrasInfoRestaurant);
            this.pInfoNuevoRestaurant.Controls.Add(this.label8);
            this.pInfoNuevoRestaurant.Controls.Add(this.label7);
            this.pInfoNuevoRestaurant.Controls.Add(this.inputMesa);
            this.pInfoNuevoRestaurant.Location = new System.Drawing.Point(3, 207);
            this.pInfoNuevoRestaurant.Name = "pInfoNuevoRestaurant";
            this.pInfoNuevoRestaurant.Size = new System.Drawing.Size(511, 168);
            this.pInfoNuevoRestaurant.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Cuenta con Mesas Exclusivas?";
            // 
            // bAgregarRestaurant
            // 
            this.bAgregarRestaurant.Location = new System.Drawing.Point(281, 106);
            this.bAgregarRestaurant.Name = "bAgregarRestaurant";
            this.bAgregarRestaurant.Size = new System.Drawing.Size(123, 23);
            this.bAgregarRestaurant.TabIndex = 4;
            this.bAgregarRestaurant.Text = "Agregar Restaurant";
            this.bAgregarRestaurant.UseVisualStyleBackColor = true;
            this.bAgregarRestaurant.Click += new System.EventHandler(this.bAgregarRestaurant_Click);
            // 
            // bAtrasInfoRestaurant
            // 
            this.bAtrasInfoRestaurant.Location = new System.Drawing.Point(135, 106);
            this.bAtrasInfoRestaurant.Name = "bAtrasInfoRestaurant";
            this.bAtrasInfoRestaurant.Size = new System.Drawing.Size(123, 23);
            this.bAtrasInfoRestaurant.TabIndex = 3;
            this.bAtrasInfoRestaurant.Text = "atrás";
            this.bAtrasInfoRestaurant.UseVisualStyleBackColor = true;
            this.bAtrasInfoRestaurant.Click += new System.EventHandler(this.bAtrasInfoRestaurant_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "(Si / No)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(53, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 5;
            // 
            // inputMesa
            // 
            this.inputMesa.Location = new System.Drawing.Point(194, 25);
            this.inputMesa.Name = "inputMesa";
            this.inputMesa.Size = new System.Drawing.Size(210, 20);
            this.inputMesa.TabIndex = 0;
            // 
            // pInfoNuevaTienda
            // 
            this.pInfoNuevaTienda.Controls.Add(this.batrasTienda);
            this.pInfoNuevaTienda.Controls.Add(this.bAgregarTienda);
            this.pInfoNuevaTienda.Controls.Add(this.label5);
            this.pInfoNuevaTienda.Controls.Add(this.input_Categorias);
            this.pInfoNuevaTienda.Location = new System.Drawing.Point(3, 204);
            this.pInfoNuevaTienda.Name = "pInfoNuevaTienda";
            this.pInfoNuevaTienda.Size = new System.Drawing.Size(514, 171);
            this.pInfoNuevaTienda.TabIndex = 8;
            this.pInfoNuevaTienda.Visible = false;
            // 
            // batrasTienda
            // 
            this.batrasTienda.Location = new System.Drawing.Point(143, 75);
            this.batrasTienda.Name = "batrasTienda";
            this.batrasTienda.Size = new System.Drawing.Size(115, 23);
            this.batrasTienda.TabIndex = 8;
            this.batrasTienda.Text = "atrás";
            this.batrasTienda.UseVisualStyleBackColor = true;
            this.batrasTienda.Click += new System.EventHandler(this.batrasTienda_Click);
            // 
            // bAgregarTienda
            // 
            this.bAgregarTienda.Location = new System.Drawing.Point(292, 75);
            this.bAgregarTienda.Name = "bAgregarTienda";
            this.bAgregarTienda.Size = new System.Drawing.Size(115, 23);
            this.bAgregarTienda.TabIndex = 7;
            this.bAgregarTienda.Text = "Agregar Tienda";
            this.bAgregarTienda.UseVisualStyleBackColor = true;
            this.bAgregarTienda.Click += new System.EventHandler(this.bAgregarTienda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categorias";
            // 
            // input_Categorias
            // 
            this.input_Categorias.Location = new System.Drawing.Point(194, 16);
            this.input_Categorias.Name = "input_Categorias";
            this.input_Categorias.Size = new System.Drawing.Size(213, 20);
            this.input_Categorias.TabIndex = 6;
            // 
            // input_Horario
            // 
            this.input_Horario.Location = new System.Drawing.Point(197, 178);
            this.input_Horario.Name = "input_Horario";
            this.input_Horario.Size = new System.Drawing.Size(210, 20);
            this.input_Horario.TabIndex = 7;
            // 
            // pInfoNuevoCine
            // 
            this.pInfoNuevoCine.Controls.Add(this.bAtrasInfoCine);
            this.pInfoNuevoCine.Controls.Add(this.bAgregarNuevoCine);
            this.pInfoNuevoCine.Controls.Add(this.inputCantSalas);
            this.pInfoNuevoCine.Controls.Add(this.label6);
            this.pInfoNuevoCine.Location = new System.Drawing.Point(0, 219);
            this.pInfoNuevoCine.Name = "pInfoNuevoCine";
            this.pInfoNuevoCine.Size = new System.Drawing.Size(511, 146);
            this.pInfoNuevoCine.TabIndex = 0;
            this.pInfoNuevoCine.Visible = false;
            // 
            // bAtrasInfoCine
            // 
            this.bAtrasInfoCine.Location = new System.Drawing.Point(143, 78);
            this.bAtrasInfoCine.Name = "bAtrasInfoCine";
            this.bAtrasInfoCine.Size = new System.Drawing.Size(115, 23);
            this.bAtrasInfoCine.TabIndex = 11;
            this.bAtrasInfoCine.Text = "atrás";
            this.bAtrasInfoCine.UseVisualStyleBackColor = true;
            this.bAtrasInfoCine.Click += new System.EventHandler(this.bAtrasInfoCine_Click);
            // 
            // bAgregarNuevoCine
            // 
            this.bAgregarNuevoCine.Location = new System.Drawing.Point(281, 78);
            this.bAgregarNuevoCine.Name = "bAgregarNuevoCine";
            this.bAgregarNuevoCine.Size = new System.Drawing.Size(115, 23);
            this.bAgregarNuevoCine.TabIndex = 10;
            this.bAgregarNuevoCine.Text = "Agregar Cine";
            this.bAgregarNuevoCine.UseVisualStyleBackColor = true;
            this.bAgregarNuevoCine.Click += new System.EventHandler(this.bAgregarNuevoCine_Click);
            // 
            // inputCantSalas
            // 
            this.inputCantSalas.Location = new System.Drawing.Point(194, 22);
            this.inputCantSalas.Name = "inputCantSalas";
            this.inputCantSalas.Size = new System.Drawing.Size(213, 20);
            this.inputCantSalas.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cantidad de Salas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horario de Atención";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese los Siguientes Datos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero Identificador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Dueño";
            // 
            // input_Numero_Identificador
            // 
            this.input_Numero_Identificador.Location = new System.Drawing.Point(197, 127);
            this.input_Numero_Identificador.Name = "input_Numero_Identificador";
            this.input_Numero_Identificador.Size = new System.Drawing.Size(210, 20);
            this.input_Numero_Identificador.TabIndex = 2;
            // 
            // input_Nombre_Dueño
            // 
            this.input_Nombre_Dueño.Location = new System.Drawing.Point(197, 73);
            this.input_Nombre_Dueño.Name = "input_Nombre_Dueño";
            this.input_Nombre_Dueño.Size = new System.Drawing.Size(210, 20);
            this.input_Nombre_Dueño.TabIndex = 1;
            // 
            // bRecreacional
            // 
            this.bRecreacional.Location = new System.Drawing.Point(394, 181);
            this.bRecreacional.Name = "bRecreacional";
            this.bRecreacional.Size = new System.Drawing.Size(82, 23);
            this.bRecreacional.TabIndex = 4;
            this.bRecreacional.Text = "Recreacional";
            this.bRecreacional.UseVisualStyleBackColor = true;
            this.bRecreacional.Click += new System.EventHandler(this.bRecreacional_Click);
            // 
            // bCine
            // 
            this.bCine.Location = new System.Drawing.Point(270, 181);
            this.bCine.Name = "bCine";
            this.bCine.Size = new System.Drawing.Size(82, 23);
            this.bCine.TabIndex = 3;
            this.bCine.Text = "Cine";
            this.bCine.UseVisualStyleBackColor = true;
            this.bCine.Click += new System.EventHandler(this.bCine_Click);
            // 
            // bRestaurante
            // 
            this.bRestaurante.Location = new System.Drawing.Point(161, 181);
            this.bRestaurante.Name = "bRestaurante";
            this.bRestaurante.Size = new System.Drawing.Size(82, 23);
            this.bRestaurante.TabIndex = 2;
            this.bRestaurante.Text = "Restaurante";
            this.bRestaurante.UseVisualStyleBackColor = true;
            this.bRestaurante.Click += new System.EventHandler(this.bRestaurante_Click);
            // 
            // bTienda
            // 
            this.bTienda.Location = new System.Drawing.Point(40, 181);
            this.bTienda.Name = "bTienda";
            this.bTienda.Size = new System.Drawing.Size(82, 23);
            this.bTienda.TabIndex = 1;
            this.bTienda.Text = "Tienda";
            this.bTienda.UseVisualStyleBackColor = true;
            this.bTienda.Click += new System.EventHandler(this.bTienda_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(157, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Que Tipo de Local te Gustaria Agregar?";
            // 
            // bLista
            // 
            this.bLista.Location = new System.Drawing.Point(358, 12);
            this.bLista.Name = "bLista";
            this.bLista.Size = new System.Drawing.Size(132, 23);
            this.bLista.TabIndex = 2;
            this.bLista.Text = "Lista Locales Existentes";
            this.bLista.UseVisualStyleBackColor = true;
            this.bLista.Click += new System.EventHandler(this.bLista_Click);
            // 
            // bRevisar
            // 
            this.bRevisar.Location = new System.Drawing.Point(197, 12);
            this.bRevisar.Name = "bRevisar";
            this.bRevisar.Size = new System.Drawing.Size(132, 23);
            this.bRevisar.TabIndex = 1;
            this.bRevisar.Text = "Revisar Local Existente";
            this.bRevisar.UseVisualStyleBackColor = true;
            this.bRevisar.Click += new System.EventHandler(this.bRevisar_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(24, 12);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(132, 23);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "Agregar Nuevo Local";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // pLista
            // 
            this.pLista.Controls.Add(this.bAtrasLista);
            this.pLista.Controls.Add(this.Lista);
            this.pLista.Location = new System.Drawing.Point(0, 0);
            this.pLista.Name = "pLista";
            this.pLista.Size = new System.Drawing.Size(517, 372);
            this.pLista.TabIndex = 4;
            this.pLista.Visible = false;
            // 
            // Lista
            // 
            this.Lista.Location = new System.Drawing.Point(0, 0);
            this.Lista.Name = "Lista";
            this.Lista.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Lista.Size = new System.Drawing.Size(514, 331);
            this.Lista.TabIndex = 0;
            this.Lista.Text = "";
            // 
            // bAtrasLista
            // 
            this.bAtrasLista.Location = new System.Drawing.Point(207, 340);
            this.bAtrasLista.Name = "bAtrasLista";
            this.bAtrasLista.Size = new System.Drawing.Size(83, 23);
            this.bAtrasLista.TabIndex = 1;
            this.bAtrasLista.Text = "atrás";
            this.bAtrasLista.UseVisualStyleBackColor = true;
            this.bAtrasLista.Click += new System.EventHandler(this.bAtrasLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 375);
            this.Controls.Add(this.Principal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Principal.ResumeLayout(false);
            this.pAgregar.ResumeLayout(false);
            this.pAgregar.PerformLayout();
            this.pInfoNuevoLocal.ResumeLayout(false);
            this.pInfoNuevoLocal.PerformLayout();
            this.pInfoNuevoRecreacional.ResumeLayout(false);
            this.pInfoNuevoRestaurant.ResumeLayout(false);
            this.pInfoNuevoRestaurant.PerformLayout();
            this.pInfoNuevaTienda.ResumeLayout(false);
            this.pInfoNuevaTienda.PerformLayout();
            this.pInfoNuevoCine.ResumeLayout(false);
            this.pInfoNuevoCine.PerformLayout();
            this.pLista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Principal;
        private System.Windows.Forms.Button bLista;
        private System.Windows.Forms.Button bRevisar;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Panel pAgregar;
        private System.Windows.Forms.Button bAgregarTienda;
        private System.Windows.Forms.TextBox input_Categorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pInfoNuevoLocal;
        private System.Windows.Forms.Panel pInfoNuevaTienda;
        private System.Windows.Forms.Panel pInfoNuevoCine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox input_Horario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input_Numero_Identificador;
        private System.Windows.Forms.TextBox input_Nombre_Dueño;
        private System.Windows.Forms.Button bRecreacional;
        private System.Windows.Forms.Button bCine;
        private System.Windows.Forms.Button bRestaurante;
        private System.Windows.Forms.Button bTienda;
        private System.Windows.Forms.TextBox inputCantSalas;
        private System.Windows.Forms.Button bAgregarNuevoCine;
        private System.Windows.Forms.Button batrasTienda;
        private System.Windows.Forms.Button bAtrasInfoCine;
        private System.Windows.Forms.Panel pInfoNuevoRestaurant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputMesa;
        private System.Windows.Forms.Button bAgregarRestaurant;
        private System.Windows.Forms.Button bAtrasInfoRestaurant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pInfoNuevoRecreacional;
        private System.Windows.Forms.Button bAgregarNuevoRecreacional;
        private System.Windows.Forms.Button bAtrasInfoNuevoRecreacional;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel confirmacionAgregado;
        private System.Windows.Forms.Panel pLista;
        private System.Windows.Forms.RichTextBox Lista;
        private System.Windows.Forms.Button bAtrasLista;
    }
}