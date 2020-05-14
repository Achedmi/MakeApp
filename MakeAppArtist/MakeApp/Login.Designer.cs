namespace MakeApp
{
    partial class Login
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlConnexion = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtemail_p1 = new Guna.UI.WinForms.GunaTextBox();
            this.txtpaas_p1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnConnexion = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // pnlConnexion
            // 
            this.pnlConnexion.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlConnexion.Controls.Add(this.gunaLabel2);
            this.pnlConnexion.Controls.Add(this.gunaLabel1);
            this.pnlConnexion.Controls.Add(this.txtemail_p1);
            this.pnlConnexion.Controls.Add(this.txtpaas_p1);
            this.pnlConnexion.Controls.Add(this.gunaLabel4);
            this.pnlConnexion.Controls.Add(this.btnConnexion);
            this.pnlConnexion.Location = new System.Drawing.Point(472, 0);
            this.pnlConnexion.Name = "pnlConnexion";
            this.pnlConnexion.Size = new System.Drawing.Size(371, 469);
            this.pnlConnexion.TabIndex = 20;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(44, 179);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel2.TabIndex = 63;
            this.gunaLabel2.Text = "Mot de Pass";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(44, 118);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel1.TabIndex = 59;
            this.gunaLabel1.Text = "Email";
            // 
            // txtemail_p1
            // 
            this.txtemail_p1.BaseColor = System.Drawing.Color.Pink;
            this.txtemail_p1.BorderColor = System.Drawing.Color.LightPink;
            this.txtemail_p1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail_p1.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.txtemail_p1.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.txtemail_p1.FocusedForeColor = System.Drawing.Color.White;
            this.txtemail_p1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail_p1.ForeColor = System.Drawing.Color.White;
            this.txtemail_p1.Location = new System.Drawing.Point(47, 137);
            this.txtemail_p1.Name = "txtemail_p1";
            this.txtemail_p1.PasswordChar = '\0';
            this.txtemail_p1.Size = new System.Drawing.Size(260, 38);
            this.txtemail_p1.TabIndex = 3;
            this.txtemail_p1.TextOffsetX = 5;
            // 
            // txtpaas_p1
            // 
            this.txtpaas_p1.BaseColor = System.Drawing.Color.Pink;
            this.txtpaas_p1.BorderColor = System.Drawing.Color.LightPink;
            this.txtpaas_p1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpaas_p1.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.txtpaas_p1.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.txtpaas_p1.FocusedForeColor = System.Drawing.Color.White;
            this.txtpaas_p1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpaas_p1.ForeColor = System.Drawing.Color.White;
            this.txtpaas_p1.Location = new System.Drawing.Point(47, 197);
            this.txtpaas_p1.Name = "txtpaas_p1";
            this.txtpaas_p1.PasswordChar = '●';
            this.txtpaas_p1.Size = new System.Drawing.Size(260, 38);
            this.txtpaas_p1.TabIndex = 4;
            this.txtpaas_p1.TextOffsetX = 5;
            this.txtpaas_p1.UseSystemPasswordChar = true;
            this.txtpaas_p1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpaas_p1_KeyPress);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(101, 51);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(150, 37);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Bienvenue";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Animated = true;
            this.btnConnexion.AnimationHoverSpeed = 0.07F;
            this.btnConnexion.AnimationSpeed = 0.03F;
            this.btnConnexion.BackColor = System.Drawing.Color.Transparent;
            this.btnConnexion.BaseColor = System.Drawing.Color.Pink;
            this.btnConnexion.BorderColor = System.Drawing.Color.Black;
            this.btnConnexion.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnConnexion.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnConnexion.CheckedForeColor = System.Drawing.Color.White;
            this.btnConnexion.CheckedImage = null;
            this.btnConnexion.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnConnexion.FocusedColor = System.Drawing.Color.Empty;
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Image = null;
            this.btnConnexion.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConnexion.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnConnexion.Location = new System.Drawing.Point(49, 267);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.OnHoverBaseColor = System.Drawing.Color.HotPink;
            this.btnConnexion.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConnexion.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConnexion.OnHoverImage = null;
            this.btnConnexion.OnHoverLineColor = System.Drawing.Color.NavajoWhite;
            this.btnConnexion.OnPressedColor = System.Drawing.Color.Plum;
            this.btnConnexion.Radius = 8;
            this.btnConnexion.Size = new System.Drawing.Size(260, 42);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.BackgroundImage = global::MakeApp.Properties.Resources.hadi_ghatkhdm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 469);
            this.Controls.Add(this.pnlConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.pnlConnexion.ResumeLayout(false);
            this.pnlConnexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel pnlConnexion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtemail_p1;
        private Guna.UI.WinForms.GunaTextBox txtpaas_p1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton btnConnexion;

    }
}

