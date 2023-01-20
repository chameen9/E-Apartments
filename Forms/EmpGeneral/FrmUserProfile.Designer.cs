namespace E_Apartments.Forms.EmpGeneral
{
    partial class FrmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserProfile));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icoPasswordCheck = new FontAwesome.Sharp.IconPictureBox();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDefaultHidePw = new FontAwesome.Sharp.IconPictureBox();
            this.btnDefaultShowPw = new FontAwesome.Sharp.IconPictureBox();
            this.btnHidePw = new FontAwesome.Sharp.IconPictureBox();
            this.btnShowPw = new FontAwesome.Sharp.IconPictureBox();
            this.txtConfirmedPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoPasswordCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultHidePw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultShowPw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHidePw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.icoPasswordCheck);
            this.groupBox1.Controls.Add(this.txtUserType);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDefaultHidePw);
            this.groupBox1.Controls.Add(this.btnDefaultShowPw);
            this.groupBox1.Controls.Add(this.btnHidePw);
            this.groupBox1.Controls.Add(this.btnShowPw);
            this.groupBox1.Controls.Add(this.txtConfirmedPassword);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(64, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 307);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your profile";
            // 
            // icoPasswordCheck
            // 
            this.icoPasswordCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.icoPasswordCheck.ForeColor = System.Drawing.Color.Green;
            this.icoPasswordCheck.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.icoPasswordCheck.IconColor = System.Drawing.Color.Green;
            this.icoPasswordCheck.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoPasswordCheck.IconSize = 25;
            this.icoPasswordCheck.Location = new System.Drawing.Point(108, 203);
            this.icoPasswordCheck.Name = "icoPasswordCheck";
            this.icoPasswordCheck.Size = new System.Drawing.Size(25, 25);
            this.icoPasswordCheck.TabIndex = 122;
            this.icoPasswordCheck.TabStop = false;
            this.icoPasswordCheck.Visible = false;
            // 
            // txtUserType
            // 
            this.txtUserType.Enabled = false;
            this.txtUserType.Location = new System.Drawing.Point(293, 68);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(152, 31);
            this.txtUserType.TabIndex = 121;
            this.txtUserType.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(724, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDefaultHidePw
            // 
            this.btnDefaultHidePw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.btnDefaultHidePw.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnDefaultHidePw.IconColor = System.Drawing.Color.White;
            this.btnDefaultHidePw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDefaultHidePw.IconSize = 25;
            this.btnDefaultHidePw.Location = new System.Drawing.Point(420, 236);
            this.btnDefaultHidePw.Name = "btnDefaultHidePw";
            this.btnDefaultHidePw.Size = new System.Drawing.Size(25, 25);
            this.btnDefaultHidePw.TabIndex = 120;
            this.btnDefaultHidePw.TabStop = false;
            this.btnDefaultHidePw.Visible = false;
            this.btnDefaultHidePw.Click += new System.EventHandler(this.btnDefaultHidePw_Click);
            // 
            // btnDefaultShowPw
            // 
            this.btnDefaultShowPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.btnDefaultShowPw.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnDefaultShowPw.IconColor = System.Drawing.Color.White;
            this.btnDefaultShowPw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDefaultShowPw.IconSize = 25;
            this.btnDefaultShowPw.Location = new System.Drawing.Point(420, 236);
            this.btnDefaultShowPw.Name = "btnDefaultShowPw";
            this.btnDefaultShowPw.Size = new System.Drawing.Size(25, 25);
            this.btnDefaultShowPw.TabIndex = 119;
            this.btnDefaultShowPw.TabStop = false;
            this.btnDefaultShowPw.Click += new System.EventHandler(this.btnDefaultShowPw_Click);
            // 
            // btnHidePw
            // 
            this.btnHidePw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.btnHidePw.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnHidePw.IconColor = System.Drawing.Color.White;
            this.btnHidePw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHidePw.IconSize = 25;
            this.btnHidePw.Location = new System.Drawing.Point(852, 151);
            this.btnHidePw.Name = "btnHidePw";
            this.btnHidePw.Size = new System.Drawing.Size(25, 25);
            this.btnHidePw.TabIndex = 118;
            this.btnHidePw.TabStop = false;
            this.btnHidePw.Visible = false;
            this.btnHidePw.Click += new System.EventHandler(this.btnHidePw_Click);
            // 
            // btnShowPw
            // 
            this.btnShowPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.btnShowPw.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnShowPw.IconColor = System.Drawing.Color.White;
            this.btnShowPw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowPw.IconSize = 25;
            this.btnShowPw.Location = new System.Drawing.Point(852, 151);
            this.btnShowPw.Name = "btnShowPw";
            this.btnShowPw.Size = new System.Drawing.Size(25, 25);
            this.btnShowPw.TabIndex = 117;
            this.btnShowPw.TabStop = false;
            this.btnShowPw.Click += new System.EventHandler(this.btnShowPw_Click);
            // 
            // txtConfirmedPassword
            // 
            this.txtConfirmedPassword.Enabled = false;
            this.txtConfirmedPassword.Location = new System.Drawing.Point(532, 148);
            this.txtConfirmedPassword.Name = "txtConfirmedPassword";
            this.txtConfirmedPassword.Size = new System.Drawing.Size(314, 31);
            this.txtConfirmedPassword.TabIndex = 2;
            this.txtConfirmedPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 115;
            this.label6.Text = "Confirmed Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(20, 233);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(388, 31);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 113;
            this.label5.Text = "Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Location = new System.Drawing.Point(532, 70);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(342, 31);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 111;
            this.label4.Text = "User Type";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(20, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(425, 31);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(20, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(251, 31);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "New Password";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(532, 229);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Username";
            // 
            // FrmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUserProfile";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.FrmUserProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoPasswordCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultHidePw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefaultShowPw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHidePw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmedPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPassword;
        private FontAwesome.Sharp.IconPictureBox btnHidePw;
        private FontAwesome.Sharp.IconPictureBox btnShowPw;
        private FontAwesome.Sharp.IconPictureBox btnDefaultHidePw;
        private FontAwesome.Sharp.IconPictureBox btnDefaultShowPw;
        private System.Windows.Forms.TextBox txtUserType;
        private FontAwesome.Sharp.IconPictureBox icoPasswordCheck;
    }
}