namespace D3.Autocasteos
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.cboHabilidad1 = new System.Windows.Forms.CheckBox();
            this.cboHabilidad2 = new System.Windows.Forms.CheckBox();
            this.cboHabilidad3 = new System.Windows.Forms.CheckBox();
            this.cboHabilidad4 = new System.Windows.Forms.CheckBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblAutoCasteando = new System.Windows.Forms.Label();
            this.lblPausado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboHabilidad1
            // 
            this.cboHabilidad1.AutoSize = true;
            this.cboHabilidad1.Location = new System.Drawing.Point(98, 49);
            this.cboHabilidad1.Name = "cboHabilidad1";
            this.cboHabilidad1.Size = new System.Drawing.Size(15, 14);
            this.cboHabilidad1.TabIndex = 5;
            this.cboHabilidad1.UseVisualStyleBackColor = true;
            // 
            // cboHabilidad2
            // 
            this.cboHabilidad2.AutoSize = true;
            this.cboHabilidad2.Location = new System.Drawing.Point(98, 72);
            this.cboHabilidad2.Name = "cboHabilidad2";
            this.cboHabilidad2.Size = new System.Drawing.Size(15, 14);
            this.cboHabilidad2.TabIndex = 6;
            this.cboHabilidad2.UseVisualStyleBackColor = true;
            // 
            // cboHabilidad3
            // 
            this.cboHabilidad3.AutoSize = true;
            this.cboHabilidad3.Location = new System.Drawing.Point(98, 95);
            this.cboHabilidad3.Name = "cboHabilidad3";
            this.cboHabilidad3.Size = new System.Drawing.Size(15, 14);
            this.cboHabilidad3.TabIndex = 7;
            this.cboHabilidad3.UseVisualStyleBackColor = true;
            // 
            // cboHabilidad4
            // 
            this.cboHabilidad4.AutoSize = true;
            this.cboHabilidad4.Location = new System.Drawing.Point(98, 118);
            this.cboHabilidad4.Name = "cboHabilidad4";
            this.cboHabilidad4.Size = new System.Drawing.Size(15, 14);
            this.cboHabilidad4.TabIndex = 8;
            this.cboHabilidad4.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(13, 142);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(335, 23);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar (F5)";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.Maroon;
            this.btnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.White;
            this.btnDetener.Location = new System.Drawing.Point(13, 172);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(335, 23);
            this.btnDetener.TabIndex = 10;
            this.btnDetener.Text = "Detener (F4)";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::D3.Autocasteos.Properties.Resources.d3;
            this.pictureBox1.Location = new System.Drawing.Point(245, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Habilidad 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Habilidad 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Habilidad 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Habilidad 4";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Green;
            this.pnlStatus.Controls.Add(this.lblPausado);
            this.pnlStatus.Controls.Add(this.lblAutoCasteando);
            this.pnlStatus.Location = new System.Drawing.Point(13, 12);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(335, 24);
            this.pnlStatus.TabIndex = 16;
            // 
            // lblAutoCasteando
            // 
            this.lblAutoCasteando.AutoSize = true;
            this.lblAutoCasteando.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoCasteando.Location = new System.Drawing.Point(93, 3);
            this.lblAutoCasteando.Name = "lblAutoCasteando";
            this.lblAutoCasteando.Size = new System.Drawing.Size(145, 17);
            this.lblAutoCasteando.TabIndex = 0;
            this.lblAutoCasteando.Text = "AUTOCASTEANDO";
            // 
            // lblPausado
            // 
            this.lblPausado.AutoSize = true;
            this.lblPausado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPausado.Location = new System.Drawing.Point(122, 3);
            this.lblPausado.Name = "lblPausado";
            this.lblPausado.Size = new System.Drawing.Size(82, 17);
            this.lblPausado.TabIndex = 1;
            this.lblPausado.Text = "PAUSADO";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(360, 203);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cboHabilidad4);
            this.Controls.Add(this.cboHabilidad3);
            this.Controls.Add(this.cboHabilidad2);
            this.Controls.Add(this.cboHabilidad1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "D3 Autocasteos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cboHabilidad1;
        private System.Windows.Forms.CheckBox cboHabilidad2;
        private System.Windows.Forms.CheckBox cboHabilidad3;
        private System.Windows.Forms.CheckBox cboHabilidad4;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblPausado;
        private System.Windows.Forms.Label lblAutoCasteando;
    }
}

