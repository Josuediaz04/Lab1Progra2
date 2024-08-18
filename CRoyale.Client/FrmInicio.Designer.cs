namespace CRoyale.Client
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.btnIniciarBatalla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciarBatalla
            // 
            this.btnIniciarBatalla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarBatalla.BackgroundImage")));
            this.btnIniciarBatalla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarBatalla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciarBatalla.Location = new System.Drawing.Point(137, 310);
            this.btnIniciarBatalla.Name = "btnIniciarBatalla";
            this.btnIniciarBatalla.Size = new System.Drawing.Size(140, 79);
            this.btnIniciarBatalla.TabIndex = 0;
            this.btnIniciarBatalla.Text = "Iniciar batalla";
            this.btnIniciarBatalla.UseVisualStyleBackColor = true;
            this.btnIniciarBatalla.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 427);
            this.Controls.Add(this.btnIniciarBatalla);
            this.Name = "FrmInicio";
            this.Text = "Lab1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarBatalla;
    }
}