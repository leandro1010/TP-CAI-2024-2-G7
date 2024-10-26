﻿namespace Presentacion
{
    partial class Ventana
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
            System.Windows.Forms.Panel BarraVentana;
            this.label2 = new System.Windows.Forms.Label();
            this.Boton_Minimizar = new System.Windows.Forms.PictureBox();
            this.Boton_Cerrar = new System.Windows.Forms.PictureBox();
            BarraVentana = new System.Windows.Forms.Panel();
            BarraVentana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraVentana
            // 
            BarraVentana.BackColor = System.Drawing.Color.Purple;
            BarraVentana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            BarraVentana.Controls.Add(this.label2);
            BarraVentana.Controls.Add(this.Boton_Minimizar);
            BarraVentana.Controls.Add(this.Boton_Cerrar);
            BarraVentana.Cursor = System.Windows.Forms.Cursors.Default;
            BarraVentana.Dock = System.Windows.Forms.DockStyle.Top;
            BarraVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BarraVentana.Location = new System.Drawing.Point(0, 0);
            BarraVentana.Name = "BarraVentana";
            BarraVentana.Size = new System.Drawing.Size(1366, 38);
            BarraVentana.TabIndex = 0;
            BarraVentana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloForm_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 31);
            this.label2.TabIndex = 1;
            // 
            // Boton_Minimizar
            // 
            this.Boton_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Boton_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Minimizar.Image = global::Presentacion.Properties.Resources.BotonMinimizar;
            this.Boton_Minimizar.Location = new System.Drawing.Point(1285, -1);
            this.Boton_Minimizar.Name = "Boton_Minimizar";
            this.Boton_Minimizar.Size = new System.Drawing.Size(35, 38);
            this.Boton_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boton_Minimizar.TabIndex = 2;
            this.Boton_Minimizar.TabStop = false;
            this.Boton_Minimizar.Click += new System.EventHandler(this.Boton_Minimizar_Click);
            // 
            // Boton_Cerrar
            // 
            this.Boton_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Boton_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_Cerrar.Image = global::Presentacion.Properties.Resources.CerrarVentana;
            this.Boton_Cerrar.Location = new System.Drawing.Point(1326, -1);
            this.Boton_Cerrar.Name = "Boton_Cerrar";
            this.Boton_Cerrar.Size = new System.Drawing.Size(35, 38);
            this.Boton_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boton_Cerrar.TabIndex = 2;
            this.Boton_Cerrar.TabStop = false;
            this.Boton_Cerrar.Click += new System.EventHandler(this.Boton_Cerrar_Click);
            // 
            // Ventana
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(BarraVentana);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ventana";
            this.Text = "Ventana";
            BarraVentana.ResumeLayout(false);
            BarraVentana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boton_Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Boton_Cerrar;
        private System.Windows.Forms.PictureBox Boton_Minimizar;
        private System.Windows.Forms.Label label2;
    }
}