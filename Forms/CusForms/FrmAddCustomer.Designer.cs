namespace E_Apartments.Forms
{
    partial class FrmAddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCustomer));
            this.grpCusDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmbCusAge = new System.Windows.Forms.NumericUpDown();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.grpDepDetails = new System.Windows.Forms.GroupBox();
            this.cmbDepRelation = new System.Windows.Forms.ComboBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.DGridDependents = new System.Windows.Forms.DataGridView();
            this.btnDepAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nmbDepAge = new System.Windows.Forms.NumericUpDown();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnClearDependentDetails = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.grpCusDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCusAge)).BeginInit();
            this.grpDepDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridDependents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDepAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCusDetails
            // 
            this.grpCusDetails.Controls.Add(this.label6);
            this.grpCusDetails.Controls.Add(this.nmbCusAge);
            this.grpCusDetails.Controls.Add(this.btnAddCustomer);
            this.grpCusDetails.Controls.Add(this.btnClear);
            this.grpCusDetails.Controls.Add(this.label5);
            this.grpCusDetails.Controls.Add(this.txtCusAddress);
            this.grpCusDetails.Controls.Add(this.label4);
            this.grpCusDetails.Controls.Add(this.txtCusNIC);
            this.grpCusDetails.Controls.Add(this.label3);
            this.grpCusDetails.Controls.Add(this.txtCusPhone);
            this.grpCusDetails.Controls.Add(this.label2);
            this.grpCusDetails.Controls.Add(this.txtCusEmail);
            this.grpCusDetails.Controls.Add(this.label1);
            this.grpCusDetails.Controls.Add(this.txtCusName);
            this.grpCusDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.grpCusDetails.Location = new System.Drawing.Point(59, 41);
            this.grpCusDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCusDetails.Name = "grpCusDetails";
            this.grpCusDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCusDetails.Size = new System.Drawing.Size(427, 579);
            this.grpCusDetails.TabIndex = 0;
            this.grpCusDetails.TabStop = false;
            this.grpCusDetails.Text = "Customer\'s Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(315, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age";
            // 
            // nmbCusAge
            // 
            this.nmbCusAge.Location = new System.Drawing.Point(320, 89);
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
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Location = new System.Drawing.Point(229, 520);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(175, 36);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(21, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(175, 36);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Location = new System.Drawing.Point(21, 461);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusAddress.MaxLength = 350;
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(383, 31);
            this.txtCusAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIC / Passport No.";
            // 
            // txtCusNIC
            // 
            this.txtCusNIC.Location = new System.Drawing.Point(21, 368);
            this.txtCusNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusNIC.MaxLength = 12;
            this.txtCusNIC.Name = "txtCusNIC";
            this.txtCusNIC.Size = new System.Drawing.Size(383, 31);
            this.txtCusNIC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Location = new System.Drawing.Point(21, 275);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusPhone.MaxLength = 10;
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(383, 31);
            this.txtCusPhone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Location = new System.Drawing.Point(21, 182);
            this.txtCusEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(383, 31);
            this.txtCusEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(21, 89);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(272, 31);
            this.txtCusName.TabIndex = 0;
            // 
            // grpDepDetails
            // 
            this.grpDepDetails.Controls.Add(this.cmbDepRelation);
            this.grpDepDetails.Controls.Add(this.btnSkip);
            this.grpDepDetails.Controls.Add(this.DGridDependents);
            this.grpDepDetails.Controls.Add(this.btnDepAdd);
            this.grpDepDetails.Controls.Add(this.label7);
            this.grpDepDetails.Controls.Add(this.nmbDepAge);
            this.grpDepDetails.Controls.Add(this.btnFinish);
            this.grpDepDetails.Controls.Add(this.btnClearDependentDetails);
            this.grpDepDetails.Controls.Add(this.label10);
            this.grpDepDetails.Controls.Add(this.label11);
            this.grpDepDetails.Controls.Add(this.label12);
            this.grpDepDetails.Controls.Add(this.txtDepName);
            this.grpDepDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.grpDepDetails.Location = new System.Drawing.Point(538, 41);
            this.grpDepDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDepDetails.Name = "grpDepDetails";
            this.grpDepDetails.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDepDetails.Size = new System.Drawing.Size(427, 579);
            this.grpDepDetails.TabIndex = 14;
            this.grpDepDetails.TabStop = false;
            this.grpDepDetails.Text = "Dependent\'s Details";
            // 
            // cmbDepRelation
            // 
            this.cmbDepRelation.FormattingEnabled = true;
            this.cmbDepRelation.Items.AddRange(new object[] {
            "(Relation)",
            "Husbund",
            "Wife",
            "Son",
            "Duaghter",
            "(Servant)"});
            this.cmbDepRelation.Location = new System.Drawing.Point(21, 182);
            this.cmbDepRelation.Name = "cmbDepRelation";
            this.cmbDepRelation.Size = new System.Drawing.Size(187, 33);
            this.cmbDepRelation.TabIndex = 17;
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnSkip.Enabled = false;
            this.btnSkip.FlatAppearance.BorderSize = 0;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Location = new System.Drawing.Point(161, 520);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(109, 36);
            this.btnSkip.TabIndex = 16;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGridDependents.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGridDependents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGridDependents.Location = new System.Drawing.Point(21, 275);
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
            this.DGridDependents.Size = new System.Drawing.Size(383, 217);
            this.DGridDependents.TabIndex = 15;
            // 
            // btnDepAdd
            // 
            this.btnDepAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnDepAdd.BackgroundImage = global::E_Apartments.Properties.Resources.AddIcon;
            this.btnDepAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepAdd.Enabled = false;
            this.btnDepAdd.FlatAppearance.BorderSize = 0;
            this.btnDepAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnDepAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnDepAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepAdd.Location = new System.Drawing.Point(373, 182);
            this.btnDepAdd.Name = "btnDepAdd";
            this.btnDepAdd.Size = new System.Drawing.Size(31, 31);
            this.btnDepAdd.TabIndex = 14;
            this.btnDepAdd.UseVisualStyleBackColor = false;
            this.btnDepAdd.Click += new System.EventHandler(this.btnDepAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Age";
            // 
            // nmbDepAge
            // 
            this.nmbDepAge.Location = new System.Drawing.Point(244, 182);
            this.nmbDepAge.Name = "nmbDepAge";
            this.nmbDepAge.Size = new System.Drawing.Size(84, 31);
            this.nmbDepAge.TabIndex = 1;
            this.nmbDepAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnFinish.Enabled = false;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(295, 520);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(109, 36);
            this.btnFinish.TabIndex = 7;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnClearDependentDetails
            // 
            this.btnClearDependentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnClearDependentDetails.FlatAppearance.BorderSize = 0;
            this.btnClearDependentDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDependentDetails.Location = new System.Drawing.Point(21, 520);
            this.btnClearDependentDetails.Name = "btnClearDependentDetails";
            this.btnClearDependentDetails.Size = new System.Drawing.Size(112, 36);
            this.btnClearDependentDetails.TabIndex = 6;
            this.btnClearDependentDetails.Text = "Clear";
            this.btnClearDependentDetails.UseVisualStyleBackColor = false;
            this.btnClearDependentDetails.Click += new System.EventHandler(this.btnClearDependentDetails_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Dependents";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Relation";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Dependent Name";
            // 
            // txtDepName
            // 
            this.txtDepName.Location = new System.Drawing.Point(21, 89);
            this.txtDepName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(383, 31);
            this.txtDepName.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1005, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExit.TabIndex = 15;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1030, 665);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDepDetails);
            this.Controls.Add(this.grpCusDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Customer";
            this.Load += new System.EventHandler(this.FrmAddCustomer_Load);
            this.grpCusDetails.ResumeLayout(false);
            this.grpCusDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCusAge)).EndInit();
            this.grpDepDetails.ResumeLayout(false);
            this.grpDepDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridDependents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDepAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCusDetails;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.NumericUpDown nmbCusAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpDepDetails;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.DataGridView DGridDependents;
        private System.Windows.Forms.Button btnDepAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmbDepAge;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnClearDependentDetails;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.ComboBox cmbDepRelation;
        private FontAwesome.Sharp.IconPictureBox btnExit;
    }
}