
namespace Arreglos
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
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonProm1 = new System.Windows.Forms.Button();
            this.buttonPromIII = new System.Windows.Forms.Button();
            this.buttonPromII = new System.Windows.Forms.Button();
            this.buttonPromI = new System.Windows.Forms.Button();
            this.buttonPromAlum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSumatoria = new System.Windows.Forms.Button();
            this.listBoxNom = new System.Windows.Forms.ListBox();
            this.buttonProGene = new System.Windows.Forms.Button();
            this.buttonPromSecI = new System.Windows.Forms.Button();
            this.buttonPromSecIII = new System.Windows.Forms.Button();
            this.buttonPromSecII = new System.Windows.Forms.Button();
            this.buttonClasificAlumxSec = new System.Windows.Forms.Button();
            this.textBoxSec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxResultado.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 15;
            this.listBoxResultado.Location = new System.Drawing.Point(23, 230);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(395, 394);
            this.listBoxResultado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonCargar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargar.ForeColor = System.Drawing.Color.White;
            this.buttonCargar.Location = new System.Drawing.Point(23, 27);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(128, 52);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = false;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonNombres
            // 
            this.buttonNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonNombres.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNombres.ForeColor = System.Drawing.Color.White;
            this.buttonNombres.Location = new System.Drawing.Point(167, 27);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(106, 52);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Ordenar Nombres";
            this.buttonNombres.UseVisualStyleBackColor = false;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonProm1
            // 
            this.buttonProm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonProm1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProm1.ForeColor = System.Drawing.Color.White;
            this.buttonProm1.Location = new System.Drawing.Point(542, 259);
            this.buttonProm1.Name = "buttonProm1";
            this.buttonProm1.Size = new System.Drawing.Size(87, 41);
            this.buttonProm1.TabIndex = 5;
            this.buttonProm1.Text = "Maximos y Minimos";
            this.buttonProm1.UseVisualStyleBackColor = false;
            this.buttonProm1.Click += new System.EventHandler(this.buttonProm1_Click);
            // 
            // buttonPromIII
            // 
            this.buttonPromIII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonPromIII.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromIII.ForeColor = System.Drawing.Color.White;
            this.buttonPromIII.Location = new System.Drawing.Point(729, 221);
            this.buttonPromIII.Name = "buttonPromIII";
            this.buttonPromIII.Size = new System.Drawing.Size(87, 32);
            this.buttonPromIII.TabIndex = 14;
            this.buttonPromIII.Text = "Parcial III";
            this.buttonPromIII.UseVisualStyleBackColor = false;
            this.buttonPromIII.Click += new System.EventHandler(this.buttonPromIII_Click);
            // 
            // buttonPromII
            // 
            this.buttonPromII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonPromII.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromII.ForeColor = System.Drawing.Color.White;
            this.buttonPromII.Location = new System.Drawing.Point(636, 221);
            this.buttonPromII.Name = "buttonPromII";
            this.buttonPromII.Size = new System.Drawing.Size(87, 32);
            this.buttonPromII.TabIndex = 13;
            this.buttonPromII.Text = "Parcial II";
            this.buttonPromII.UseVisualStyleBackColor = false;
            this.buttonPromII.Click += new System.EventHandler(this.buttonPromII_Click);
            // 
            // buttonPromI
            // 
            this.buttonPromI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonPromI.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromI.ForeColor = System.Drawing.Color.White;
            this.buttonPromI.Location = new System.Drawing.Point(542, 221);
            this.buttonPromI.Name = "buttonPromI";
            this.buttonPromI.Size = new System.Drawing.Size(87, 32);
            this.buttonPromI.TabIndex = 12;
            this.buttonPromI.Text = "Parcial I";
            this.buttonPromI.UseVisualStyleBackColor = false;
            this.buttonPromI.Click += new System.EventHandler(this.buttonPromI_Click);
            // 
            // buttonPromAlum
            // 
            this.buttonPromAlum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonPromAlum.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromAlum.ForeColor = System.Drawing.Color.White;
            this.buttonPromAlum.Location = new System.Drawing.Point(449, 221);
            this.buttonPromAlum.Name = "buttonPromAlum";
            this.buttonPromAlum.Size = new System.Drawing.Size(87, 32);
            this.buttonPromAlum.TabIndex = 10;
            this.buttonPromAlum.Text = "Alumno";
            this.buttonPromAlum.UseVisualStyleBackColor = false;
            this.buttonPromAlum.Click += new System.EventHandler(this.buttonPromAlum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(443, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Promedios por:";
            // 
            // buttonSumatoria
            // 
            this.buttonSumatoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonSumatoria.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSumatoria.ForeColor = System.Drawing.Color.White;
            this.buttonSumatoria.Location = new System.Drawing.Point(449, 259);
            this.buttonSumatoria.Name = "buttonSumatoria";
            this.buttonSumatoria.Size = new System.Drawing.Size(87, 41);
            this.buttonSumatoria.TabIndex = 16;
            this.buttonSumatoria.Text = "Sumatoria Alumnos";
            this.buttonSumatoria.UseVisualStyleBackColor = false;
            this.buttonSumatoria.Click += new System.EventHandler(this.buttonSumatoria_Click);
            // 
            // listBoxNom
            // 
            this.listBoxNom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxNom.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNom.FormattingEnabled = true;
            this.listBoxNom.ItemHeight = 15;
            this.listBoxNom.Location = new System.Drawing.Point(23, 85);
            this.listBoxNom.Name = "listBoxNom";
            this.listBoxNom.Size = new System.Drawing.Size(395, 124);
            this.listBoxNom.TabIndex = 17;
            // 
            // buttonProGene
            // 
            this.buttonProGene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonProGene.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProGene.ForeColor = System.Drawing.Color.White;
            this.buttonProGene.Location = new System.Drawing.Point(447, 405);
            this.buttonProGene.Name = "buttonProGene";
            this.buttonProGene.Size = new System.Drawing.Size(87, 32);
            this.buttonProGene.TabIndex = 18;
            this.buttonProGene.Text = "General";
            this.buttonProGene.UseVisualStyleBackColor = false;
            this.buttonProGene.Click += new System.EventHandler(this.buttonProGene_Click);
            // 
            // buttonPromSecI
            // 
            this.buttonPromSecI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonPromSecI.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromSecI.ForeColor = System.Drawing.Color.White;
            this.buttonPromSecI.Location = new System.Drawing.Point(540, 405);
            this.buttonPromSecI.Name = "buttonPromSecI";
            this.buttonPromSecI.Size = new System.Drawing.Size(87, 32);
            this.buttonPromSecI.TabIndex = 19;
            this.buttonPromSecI.Text = "Parcial I";
            this.buttonPromSecI.UseVisualStyleBackColor = false;
            this.buttonPromSecI.Click += new System.EventHandler(this.buttonPromSecI_Click);
            // 
            // buttonPromSecIII
            // 
            this.buttonPromSecIII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonPromSecIII.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromSecIII.ForeColor = System.Drawing.Color.White;
            this.buttonPromSecIII.Location = new System.Drawing.Point(725, 405);
            this.buttonPromSecIII.Name = "buttonPromSecIII";
            this.buttonPromSecIII.Size = new System.Drawing.Size(87, 32);
            this.buttonPromSecIII.TabIndex = 21;
            this.buttonPromSecIII.Text = "Parcial III";
            this.buttonPromSecIII.UseVisualStyleBackColor = false;
            this.buttonPromSecIII.Click += new System.EventHandler(this.buttonPromSecIII_Click);
            // 
            // buttonPromSecII
            // 
            this.buttonPromSecII.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonPromSecII.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromSecII.ForeColor = System.Drawing.Color.White;
            this.buttonPromSecII.Location = new System.Drawing.Point(632, 405);
            this.buttonPromSecII.Name = "buttonPromSecII";
            this.buttonPromSecII.Size = new System.Drawing.Size(87, 32);
            this.buttonPromSecII.TabIndex = 20;
            this.buttonPromSecII.Text = "Parcial II";
            this.buttonPromSecII.UseVisualStyleBackColor = false;
            this.buttonPromSecII.Click += new System.EventHandler(this.buttonPromSecII_Click);
            // 
            // buttonClasificAlumxSec
            // 
            this.buttonClasificAlumxSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.buttonClasificAlumxSec.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClasificAlumxSec.ForeColor = System.Drawing.Color.White;
            this.buttonClasificAlumxSec.Location = new System.Drawing.Point(449, 455);
            this.buttonClasificAlumxSec.Name = "buttonClasificAlumxSec";
            this.buttonClasificAlumxSec.Size = new System.Drawing.Size(129, 53);
            this.buttonClasificAlumxSec.TabIndex = 22;
            this.buttonClasificAlumxSec.Text = "Clasificar alumno por Seccion";
            this.buttonClasificAlumxSec.UseVisualStyleBackColor = false;
            this.buttonClasificAlumxSec.Click += new System.EventHandler(this.buttonClasificAlumxSec_Click);
            // 
            // textBoxSec
            // 
            this.textBoxSec.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSec.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSec.Location = new System.Drawing.Point(447, 361);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(293, 23);
            this.textBoxSec.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(445, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ingrese una seccion:";
            // 
            // listBoxDatos
            // 
            this.listBoxDatos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxDatos.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDatos.FormattingEnabled = true;
            this.listBoxDatos.ItemHeight = 15;
            this.listBoxDatos.Location = new System.Drawing.Point(448, 85);
            this.listBoxDatos.Name = "listBoxDatos";
            this.listBoxDatos.Size = new System.Drawing.Size(419, 79);
            this.listBoxDatos.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(897, 657);
            this.Controls.Add(this.listBoxDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSec);
            this.Controls.Add(this.buttonClasificAlumxSec);
            this.Controls.Add(this.buttonPromSecIII);
            this.Controls.Add(this.buttonPromSecII);
            this.Controls.Add(this.buttonPromSecI);
            this.Controls.Add(this.buttonProGene);
            this.Controls.Add(this.listBoxNom);
            this.Controls.Add(this.buttonSumatoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPromIII);
            this.Controls.Add(this.buttonPromII);
            this.Controls.Add(this.buttonPromI);
            this.Controls.Add(this.buttonPromAlum);
            this.Controls.Add(this.buttonProm1);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonProm1;
        private System.Windows.Forms.Button buttonPromIII;
        private System.Windows.Forms.Button buttonPromII;
        private System.Windows.Forms.Button buttonPromI;
        private System.Windows.Forms.Button buttonPromAlum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSumatoria;
        private System.Windows.Forms.ListBox listBoxNom;
        private System.Windows.Forms.Button buttonProGene;
        private System.Windows.Forms.Button buttonPromSecI;
        private System.Windows.Forms.Button buttonPromSecIII;
        private System.Windows.Forms.Button buttonPromSecII;
        private System.Windows.Forms.Button buttonClasificAlumxSec;
        private System.Windows.Forms.TextBox textBoxSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDatos;
    }
}

