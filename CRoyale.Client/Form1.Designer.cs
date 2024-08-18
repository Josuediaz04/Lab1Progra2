namespace CRoyale.Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.carta1 = new System.Windows.Forms.PictureBox();
            this.carta2 = new System.Windows.Forms.PictureBox();
            this.carta3 = new System.Windows.Forms.PictureBox();
            this.carta4 = new System.Windows.Forms.PictureBox();
            this.carta1Contrario = new System.Windows.Forms.PictureBox();
            this.toolCard1Rival = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta1Contrario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrar.Location = new System.Drawing.Point(0, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(61, 29);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // carta1
            // 
            this.carta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta1.Location = new System.Drawing.Point(172, 526);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(75, 77);
            this.carta1.TabIndex = 1;
            this.carta1.TabStop = false;
            this.carta1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.carta1_MouseDown);
            this.carta1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.carta1_MouseMove);
            // 
            // carta2
            // 
            this.carta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta2.Location = new System.Drawing.Point(253, 526);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(75, 77);
            this.carta2.TabIndex = 2;
            this.carta2.TabStop = false;
            this.carta2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.carta2_MouseDown);
            this.carta2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.carta2_MouseMove);
            // 
            // carta3
            // 
            this.carta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta3.Location = new System.Drawing.Point(334, 526);
            this.carta3.Name = "carta3";
            this.carta3.Size = new System.Drawing.Size(75, 77);
            this.carta3.TabIndex = 3;
            this.carta3.TabStop = false;
            this.carta3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.carta3_MouseDown);
            this.carta3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.carta3_MouseMove);
            // 
            // carta4
            // 
            this.carta4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta4.Location = new System.Drawing.Point(424, 526);
            this.carta4.Name = "carta4";
            this.carta4.Size = new System.Drawing.Size(75, 77);
            this.carta4.TabIndex = 4;
            this.carta4.TabStop = false;
            this.carta4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.carta4_MouseDown);
            this.carta4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.carta4_MouseMove);
            // 
            // carta1Contrario
            // 
            this.carta1Contrario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta1Contrario.Location = new System.Drawing.Point(253, 140);
            this.carta1Contrario.Name = "carta1Contrario";
            this.carta1Contrario.Size = new System.Drawing.Size(75, 77);
            this.carta1Contrario.TabIndex = 5;
            this.carta1Contrario.TabStop = false;
            this.carta1Contrario.Click += new System.EventHandler(this.carta1Contrario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 635);
            this.Controls.Add(this.carta1Contrario);
            this.Controls.Add(this.carta4);
            this.Controls.Add(this.carta3);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta1Contrario)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox carta1;
        private System.Windows.Forms.PictureBox carta2;
        private System.Windows.Forms.PictureBox carta3;
        private System.Windows.Forms.PictureBox carta4;
        private System.Windows.Forms.PictureBox carta1Contrario;
        private System.Windows.Forms.ToolTip toolCard1Rival;
    }
}

