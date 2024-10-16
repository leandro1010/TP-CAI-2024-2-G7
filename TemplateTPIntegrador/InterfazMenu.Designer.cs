namespace Presentacion
{
    partial class InterfazMenu
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
            this.UsuariosTexto = new System.Windows.Forms.Label();
            this.ProveedoresTexto = new System.Windows.Forms.Label();
            this.ClientesTexto = new System.Windows.Forms.Label();
            this.ProductosTexto = new System.Windows.Forms.Label();
            this.ReportesTexto = new System.Windows.Forms.Label();
            this.VentasTexto = new System.Windows.Forms.Label();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.ProductosIcono = new System.Windows.Forms.PictureBox();
            this.VentasIcono = new System.Windows.Forms.PictureBox();
            this.ReportesIcono = new System.Windows.Forms.PictureBox();
            this.ClientesIcono = new System.Windows.Forms.PictureBox();
            this.ProveedoresIcono = new System.Windows.Forms.PictureBox();
            this.UsuariosIcono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosTexto
            // 
            this.UsuariosTexto.AutoSize = true;
            this.UsuariosTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosTexto.Font = new System.Drawing.Font("Nunito", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuariosTexto.Location = new System.Drawing.Point(109, 284);
            this.UsuariosTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsuariosTexto.Name = "UsuariosTexto";
            this.UsuariosTexto.Size = new System.Drawing.Size(150, 43);
            this.UsuariosTexto.TabIndex = 0;
            this.UsuariosTexto.Text = "Usuarios";
            this.UsuariosTexto.Click += new System.EventHandler(this.UsuariosIcono_Click);
            
            // BotonSalir
            // 
            this.BotonSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BotonSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.BotonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.BotonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.BotonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSalir.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSalir.Location = new System.Drawing.Point(1134, 685);
            this.BotonSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(183, 49);
            this.BotonSalir.TabIndex = 6;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = false;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            
            // 
            // UsuariosIcono
            // 
            this.UsuariosIcono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsuariosIcono.Image = global::Presentacion.Properties.Resources.grupo;
            this.UsuariosIcono.Location = new System.Drawing.Point(54, 81);
            this.UsuariosIcono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UsuariosIcono.Name = "UsuariosIcono";
            this.UsuariosIcono.Size = new System.Drawing.Size(260, 200);
            this.UsuariosIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UsuariosIcono.TabIndex = 7;
            this.UsuariosIcono.TabStop = false;
            this.UsuariosIcono.Click += new System.EventHandler(this.UsuariosIcono_Click);
            // 
            // InterfazMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.ProductosIcono);
            this.Controls.Add(this.VentasIcono);
            this.Controls.Add(this.ReportesIcono);
            this.Controls.Add(this.ClientesIcono);
            this.Controls.Add(this.ProveedoresIcono);
            this.Controls.Add(this.UsuariosIcono);
            this.Controls.Add(this.VentasTexto);
            this.Controls.Add(this.ReportesTexto);
            this.Controls.Add(this.ProductosTexto);
            this.Controls.Add(this.ClientesTexto);
            this.Controls.Add(this.ProveedoresTexto);
            this.Controls.Add(this.UsuariosTexto);
            this.Controls.Add(this.BotonSalir);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "InterfazMenu";
            this.Text = "Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportesIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuariosTexto;
        private System.Windows.Forms.Label ProveedoresTexto;
        private System.Windows.Forms.Label ClientesTexto;
        private System.Windows.Forms.Label ProductosTexto;
        private System.Windows.Forms.Label ReportesTexto;
        private System.Windows.Forms.Label VentasTexto;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.PictureBox UsuariosIcono;
        private System.Windows.Forms.PictureBox ProveedoresIcono;
        private System.Windows.Forms.PictureBox ClientesIcono;
        private System.Windows.Forms.PictureBox ReportesIcono;
        private System.Windows.Forms.PictureBox VentasIcono;
        private System.Windows.Forms.PictureBox ProductosIcono;
    }
}