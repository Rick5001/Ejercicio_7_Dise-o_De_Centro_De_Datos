
namespace Ejercicio_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FechaInicial = new System.Windows.Forms.Label();
            this.FechaFinal = new System.Windows.Forms.Label();
            this.dtpFecha_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Final = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaInicial
            // 
            this.FechaInicial.AutoSize = true;
            this.FechaInicial.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicial.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FechaInicial.Location = new System.Drawing.Point(157, 233);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(130, 22);
            this.FechaInicial.TabIndex = 0;
            this.FechaInicial.Text = "FECHA INICIAL";
            // 
            // FechaFinal
            // 
            this.FechaFinal.AutoSize = true;
            this.FechaFinal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FechaFinal.Location = new System.Drawing.Point(484, 233);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(118, 22);
            this.FechaFinal.TabIndex = 1;
            this.FechaFinal.Text = "FECHA FINAL";
            // 
            // dtpFecha_Inicial
            // 
            this.dtpFecha_Inicial.Location = new System.Drawing.Point(125, 281);
            this.dtpFecha_Inicial.Name = "dtpFecha_Inicial";
            this.dtpFecha_Inicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Inicial.TabIndex = 2;
            // 
            // dtpFecha_Final
            // 
            this.dtpFecha_Final.Location = new System.Drawing.Point(434, 281);
            this.dtpFecha_Final.Name = "dtpFecha_Final";
            this.dtpFecha_Final.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Final.TabIndex = 3;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Lime;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVer.Location = new System.Drawing.Point(141, 339);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(162, 57);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Generar Reporte";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(463, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio_7.Properties.Resources._cb29f686_2eef_467c_a019_d5a802f6824a__1_;
            this.pictureBox1.Location = new System.Drawing.Point(45, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 211);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dtpFecha_Final);
            this.Controls.Add(this.dtpFecha_Inicial);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.FechaInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reporte de mi tienda RRM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FechaInicial;
        private System.Windows.Forms.Label FechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFecha_Inicial;
        private System.Windows.Forms.DateTimePicker dtpFecha_Final;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

