namespace E_Apartments.Forms.Admin
{
    partial class FrmApartmentManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApartmentManage));
            this.DGridApartments = new System.Windows.Forms.DataGridView();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.cmbApartmentID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbClassId = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbParkingId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBuildingId = new System.Windows.Forms.ComboBox();
            this.cmbFloorNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApartmentId = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGridApartments)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // DGridApartments
            // 
            this.DGridApartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridApartments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGridApartments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.DGridApartments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGridApartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridApartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGridApartments.ColumnHeadersHeight = 29;
            this.DGridApartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGridApartments.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGridApartments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGridApartments.Location = new System.Drawing.Point(64, 336);
            this.DGridApartments.Name = "DGridApartments";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridApartments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGridApartments.RowHeadersVisible = false;
            this.DGridApartments.RowHeadersWidth = 51;
            this.DGridApartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            this.DGridApartments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGridApartments.RowTemplate.Height = 24;
            this.DGridApartments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGridApartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGridApartments.ShowEditingIcon = false;
            this.DGridApartments.ShowRowErrors = false;
            this.DGridApartments.Size = new System.Drawing.Size(902, 270);
            this.DGridApartments.TabIndex = 102;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.txtSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBox.ForeColor = System.Drawing.Color.White;
            this.txtSearchBox.Location = new System.Drawing.Point(532, 21);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(342, 31);
            this.txtSearchBox.TabIndex = 100;
            this.txtSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            this.txtSearchBox.Enter += new System.EventHandler(this.txtSearchBox_Enter);
            this.txtSearchBox.Leave += new System.EventHandler(this.txtSearchBox_Leave);
            // 
            // cmbApartmentID
            // 
            this.cmbApartmentID.FormattingEnabled = true;
            this.cmbApartmentID.IntegralHeight = false;
            this.cmbApartmentID.Location = new System.Drawing.Point(20, 70);
            this.cmbApartmentID.MaxDropDownItems = 10;
            this.cmbApartmentID.Name = "cmbApartmentID";
            this.cmbApartmentID.Size = new System.Drawing.Size(344, 33);
            this.cmbApartmentID.TabIndex = 1;
            this.cmbApartmentID.Visible = false;
            this.cmbApartmentID.SelectedIndexChanged += new System.EventHandler(this.cmbApartmentID_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.lblBuildingName);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cmbClassId);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbParkingId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBuildingId);
            this.groupBox1.Controls.Add(this.cmbFloorNumber);
            this.groupBox1.Controls.Add(this.txtSearchBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbApartmentID);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApartmentId);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(64, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 284);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apartment Details";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(151, 200);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(59, 25);
            this.lblClassName.TabIndex = 109;
            this.lblClassName.Text = "Name";
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Location = new System.Drawing.Point(151, 120);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(59, 25);
            this.lblBuildingName.TabIndex = 108;
            this.lblBuildingName.Text = "Name";
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
            // cmbClassId
            // 
            this.cmbClassId.FormattingEnabled = true;
            this.cmbClassId.IntegralHeight = false;
            this.cmbClassId.Location = new System.Drawing.Point(20, 228);
            this.cmbClassId.MaxDropDownItems = 10;
            this.cmbClassId.Name = "cmbClassId";
            this.cmbClassId.Size = new System.Drawing.Size(383, 33);
            this.cmbClassId.TabIndex = 107;
            this.cmbClassId.SelectedIndexChanged += new System.EventHandler(this.cmbClassId_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 106;
            this.label2.Text = "Class ID";
            // 
            // cmbParkingId
            // 
            this.cmbParkingId.FormattingEnabled = true;
            this.cmbParkingId.IntegralHeight = false;
            this.cmbParkingId.Location = new System.Drawing.Point(669, 70);
            this.cmbParkingId.MaxDropDownItems = 10;
            this.cmbParkingId.Name = "cmbParkingId";
            this.cmbParkingId.Size = new System.Drawing.Size(205, 33);
            this.cmbParkingId.TabIndex = 105;
            this.cmbParkingId.SelectedIndexChanged += new System.EventHandler(this.cmbParkingId_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 104;
            this.label3.Text = "Parking ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbBuildingId
            // 
            this.cmbBuildingId.FormattingEnabled = true;
            this.cmbBuildingId.IntegralHeight = false;
            this.cmbBuildingId.Location = new System.Drawing.Point(20, 148);
            this.cmbBuildingId.MaxDropDownItems = 10;
            this.cmbBuildingId.Name = "cmbBuildingId";
            this.cmbBuildingId.Size = new System.Drawing.Size(383, 33);
            this.cmbBuildingId.TabIndex = 103;
            this.cmbBuildingId.SelectedIndexChanged += new System.EventHandler(this.cmbBuildingId_SelectedIndexChanged);
            // 
            // cmbFloorNumber
            // 
            this.cmbFloorNumber.FormattingEnabled = true;
            this.cmbFloorNumber.IntegralHeight = false;
            this.cmbFloorNumber.Location = new System.Drawing.Point(669, 148);
            this.cmbFloorNumber.MaxDropDownItems = 10;
            this.cmbFloorNumber.Name = "cmbFloorNumber";
            this.cmbFloorNumber.Size = new System.Drawing.Size(205, 33);
            this.cmbFloorNumber.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Floor Number";
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Building ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Apartment Id";
            // 
            // txtApartmentId
            // 
            this.txtApartmentId.Location = new System.Drawing.Point(20, 70);
            this.txtApartmentId.Name = "txtApartmentId";
            this.txtApartmentId.Size = new System.Drawing.Size(344, 31);
            this.txtApartmentId.TabIndex = 0;
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
            // FrmApartmentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.DGridApartments);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmApartmentManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Apartments";
            this.Load += new System.EventHandler(this.FrmApartmentManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridApartments)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGridApartments;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ComboBox cmbApartmentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApartmentId;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.ComboBox cmbBuildingId;
        private System.Windows.Forms.ComboBox cmbFloorNumber;
        private System.Windows.Forms.ComboBox cmbParkingId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClassId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblBuildingName;
    }
}