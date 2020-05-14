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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPrendre = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lblDesc = new Guna.UI.WinForms.GunaLabel();
            this.lblHeur = new Guna.UI.WinForms.GunaLabel();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            this.lblTel = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
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
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Controls.Add(this.BtnPrendre);
            this.gunaPanel1.Controls.Add(this.lblDesc);
            this.gunaPanel1.Controls.Add(this.lblHeur);
            this.gunaPanel1.Controls.Add(this.lblDate);
            this.gunaPanel1.Controls.Add(this.lblTel);
            this.gunaPanel1.Controls.Add(this.lblName);
            this.gunaPanel1.Controls.Add(this.gunaTransfarantPictureBox1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(832, 172);
            this.gunaPanel1.TabIndex = 0;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
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
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblDesc.Location = new System.Drawing.Point(194, 91);
            this.lblDesc.MaximumSize = new System.Drawing.Size(400, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(127, 21);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "DescriptionRdv";
            // 
            // lblHeur
            // 
            this.lblHeur.AutoSize = true;
            this.lblHeur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblHeur.Location = new System.Drawing.Point(603, 91);
            this.lblHeur.Name = "lblHeur";
            this.lblHeur.Size = new System.Drawing.Size(76, 21);
            this.lblHeur.TabIndex = 17;
            this.lblHeur.Text = "HeurRdv";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblDate.Location = new System.Drawing.Point(194, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 21);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "DateRdv";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblTel.Location = new System.Drawing.Point(599, 60);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(80, 21);
            this.lblTel.TabIndex = 12;
            this.lblTel.Text = "TEl client";
            this.lblTel.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(44)))), ((int)(((byte)(81)))));
            this.lblName.Location = new System.Drawing.Point(192, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 32);
            this.lblName.TabIndex = 11;
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
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(159, 172);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 10;
            this.gunaTransfarantPictureBox1.TabStop = false;
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
        public Guna.UI.WinForms.GunaLabel lblTel;
        public Guna.UI.WinForms.GunaLabel lblName;
        public Guna.UI.WinForms.GunaLabel lblDesc;
        public Guna.UI.WinForms.GunaLabel lblHeur;
        public Guna.UI.WinForms.GunaLabel lblDate;
        public Guna.UI.WinForms.GunaAdvenceButton BtnPrendre;
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;

    }
}
