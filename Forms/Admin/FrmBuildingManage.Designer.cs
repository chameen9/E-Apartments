namespace E_Apartments.Forms.Admin
{
    partial class FrmBuildingManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuildingManage));
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBuildingId = new System.Windows.Forms.ComboBox();
            this.txtBuildingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBuildingLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nmbApartmentsCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nmbNormalParkingsCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmbAdditionalPrikingsCount = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nmbFloorCount = new System.Windows.Forms.NumericUpDown();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.DGridBuildings = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmbApartmentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbNormalParkingsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbAdditionalPrikingsCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFloorCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridBuildings)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(20, 148);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(383, 31);
            this.txtBuildingName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Building Name";
            // 
            // cmbBuildingId
            // 
            this.cmbBuildingId.FormattingEnabled = true;
            this.cmbBuildingId.Location = new System.Drawing.Point(20, 70);
            this.cmbBuildingId.Name = "cmbBuildingId";
            this.cmbBuildingId.Size = new System.Drawing.Size(344, 33);
            this.cmbBuildingId.TabIndex = 1;
            this.cmbBuildingId.Visible = false;
            this.cmbBuildingId.SelectedIndexChanged += new System.EventHandler(this.cmbBuildingId_SelectedIndexChanged);
            // 
            // txtBuildingId
            // 
            this.txtBuildingId.Location = new System.Drawing.Point(20, 70);
            this.txtBuildingId.Name = "txtBuildingId";
            this.txtBuildingId.Size = new System.Drawing.Size(344, 31);
            this.txtBuildingId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Building Id";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(532, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 39);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(724, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 39);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(532, 222);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(724, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBuildingLocation
            // 
            this.txtBuildingLocation.Location = new System.Drawing.Point(20, 226);
            this.txtBuildingLocation.Name = "txtBuildingLocation";
            this.txtBuildingLocation.Size = new System.Drawing.Size(260, 31);
            this.txtBuildingLocation.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Building Location";
            // 
            // nmbApartmentsCount
            // 
            this.nmbApartmentsCount.Location = new System.Drawing.Point(786, 70);
            this.nmbApartmentsCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nmbApartmentsCount.Name = "nmbApartmentsCount";
            this.nmbApartmentsCount.Size = new System.Drawing.Size(88, 31);
            this.nmbApartmentsCount.TabIndex = 4;
            this.nmbApartmentsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(527, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Apartments Count";
            // 
            // nmbNormalParkingsCount
            // 
            this.nmbNormalParkingsCount.Location = new System.Drawing.Point(786, 119);
            this.nmbNormalParkingsCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nmbNormalParkingsCount.Name = "nmbNormalParkingsCount";
            this.nmbNormalParkingsCount.Size = new System.Drawing.Size(88, 31);
            this.nmbNormalParkingsCount.TabIndex = 5;
            this.nmbNormalParkingsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(679, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 48;
            this.label4.Text = "Normal";
            // 
            // nmbAdditionalPrikingsCount
            // 
            this.nmbAdditionalPrikingsCount.Location = new System.Drawing.Point(786, 168);
            this.nmbAdditionalPrikingsCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nmbAdditionalPrikingsCount.Name = "nmbAdditionalPrikingsCount";
            this.nmbAdditionalPrikingsCount.Size = new System.Drawing.Size(88, 31);
            this.nmbAdditionalPrikingsCount.TabIndex = 6;
            this.nmbAdditionalPrikingsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmbFloorCount);
            this.groupBox1.Controls.Add(this.txtSearchBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbBuildingId);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmbAdditionalPrikingsCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtBuildingName);
            this.groupBox1.Controls.Add(this.nmbNormalParkingsCount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBuildingId);
            this.groupBox1.Controls.Add(this.nmbApartmentsCount);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtBuildingLocation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(59, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 284);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Building Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 102;
            this.label7.Text = "Floor Count";
            // 
            // nmbFloorCount
            // 
            this.nmbFloorCount.Location = new System.Drawing.Point(302, 226);
            this.nmbFloorCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbFloorCount.Name = "nmbFloorCount";
            this.nmbFloorCount.Size = new System.Drawing.Size(101, 31);
            this.nmbFloorCount.TabIndex = 101;
            this.nmbFloorCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtSearchBox.Location = new System.Drawing.Point(637, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(237, 31);
            this.txtSearchBox.TabIndex = 100;
            this.txtSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.Enter += new System.EventHandler(this.txtSearchBox_Enter);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Additional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Parkings Count : ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 31;
            this.btnSearch.Location = new System.Drawing.Point(372, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 31);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 31;
            this.btnClose.Location = new System.Drawing.Point(372, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 31);
            this.btnClose.TabIndex = 38;
            this.btnClose.TabStop = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DGridBuildings
            // 
            this.DGridBuildings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridBuildings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGridBuildings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.DGridBuildings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGridBuildings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridBuildings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGridBuildings.ColumnHeadersHeight = 29;
            this.DGridBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGridBuildings.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGridBuildings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGridBuildings.Location = new System.Drawing.Point(59, 346);
            this.DGridBuildings.Name = "DGridBuildings";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridBuildings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGridBuildings.RowHeadersVisible = false;
            this.DGridBuildings.RowHeadersWidth = 51;
            this.DGridBuildings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            this.DGridBuildings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGridBuildings.RowTemplate.Height = 24;
            this.DGridBuildings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGridBuildings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGridBuildings.ShowEditingIcon = false;
            this.DGridBuildings.ShowRowErrors = false;
            this.DGridBuildings.Size = new System.Drawing.Size(902, 258);
            this.DGridBuildings.TabIndex = 100;
            this.DGridBuildings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridBuildings_CellContentClick);
            // 
            // FrmBuildingManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.DGridBuildings);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBuildingManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Buildings";
            this.Load += new System.EventHandler(this.FrmBuildingManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbApartmentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbNormalParkingsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbAdditionalPrikingsCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbFloorCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGridBuildings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBuildingId;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private System.Windows.Forms.TextBox txtBuildingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBuildingLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmbApartmentsCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nmbNormalParkingsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmbAdditionalPrikingsCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGridBuildings;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmbFloorCount;
    }
}