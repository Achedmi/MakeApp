namespace MakeApp
{
    partial class RDV
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.BtnPrendre = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this.gunaPanel1;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.BtnPrendre);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaTransfarantPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(832, 172);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.gunaLabel5.Location = new System.Drawing.Point(194, 100);
            this.gunaLabel5.MaximumSize = new System.Drawing.Size(400, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(127, 21);
            this.gunaLabel5.TabIndex = 18;
            this.gunaLabel5.Text = "DescriptionRdv";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.gunaLabel6.Location = new System.Drawing.Point(194, 76);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel6.TabIndex = 17;
            this.gunaLabel6.Text = "HeurRdv";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.gunaLabel7.Location = new System.Drawing.Point(194, 53);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(75, 21);
            this.gunaLabel7.TabIndex = 16;
            this.gunaLabel7.Text = "DateRdv";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.gunaLabel4.Location = new System.Drawing.Point(578, 100);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(69, 21);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Adresse";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.gunaLabel3.Location = new System.Drawing.Point(578, 53);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(124, 21);
            this.gunaLabel3.TabIndex = 13;
            this.gunaLabel3.Text = "Date naissance";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.gunaLabel2.Location = new System.Drawing.Point(578, 76);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(80, 21);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "TEl client";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.gunaLabel1.Location = new System.Drawing.Point(192, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(168, 32);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Nom Prenom";
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaTransfarantPictureBox1.Image = global::MakeApp.Properties.Resources.DefaultWomenPic;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(159, 172);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 10;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // BtnPrendre
            // 
            this.BtnPrendre.Animated = true;
            this.BtnPrendre.AnimationHoverSpeed = 0.07F;
            this.BtnPrendre.AnimationSpeed = 0.03F;
            this.BtnPrendre.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrendre.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(223)))));
            this.BtnPrendre.BorderColor = System.Drawing.Color.Black;
            this.BtnPrendre.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnPrendre.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnPrendre.CheckedForeColor = System.Drawing.Color.White;
            this.BtnPrendre.CheckedImage = null;
            this.BtnPrendre.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnPrendre.FocusedColor = System.Drawing.Color.Empty;
            this.BtnPrendre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrendre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.BtnPrendre.Image = null;
            this.BtnPrendre.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnPrendre.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPrendre.Location = new System.Drawing.Point(697, 129);
            this.BtnPrendre.Name = "BtnPrendre";
            this.BtnPrendre.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(204)))), ((int)(((byte)(223)))));
            this.BtnPrendre.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnPrendre.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnPrendre.OnHoverImage = null;
            this.BtnPrendre.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnPrendre.OnPressedColor = System.Drawing.Color.Black;
            this.BtnPrendre.Radius = 5;
            this.BtnPrendre.Size = new System.Drawing.Size(112, 34);
            this.BtnPrendre.TabIndex = 19;
            this.BtnPrendre.Text = "Prendre";
            this.BtnPrendre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnPrendre.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // RDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gunaPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RDV";
            this.Size = new System.Drawing.Size(832, 200);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaAdvenceButton BtnPrendre;

    }
}
