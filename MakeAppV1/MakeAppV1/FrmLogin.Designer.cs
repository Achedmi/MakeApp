namespace MakeAppV1
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlConnexion = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtemail_p1 = new Guna.UI.WinForms.GunaTextBox();
            this.txtpaas_p1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lnklblpass = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnConnexion = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlInscrire = new System.Windows.Forms.Panel();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnInscrire = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TxtPass_pnlInsc = new Guna.UI.WinForms.GunaTextBox();
            this.txtTel = new Guna.UI.WinForms.GunaTextBox();
            this.TxtMail_pnlInsc = new Guna.UI.WinForms.GunaTextBox();
            this.txtNom = new Guna.UI.WinForms.GunaTextBox();
            this.txtPrenom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel15 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.Nom = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaTransition1 = new Guna.UI.WinForms.GunaTransition(this.components);
            this.pnlConnexion.SuspendLayout();
            this.pnlInscrire.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlConnexion.Controls.Add(this.lnklblpass);
            this.pnlConnexion.Controls.Add(this.btnConnexion);
            this.gunaTransition1.SetDecoration(this.pnlConnexion, Guna.UI.Animation.DecorationType.None);
            this.pnlConnexion.Location = new System.Drawing.Point(0, 0);
            this.pnlConnexion.Name = "pnlConnexion";
            this.pnlConnexion.Size = new System.Drawing.Size(371, 469);
            this.pnlConnexion.TabIndex = 19;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
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
            this.gunaTransition1.SetDecoration(this.gunaLabel1, Guna.UI.Animation.DecorationType.None);
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
            this.gunaTransition1.SetDecoration(this.txtemail_p1, Guna.UI.Animation.DecorationType.None);
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
            this.gunaTransition1.SetDecoration(this.txtpaas_p1, Guna.UI.Animation.DecorationType.None);
            this.txtpaas_p1.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.txtpaas_p1.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.txtpaas_p1.FocusedForeColor = System.Drawing.Color.White;
            this.txtpaas_p1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpaas_p1.ForeColor = System.Drawing.Color.White;
            this.txtpaas_p1.Location = new System.Drawing.Point(47, 197);
            this.txtpaas_p1.Name = "txtpaas_p1";
            this.txtpaas_p1.PasswordChar = '\0';
            this.txtpaas_p1.Size = new System.Drawing.Size(260, 38);
            this.txtpaas_p1.TabIndex = 4;
            this.txtpaas_p1.TextOffsetX = 5;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.gunaLabel4, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(101, 51);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(150, 37);
            this.gunaLabel4.TabIndex = 16;
            this.gunaLabel4.Text = "Bienvenue";
            // 
            // lnklblpass
            // 
            this.lnklblpass.ActiveLinkColor = System.Drawing.Color.BlueViolet;
            this.lnklblpass.AutoSize = true;
            this.lnklblpass.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.lnklblpass, Guna.UI.Animation.DecorationType.None);
            this.lnklblpass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lnklblpass.LinkColor = System.Drawing.Color.Purple;
            this.lnklblpass.Location = new System.Drawing.Point(128, 333);
            this.lnklblpass.Name = "lnklblpass";
            this.lnklblpass.Size = new System.Drawing.Size(110, 19);
            this.lnklblpass.TabIndex = 17;
            this.lnklblpass.TabStop = true;
            this.lnklblpass.Text = "Cree un Compte";
            this.lnklblpass.VisitedLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.lnklblpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblpass_LinkClicked);
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
            this.gunaTransition1.SetDecoration(this.btnConnexion, Guna.UI.Animation.DecorationType.None);
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
            // 
            // pnlInscrire
            // 
            this.pnlInscrire.BackColor = System.Drawing.Color.Transparent;
            this.pnlInscrire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInscrire.Controls.Add(this.gunaLinkLabel1);
            this.pnlInscrire.Controls.Add(this.btnInscrire);
            this.pnlInscrire.Controls.Add(this.TxtPass_pnlInsc);
            this.pnlInscrire.Controls.Add(this.txtTel);
            this.pnlInscrire.Controls.Add(this.TxtMail_pnlInsc);
            this.pnlInscrire.Controls.Add(this.txtNom);
            this.pnlInscrire.Controls.Add(this.txtPrenom);
            this.pnlInscrire.Controls.Add(this.gunaLabel12);
            this.pnlInscrire.Controls.Add(this.gunaLabel15);
            this.pnlInscrire.Controls.Add(this.gunaLabel8);
            this.pnlInscrire.Controls.Add(this.Nom);
            this.pnlInscrire.Controls.Add(this.gunaLabel11);
            this.gunaTransition1.SetDecoration(this.pnlInscrire, Guna.UI.Animation.DecorationType.None);
            this.pnlInscrire.Location = new System.Drawing.Point(0, 0);
            this.pnlInscrire.Name = "pnlInscrire";
            this.pnlInscrire.Size = new System.Drawing.Size(371, 469);
            this.pnlInscrire.TabIndex = 20;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.BlueViolet;
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransition1.SetDecoration(this.gunaLinkLabel1, Guna.UI.Animation.DecorationType.None);
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.Purple;
            this.gunaLinkLabel1.Location = new System.Drawing.Point(116, 415);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(124, 19);
            this.gunaLinkLabel1.TabIndex = 69;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "j\'ai deja un compte";
            this.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.MediumSlateBlue;
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // btnInscrire
            // 
            this.btnInscrire.Animated = true;
            this.btnInscrire.AnimationHoverSpeed = 0.07F;
            this.btnInscrire.AnimationSpeed = 0.03F;
            this.btnInscrire.BackColor = System.Drawing.Color.Transparent;
            this.btnInscrire.BaseColor = System.Drawing.Color.Pink;
            this.btnInscrire.BorderColor = System.Drawing.Color.Black;
            this.btnInscrire.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnInscrire.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnInscrire.CheckedForeColor = System.Drawing.Color.White;
            this.btnInscrire.CheckedImage = null;
            this.btnInscrire.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaTransition1.SetDecoration(this.btnInscrire, Guna.UI.Animation.DecorationType.None);
            this.btnInscrire.FocusedColor = System.Drawing.Color.Empty;
            this.btnInscrire.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnInscrire.ForeColor = System.Drawing.Color.White;
            this.btnInscrire.Image = null;
            this.btnInscrire.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInscrire.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnInscrire.Location = new System.Drawing.Point(47, 359);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.OnHoverBaseColor = System.Drawing.Color.HotPink;
            this.btnInscrire.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnInscrire.OnHoverForeColor = System.Drawing.Color.White;
            this.btnInscrire.OnHoverImage = null;
            this.btnInscrire.OnHoverLineColor = System.Drawing.Color.NavajoWhite;
            this.btnInscrire.OnPressedColor = System.Drawing.Color.Plum;
            this.btnInscrire.Radius = 8;
            this.btnInscrire.Size = new System.Drawing.Size(260, 42);
            this.btnInscrire.TabIndex = 68;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPass_pnlInsc
            // 
            this.TxtPass_pnlInsc.BaseColor = System.Drawing.Color.Pink;
            this.TxtPass_pnlInsc.BorderColor = System.Drawing.Color.LightPink;
            this.TxtPass_pnlInsc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.TxtPass_pnlInsc, Guna.UI.Animation.DecorationType.None);
            this.TxtPass_pnlInsc.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.TxtPass_pnlInsc.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.TxtPass_pnlInsc.FocusedForeColor = System.Drawing.Color.White;
            this.TxtPass_pnlInsc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPass_pnlInsc.ForeColor = System.Drawing.Color.White;
            this.TxtPass_pnlInsc.Location = new System.Drawing.Point(47, 298);
            this.TxtPass_pnlInsc.Name = "TxtPass_pnlInsc";
            this.TxtPass_pnlInsc.PasswordChar = '\0';
            this.TxtPass_pnlInsc.Size = new System.Drawing.Size(260, 38);
            this.TxtPass_pnlInsc.TabIndex = 67;
            this.TxtPass_pnlInsc.TextOffsetX = 5;
            // 
            // txtTel
            // 
            this.txtTel.BaseColor = System.Drawing.Color.Pink;
            this.txtTel.BorderColor = System.Drawing.Color.LightPink;
            this.txtTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtTel, Guna.UI.Animation.DecorationType.None);
            this.txtTel.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.txtTel.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.txtTel.FocusedForeColor = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTel.ForeColor = System.Drawing.Color.White;
            this.txtTel.Location = new System.Drawing.Point(47, 236);
            this.txtTel.Name = "txtTel";
            this.txtTel.PasswordChar = '\0';
            this.txtTel.Size = new System.Drawing.Size(260, 38);
            this.txtTel.TabIndex = 66;
            this.txtTel.TextOffsetX = 5;
            // 
            // TxtMail_pnlInsc
            // 
            this.TxtMail_pnlInsc.BaseColor = System.Drawing.Color.Pink;
            this.TxtMail_pnlInsc.BorderColor = System.Drawing.Color.LightPink;
            this.TxtMail_pnlInsc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.TxtMail_pnlInsc, Guna.UI.Animation.DecorationType.None);
            this.TxtMail_pnlInsc.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.TxtMail_pnlInsc.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.TxtMail_pnlInsc.FocusedForeColor = System.Drawing.Color.White;
            this.TxtMail_pnlInsc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtMail_pnlInsc.ForeColor = System.Drawing.Color.White;
            this.TxtMail_pnlInsc.Location = new System.Drawing.Point(47, 177);
            this.TxtMail_pnlInsc.Name = "TxtMail_pnlInsc";
            this.TxtMail_pnlInsc.PasswordChar = '\0';
            this.TxtMail_pnlInsc.Size = new System.Drawing.Size(260, 38);
            this.TxtMail_pnlInsc.TabIndex = 65;
            this.TxtMail_pnlInsc.TextOffsetX = 5;
            // 
            // txtNom
            // 
            this.txtNom.BaseColor = System.Drawing.Color.Pink;
            this.txtNom.BorderColor = System.Drawing.Color.LightPink;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtNom, Guna.UI.Animation.DecorationType.None);
            this.txtNom.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.txtNom.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.txtNom.FocusedForeColor = System.Drawing.Color.White;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.ForeColor = System.Drawing.Color.White;
            this.txtNom.Location = new System.Drawing.Point(47, 112);
            this.txtNom.Name = "txtNom";
            this.txtNom.PasswordChar = '\0';
            this.txtNom.Size = new System.Drawing.Size(260, 38);
            this.txtNom.TabIndex = 64;
            this.txtNom.TextOffsetX = 5;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BaseColor = System.Drawing.Color.Pink;
            this.txtPrenom.BorderColor = System.Drawing.Color.LightPink;
            this.txtPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTransition1.SetDecoration(this.txtPrenom, Guna.UI.Animation.DecorationType.None);
            this.txtPrenom.FocusedBaseColor = System.Drawing.Color.LightPink;
            this.txtPrenom.FocusedBorderColor = System.Drawing.Color.LightPink;
            this.txtPrenom.FocusedForeColor = System.Drawing.Color.White;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrenom.ForeColor = System.Drawing.Color.White;
            this.txtPrenom.Location = new System.Drawing.Point(49, 51);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.PasswordChar = '\0';
            this.txtPrenom.Size = new System.Drawing.Size(260, 38);
            this.txtPrenom.TabIndex = 63;
            this.txtPrenom.TextOffsetX = 5;
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel12, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel12.ForeColor = System.Drawing.Color.White;
            this.gunaLabel12.Location = new System.Drawing.Point(44, 280);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel12.TabIndex = 62;
            this.gunaLabel12.Text = "Mot de Pass";
            // 
            // gunaLabel15
            // 
            this.gunaLabel15.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel15, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel15.ForeColor = System.Drawing.Color.White;
            this.gunaLabel15.Location = new System.Drawing.Point(45, 33);
            this.gunaLabel15.Name = "gunaLabel15";
            this.gunaLabel15.Size = new System.Drawing.Size(51, 15);
            this.gunaLabel15.TabIndex = 61;
            this.gunaLabel15.Text = "Prenom";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel8, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(44, 218);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(24, 15);
            this.gunaLabel8.TabIndex = 60;
            this.gunaLabel8.Text = "Tel";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.Nom, Guna.UI.Animation.DecorationType.None);
            this.Nom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Nom.ForeColor = System.Drawing.Color.White;
            this.Nom.Location = new System.Drawing.Point(44, 94);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(34, 15);
            this.Nom.TabIndex = 59;
            this.Nom.Text = "Nom";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaTransition1.SetDecoration(this.gunaLabel11, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaLabel11.ForeColor = System.Drawing.Color.White;
            this.gunaLabel11.Location = new System.Drawing.Point(44, 156);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel11.TabIndex = 58;
            this.gunaLabel11.Text = "Email";
            // 
            // gunaTransition1
            // 
            this.gunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this.gunaTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.gunaTransition1.DefaultAnimation = animation1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.BackgroundImage = global::MakeAppV1.Properties.Resources.different_cosmetics_types_scattered_pink_table_23_2148046897;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 469);
            this.Controls.Add(this.pnlConnexion);
            this.Controls.Add(this.pnlInscrire);
            this.gunaTransition1.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.pnlConnexion.ResumeLayout(false);
            this.pnlConnexion.PerformLayout();
            this.pnlInscrire.ResumeLayout(false);
            this.pnlInscrire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConnexion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtemail_p1;
        private Guna.UI.WinForms.GunaTextBox txtpaas_p1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLinkLabel lnklblpass;
        private Guna.UI.WinForms.GunaAdvenceButton btnConnexion;
        private System.Windows.Forms.Panel pnlInscrire;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnInscrire;
        private Guna.UI.WinForms.GunaTextBox TxtPass_pnlInsc;
        private Guna.UI.WinForms.GunaTextBox txtTel;
        private Guna.UI.WinForms.GunaTextBox TxtMail_pnlInsc;
        private Guna.UI.WinForms.GunaTextBox txtNom;
        private Guna.UI.WinForms.GunaTextBox txtPrenom;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaLabel gunaLabel15;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel Nom;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaTransition gunaTransition1;
    }
}