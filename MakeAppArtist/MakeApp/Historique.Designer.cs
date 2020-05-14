namespace MakeApp
{
    partial class Historique
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeur = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblHeur);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.gunaTransfarantPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 97);
            this.panel1.TabIndex = 0;
            // 
            // lblHeur
            // 
            this.lblHeur.AutoSize = true;
            this.lblHeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblHeur.Location = new System.Drawing.Point(112, 67);
            this.lblHeur.Name = "lblHeur";
            this.lblHeur.Size = new System.Drawing.Size(76, 21);
            this.lblHeur.TabIndex = 23;
            this.lblHeur.Text = "HeurRdv";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblDate.Location = new System.Drawing.Point(111, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 21);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "DateRdv";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblName.Location = new System.Drawing.Point(111, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 32);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Nom Prenom";
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaTransfarantPictureBox1.Image = global::MakeApp.Properties.Resources.DefaultWomenPic;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(97, 97);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 19;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "Historique";
            this.Size = new System.Drawing.Size(507, 109);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaLabel lblHeur;
        public Guna.UI.WinForms.GunaLabel lblDate;
        public Guna.UI.WinForms.GunaLabel lblName;
        public Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
    }
}
