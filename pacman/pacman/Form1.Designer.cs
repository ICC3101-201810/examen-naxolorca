namespace pacman
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
            this.components = new System.ComponentModel.Container();
            this.ciclo = new System.Windows.Forms.Timer(this.components);
            this.pictureJuego = new System.Windows.Forms.PictureBox();
            this.puntaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uvaesta = new System.Windows.Forms.Timer(this.components);
            this.cherryesta = new System.Windows.Forms.Timer(this.components);
            this.uvanoesta = new System.Windows.Forms.Timer(this.components);
            this.cherrynoesta = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // ciclo
            // 
            this.ciclo.Enabled = true;
            this.ciclo.Tick += new System.EventHandler(this.ciclo_Tick);
            // 
            // pictureJuego
            // 
            this.pictureJuego.BackColor = System.Drawing.Color.White;
            this.pictureJuego.Image = global::pacman.Properties.Resources.cherry;
            this.pictureJuego.Location = new System.Drawing.Point(10, 12);
            this.pictureJuego.Name = "pictureJuego";
            this.pictureJuego.Size = new System.Drawing.Size(870, 470);
            this.pictureJuego.TabIndex = 0;
            this.pictureJuego.TabStop = false;
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.Location = new System.Drawing.Point(204, 504);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(35, 13);
            this.puntaje.TabIndex = 1;
            this.puntaje.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puntaje :";
            // 
            // uvaesta
            // 
            this.uvaesta.Interval = 10000;
            this.uvaesta.Tick += new System.EventHandler(this.uvaesta_Tick);
            // 
            // cherryesta
            // 
            this.cherryesta.Interval = 10000;
            this.cherryesta.Tick += new System.EventHandler(this.cherryesta_Tick);
            // 
            // uvanoesta
            // 
            this.uvanoesta.Enabled = true;
            this.uvanoesta.Interval = 30000;
            this.uvanoesta.Tick += new System.EventHandler(this.uvanoesta_Tick);
            // 
            // cherrynoesta
            // 
            this.cherrynoesta.Enabled = true;
            this.cherrynoesta.Interval = 30000;
            this.cherrynoesta.Tick += new System.EventHandler(this.cherrynoesta_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.pictureJuego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ciclo;
        private System.Windows.Forms.PictureBox pictureJuego;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer uvaesta;
        private System.Windows.Forms.Timer cherryesta;
        private System.Windows.Forms.Timer uvanoesta;
        private System.Windows.Forms.Timer cherrynoesta;
    }
}

