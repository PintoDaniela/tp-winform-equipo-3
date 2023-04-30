﻿namespace PresentacionForms
{
    partial class AltaItemsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaItemsForm));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.panelSup = new System.Windows.Forms.Panel();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.PicBoxCerrar = new System.Windows.Forms.PictureBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lbMarca = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbImagenURL = new System.Windows.Forms.Label();
            this.txbImagenURL = new System.Windows.Forms.TextBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.lbxURL = new System.Windows.Forms.ListBox();
            this.menuURL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddImg = new System.Windows.Forms.Button();
            this.panelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.menuURL.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(30, 169);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(62, 17);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDescripcion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDescripcion.Location = new System.Drawing.Point(30, 360);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lbDescripcion.TabIndex = 1;
            this.lbDescripcion.Text = "Descripcion:";
            this.lbDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrecio.Location = new System.Drawing.Point(30, 213);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(52, 17);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "Precio:";
            this.lbPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbNombre.Location = new System.Drawing.Point(136, 168);
            this.txbNombre.MaxLength = 20;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(162, 23);
            this.txbNombre.TabIndex = 1;
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbDescripcion.Location = new System.Drawing.Point(136, 357);
            this.txbDescripcion.MaxLength = 30;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(237, 23);
            this.txbDescripcion.TabIndex = 5;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbPrecio.Location = new System.Drawing.Point(136, 210);
            this.txbPrecio.MaxLength = 20;
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(162, 23);
            this.txbPrecio.TabIndex = 2;
            // 
            // panelSup
            // 
            this.panelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.panelSup.Controls.Add(this.picBoxMinimizar);
            this.panelSup.Controls.Add(this.PicBoxCerrar);
            this.panelSup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSup.Location = new System.Drawing.Point(0, 0);
            this.panelSup.Name = "panelSup";
            this.panelSup.Size = new System.Drawing.Size(771, 21);
            this.panelSup.TabIndex = 4;
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(722, 3);
            this.picBoxMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Size = new System.Drawing.Size(17, 16);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMinimizar.TabIndex = 2;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // PicBoxCerrar
            // 
            this.PicBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("PicBoxCerrar.Image")));
            this.PicBoxCerrar.Location = new System.Drawing.Point(743, 3);
            this.PicBoxCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.PicBoxCerrar.Name = "PicBoxCerrar";
            this.PicBoxCerrar.Size = new System.Drawing.Size(17, 16);
            this.PicBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxCerrar.TabIndex = 4;
            this.PicBoxCerrar.TabStop = false;
            this.PicBoxCerrar.Click += new System.EventHandler(this.PicBoxCerrar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.Location = new System.Drawing.Point(97, 514);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(115, 37);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMarca.Location = new System.Drawing.Point(30, 259);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(55, 17);
            this.lbMarca.TabIndex = 6;
            this.lbMarca.Text = "Marca :";
            this.lbMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.IntegralHeight = false;
            this.cbxMarca.Location = new System.Drawing.Point(136, 256);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(162, 24);
            this.cbxMarca.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.IntegralHeight = false;
            this.cbxCategoria.Location = new System.Drawing.Point(136, 306);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(162, 24);
            this.cbxCategoria.TabIndex = 4;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCategoria.Location = new System.Drawing.Point(30, 309);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(73, 17);
            this.lbCategoria.TabIndex = 8;
            this.lbCategoria.Text = "Categoria:";
            this.lbCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Location = new System.Drawing.Point(235, 514);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 37);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitulo.Location = new System.Drawing.Point(140, 97);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(147, 30);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "ALTA DE ITEM";
            // 
            // lbImagenURL
            // 
            this.lbImagenURL.AutoSize = true;
            this.lbImagenURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbImagenURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbImagenURL.Location = new System.Drawing.Point(496, 392);
            this.lbImagenURL.Name = "lbImagenURL";
            this.lbImagenURL.Size = new System.Drawing.Size(100, 17);
            this.lbImagenURL.TabIndex = 11;
            this.lbImagenURL.Text = "Imagen (URL):";
            this.lbImagenURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbImagenURL
            // 
            this.txbImagenURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbImagenURL.Location = new System.Drawing.Point(431, 412);
            this.txbImagenURL.MaxLength = 2000;
            this.txbImagenURL.Name = "txbImagenURL";
            this.txbImagenURL.Size = new System.Drawing.Size(237, 23);
            this.txbImagenURL.TabIndex = 6;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(464, 142);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(204, 235);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 12;
            this.pbImagen.TabStop = false;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCodigo.Location = new System.Drawing.Point(30, 415);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(56, 17);
            this.lbCodigo.TabIndex = 13;
            this.lbCodigo.Text = "Codigo:";
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbCodigo.Location = new System.Drawing.Point(136, 412);
            this.txbCodigo.MaxLength = 20;
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(162, 23);
            this.txbCodigo.TabIndex = 14;
            // 
            // lbxURL
            // 
            this.lbxURL.ContextMenuStrip = this.menuURL;
            this.lbxURL.FormattingEnabled = true;
            this.lbxURL.Location = new System.Drawing.Point(431, 475);
            this.lbxURL.Name = "lbxURL";
            this.lbxURL.Size = new System.Drawing.Size(248, 95);
            this.lbxURL.TabIndex = 15;
            this.lbxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxURL_KeyDown);
            // 
            // menuURL
            // 
            this.menuURL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarImagenToolStripMenuItem});
            this.menuURL.Name = "menuURL";
            this.menuURL.Size = new System.Drawing.Size(161, 26);
            // 
            // eliminarImagenToolStripMenuItem
            // 
            this.eliminarImagenToolStripMenuItem.Name = "eliminarImagenToolStripMenuItem";
            this.eliminarImagenToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.eliminarImagenToolStripMenuItem.Text = "Eliminar imagen";
            this.eliminarImagenToolStripMenuItem.Click += new System.EventHandler(this.eliminarImagenToolStripMenuItem_Click);
            // 
            // btAddImg
            // 
            this.btAddImg.Location = new System.Drawing.Point(674, 410);
            this.btAddImg.Name = "btAddImg";
            this.btAddImg.Size = new System.Drawing.Size(39, 26);
            this.btAddImg.TabIndex = 16;
            this.btAddImg.Text = "+";
            this.btAddImg.UseVisualStyleBackColor = true;
            this.btAddImg.Click += new System.EventHandler(this.btAddImg_Click);
            // 
            // AltaItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(771, 654);
            this.Controls.Add(this.btAddImg);
            this.Controls.Add(this.lbxURL);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.txbImagenURL);
            this.Controls.Add(this.lbImagenURL);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.panelSup);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.lbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(25, 0);
            this.MaximizeBox = false;
            this.Name = "AltaItemsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Item";
            this.TopMost = true;
            this.panelSup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.menuURL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Panel panelSup;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.PictureBox PicBoxCerrar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbImagenURL;
        private System.Windows.Forms.TextBox txbImagenURL;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.ListBox lbxURL;
        private System.Windows.Forms.Button btAddImg;
        private System.Windows.Forms.ContextMenuStrip menuURL;
        private System.Windows.Forms.ToolStripMenuItem eliminarImagenToolStripMenuItem;
    }
}