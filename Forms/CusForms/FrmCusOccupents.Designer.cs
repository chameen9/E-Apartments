namespace E_Apartments.Forms.CusForms
{
    partial class FrmCusOccupents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCusOccupents));
            this.grpCusDetails = new System.Windows.Forms.GroupBox();
            this.icoHidePw = new FontAwesome.Sharp.IconPictureBox();
            this.icoShowPw = new FontAwesome.Sharp.IconPictureBox();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.nmbCusAge = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.DGridDependents = new System.Windows.Forms.DataGridView();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.grpCusDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoHidePw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoShowPw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCusAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridDependents)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCusDetails
            // 
            this.grpCusDetails.Controls.Add(this.txtNic);
            this.grpCusDetails.Controls.Add(this.icoHidePw);
            this.grpCusDetails.Controls.Add(this.icoShowPw);
            this.grpCusDetails.Controls.Add(this.btnUpdate);
            this.grpCusDetails.Controls.Add(this.label6);
            this.grpCusDetails.Controls.Add(this.txtCusAddress);
            this.grpCusDetails.Controls.Add(this.nmbCusAge);
            this.grpCusDetails.Controls.Add(this.label5);
            this.grpCusDetails.Controls.Add(this.label2);
            this.grpCusDetails.Controls.Add(this.txtCusPhone);
            this.grpCusDetails.Controls.Add(this.label3);
            this.grpCusDetails.Controls.Add(this.txtCusEmail);
            this.grpCusDetails.Controls.Add(this.label4);
            this.grpCusDetails.Controls.Add(this.label1);
            this.grpCusDetails.Controls.Add(this.txtPassword);
            this.grpCusDetails.Controls.Add(this.txtCusName);
            this.grpCusDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.grpCusDetails.Location = new System.Drawing.Point(59, 35);
            this.grpCusDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCusDetails.Name = "grpCusDetails";
            this.grpCusDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCusDetails.Size = new System.Drawing.Size(911, 327);
            this.grpCusDetails.TabIndex = 1;
            this.grpCusDetails.TabStop = false;
            this.grpCusDetails.Text = "Customer\'s Details";
            // 
            // icoHidePw
            // 
            this.icoHidePw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.icoHidePw.ForeColor = System.Drawing.SystemColors.Window;
            this.icoHidePw.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.icoHidePw.IconColor = System.Drawing.SystemColors.Window;
            this.icoHidePw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoHidePw.IconSize = 25;
            this.icoHidePw.Location = new System.Drawing.Point(858, 178);
            this.icoHidePw.Name = "icoHidePw";
            this.icoHidePw.Size = new System.Drawing.Size(25, 25);
            this.icoHidePw.TabIndex = 113;
            this.icoHidePw.TabStop = false;
            this.icoHidePw.Visible = false;
            this.icoHidePw.Click += new System.EventHandler(this.icoHidePw_Click);
            // 
            // icoShowPw
            // 
            this.icoShowPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.icoShowPw.ForeColor = System.Drawing.SystemColors.Window;
            this.icoShowPw.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icoShowPw.IconColor = System.Drawing.SystemColors.Window;
            this.icoShowPw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoShowPw.IconSize = 25;
            this.icoShowPw.Location = new System.Drawing.Point(858, 178);
            this.icoShowPw.Name = "icoShowPw";
            this.icoShowPw.Size = new System.Drawing.Size(25, 25);
            this.icoShowPw.TabIndex = 112;
            this.icoShowPw.TabStop = false;
            this.icoShowPw.Click += new System.EventHandler(this.icoShowPw_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.Location = new System.Drawing.Point(500, 262);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(90, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(383, 38);
            this.btnUpdate.TabIndex = 111;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(21, 269);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusAddress.MaxLength = 350;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(383, 31);
            this.txtCusAddress.TabIndex = 5;
            // 
            // nmbCusAge
            // 
            this.nmbCusAge.Location = new System.Drawing.Point(320, 80);
            this.nmbCusAge.Name = "nmbCusAge";
            this.nmbCusAge.Size = new System.Drawing.Size(84, 31);
            this.nmbCusAge.TabIndex = 1;
            this.nmbCusAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmbCusAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(500, 79);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusPhone.MaxLength = 10;
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(383, 31);
            this.txtCusPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Enabled = false;
            this.txtCusEmail.Location = new System.Drawing.Point(21, 175);
            this.txtCusEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.ReadOnly = true;
            this.txtCusEmail.Size = new System.Drawing.Size(383, 31);
            this.txtCusEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(500, 175);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MaxLength = 12;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(345, 31);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(21, 80);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(272, 31);
            this.txtCusName.TabIndex = 0;
            // 
            // DGridDependents
            // 
            this.DGridDependents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridDependents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGridDependents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.DGridDependents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGridDependents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridDependents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGridDependents.ColumnHeadersHeight = 29;
            this.DGridDependents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGridDependents.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGridDependents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGridDependents.Location = new System.Drawing.Point(59, 386);
            this.DGridDependents.Name = "DGridDependents";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridDependents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGridDependents.RowHeadersVisible = false;
            this.DGridDependents.RowHeadersWidth = 51;
            this.DGridDependents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            this.DGridDependents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGridDependents.RowTemplate.Height = 24;
            this.DGridDependents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGridDependents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGridDependents.ShowEditingIcon = false;
            this.DGridDependents.ShowRowErrors = false;
            this.DGridDependents.Size = new System.Drawing.Size(911, 217);
            this.DGridDependents.TabIndex = 16;
            // 
            // txtNic
            // 
            this.txtNic.Enabled = false;
            this.txtNic.Location = new System.Drawing.Point(77, 134);
            this.txtNic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNic.Name = "txtNic";
            this.txtNic.ReadOnly = true;
            this.txtNic.Size = new System.Drawing.Size(327, 31);
            this.txtNic.TabIndex = 114;
            this.txtNic.Visible = false;
            // 
            // FrmCusOccupents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.DGridDependents);
            this.Controls.Add(this.grpCusDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCusOccupents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCusOccupents";
            this.Load += new System.EventHandler(this.FrmCusOccupents_Load);
            this.grpCusDetails.ResumeLayout(false);
            this.grpCusDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoHidePw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoShowPw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCusAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridDependents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCusDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.NumericUpDown nmbCusAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.DataGridView DGridDependents;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconPictureBox icoHidePw;
        private FontAwesome.Sharp.IconPictureBox icoShowPw;
        private System.Windows.Forms.TextBox txtNic;
    }
}