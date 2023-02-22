namespace AtelierCoutureGEST
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lbTitleConnection = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbIdentifiant = new System.Windows.Forms.Label();
            this.tbPasswd = new System.Windows.Forms.TextBox();
            this.tbIdentifiant = new System.Windows.Forms.TextBox();
            this.lbPasswd = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.pbConnection = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.imgClose);
            this.panel1.Controls.Add(this.lbTitleConnection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(546, 59);
            this.panel1.TabIndex = 0;
            // 
            // imgClose
            // 
            this.imgClose.Image = ((System.Drawing.Image)(resources.GetObject("imgClose.Image")));
            this.imgClose.Location = new System.Drawing.Point(486, 12);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(48, 33);
            this.imgClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClose.TabIndex = 3;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            // 
            // lbTitleConnection
            // 
            this.lbTitleConnection.AutoSize = true;
            this.lbTitleConnection.Font = new System.Drawing.Font("Matura MT Script Capitals", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleConnection.Location = new System.Drawing.Point(117, 19);
            this.lbTitleConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitleConnection.Name = "lbTitleConnection";
            this.lbTitleConnection.Size = new System.Drawing.Size(278, 26);
            this.lbTitleConnection.TabIndex = 2;
            this.lbTitleConnection.Text = "Sewing Management App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 22);
            this.panel2.TabIndex = 1;
            // 
            // lbIdentifiant
            // 
            this.lbIdentifiant.AutoSize = true;
            this.lbIdentifiant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentifiant.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbIdentifiant.Location = new System.Drawing.Point(62, 103);
            this.lbIdentifiant.Name = "lbIdentifiant";
            this.lbIdentifiant.Size = new System.Drawing.Size(79, 15);
            this.lbIdentifiant.TabIndex = 2;
            this.lbIdentifiant.Text = " Identifiant ";
            // 
            // tbPasswd
            // 
            this.tbPasswd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPasswd.Location = new System.Drawing.Point(65, 181);
            this.tbPasswd.Name = "tbPasswd";
            this.tbPasswd.Size = new System.Drawing.Size(228, 22);
            this.tbPasswd.TabIndex = 3;
            this.tbPasswd.TextChanged += new System.EventHandler(this.tbPasswd_TextChanged);
            // 
            // tbIdentifiant
            // 
            this.tbIdentifiant.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbIdentifiant.Location = new System.Drawing.Point(65, 121);
            this.tbIdentifiant.Name = "tbIdentifiant";
            this.tbIdentifiant.Size = new System.Drawing.Size(228, 22);
            this.tbIdentifiant.TabIndex = 5;
            this.tbIdentifiant.TextChanged += new System.EventHandler(this.tbIdentifiant_TextChanged);
            // 
            // lbPasswd
            // 
            this.lbPasswd.AutoSize = true;
            this.lbPasswd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswd.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbPasswd.Location = new System.Drawing.Point(62, 163);
            this.lbPasswd.Name = "lbPasswd";
            this.lbPasswd.Size = new System.Drawing.Size(95, 15);
            this.lbPasswd.TabIndex = 4;
            this.lbPasswd.Text = " Mot de Passe";
            // 
            // btnConnection
            // 
            this.btnConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnection.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConnection.CausesValidation = false;
            this.btnConnection.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnConnection.Enabled = false;
            this.btnConnection.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.SystemColors.Window;
            this.btnConnection.Location = new System.Drawing.Point(185, 235);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(132, 22);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.TabStop = false;
            this.btnConnection.Text = "CONNECTER";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // pbConnection
            // 
            this.pbConnection.Image = global::AtelierCoutureGEST.Properties.Resources.Hand_sewing__1_;
            this.pbConnection.Location = new System.Drawing.Point(344, 83);
            this.pbConnection.Name = "pbConnection";
            this.pbConnection.Size = new System.Drawing.Size(166, 174);
            this.pbConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbConnection.TabIndex = 7;
            this.pbConnection.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExit.CausesValidation = false;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnExit.Enabled = false;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(47, 235);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 22);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "QUITTER";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(546, 314);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbConnection);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.tbIdentifiant);
            this.Controls.Add(this.lbPasswd);
            this.Controls.Add(this.tbPasswd);
            this.Controls.Add(this.lbIdentifiant);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sewing Management Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitleConnection;
        private System.Windows.Forms.Label lbIdentifiant;
        private System.Windows.Forms.TextBox tbPasswd;
        private System.Windows.Forms.TextBox tbIdentifiant;
        private System.Windows.Forms.Label lbPasswd;
        internal System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.PictureBox pbConnection;
        private System.Windows.Forms.PictureBox imgClose;
        internal System.Windows.Forms.Button btnExit;
    }
}

