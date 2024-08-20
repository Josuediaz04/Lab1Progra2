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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCerrar = new System.Windows.Forms.Button();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card1Rival = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1Rival)).BeginInit();
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
            // card1
            // 
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.Location = new System.Drawing.Point(172, 526);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(75, 77);
            this.card1.TabIndex = 1;
            this.card1.TabStop = false;
            // 
            // card2
            // 
            this.card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card2.Location = new System.Drawing.Point(253, 526);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(75, 77);
            this.card2.TabIndex = 2;
            this.card2.TabStop = false;
            // 
            // card3
            // 
            this.card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card3.Location = new System.Drawing.Point(334, 526);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(75, 77);
            this.card3.TabIndex = 3;
            this.card3.TabStop = false;
            // 
            // card4
            // 
            this.card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card4.Location = new System.Drawing.Point(424, 526);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(75, 77);
            this.card4.TabIndex = 4;
            this.card4.TabStop = false;
            // 
            // card1Rival
            // 
            this.card1Rival.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1Rival.Location = new System.Drawing.Point(253, 140);
            this.card1Rival.Name = "card1Rival";
            this.card1Rival.Size = new System.Drawing.Size(75, 77);
            this.card1Rival.TabIndex = 5;
            this.card1Rival.TabStop = false;
            this.card1Rival.Click += new System.EventHandler(this.carta1Contrario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 635);
            this.Controls.Add(this.card1Rival);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1Rival)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;
        private System.Windows.Forms.PictureBox card1Rival;
    }
}

