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
            this.label1 = new System.Windows.Forms.Label();
            this.lbImagenURL = new System.Windows.Forms.Label();
            this.tbxImagenURL = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelSup.Size = new System.Drawing.Size(748, 21);
            this.panelSup.TabIndex = 4;
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(699, 3);
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
            this.PicBoxCerrar.Location = new System.Drawing.Point(720, 3);
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
            this.btAgregar.Location = new System.Drawing.Point(97, 467);
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
            this.btCancelar.Location = new System.Drawing.Point(235, 467);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(115, 37);
            this.btCancelar.TabIndex = 8;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(140, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "ALTA DE ITEM";
            // 
            // lbImagenURL
            // 
            this.lbImagenURL.AutoSize = true;
            this.lbImagenURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbImagenURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbImagenURL.Location = new System.Drawing.Point(511, 395);
            this.lbImagenURL.Name = "lbImagenURL";
            this.lbImagenURL.Size = new System.Drawing.Size(100, 17);
            this.lbImagenURL.TabIndex = 11;
            this.lbImagenURL.Text = "Imagen (URL):";
            this.lbImagenURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxImagenURL
            // 
            this.tbxImagenURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxImagenURL.Location = new System.Drawing.Point(446, 415);
            this.tbxImagenURL.MaxLength = 2000;
            this.tbxImagenURL.Name = "tbxImagenURL";
            this.tbxImagenURL.Size = new System.Drawing.Size(237, 23);
            this.tbxImagenURL.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(464, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 235);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AltaItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.CancelButton = this.btCancelar;
            this.ClientSize = new System.Drawing.Size(748, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxImagenURL);
            this.Controls.Add(this.lbImagenURL);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbImagenURL;
        private System.Windows.Forms.TextBox tbxImagenURL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}