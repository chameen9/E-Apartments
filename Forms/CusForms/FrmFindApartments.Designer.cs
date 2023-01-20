namespace E_Apartments.Forms.Customer_Forms
{
    partial class FrmFindApartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindApartments));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearFilters = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.btnFindApt = new FontAwesome.Sharp.IconButton();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.cmbClassId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBuildingId = new System.Windows.Forms.ComboBox();
            this.cmbFloorNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DGridApartments = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridApartments)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbLocation);
            this.groupBox1.Controls.Add(this.btnFindApt);
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.lblBuildingName);
            this.groupBox1.Controls.Add(this.cmbClassId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBuildingId);
            this.groupBox1.Controls.Add(this.cmbFloorNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(64, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 284);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find an Apartment";
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnClearFilters.FlatAppearance.BorderSize = 0;
            this.btnClearFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilters.IconChar = FontAwesome.Sharp.IconChar.TextSlash;
            this.btnClearFilters.IconColor = System.Drawing.Color.White;
            this.btnClearFilters.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClearFilters.IconSize = 25;
            this.btnClearFilters.Location = new System.Drawing.Point(31, 225);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Padding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnClearFilters.Size = new System.Drawing.Size(342, 38);
            this.btnClearFilters.TabIndex = 114;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFilters.UseVisualStyleBackColor = false;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 112;
            this.label1.Text = "Selected Location";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.IntegralHeight = false;
            this.cmbLocation.Location = new System.Drawing.Point(31, 70);
            this.cmbLocation.MaxDropDownItems = 10;
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(342, 33);
            this.cmbLocation.TabIndex = 111;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // btnFindApt
            // 
            this.btnFindApt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnFindApt.FlatAppearance.BorderSize = 0;
            this.btnFindApt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindApt.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnFindApt.IconColor = System.Drawing.Color.White;
            this.btnFindApt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindApt.IconSize = 25;
            this.btnFindApt.Location = new System.Drawing.Point(532, 225);
            this.btnFindApt.Name = "btnFindApt";
            this.btnFindApt.Padding = new System.Windows.Forms.Padding(85, 0, 0, 0);
            this.btnFindApt.Size = new System.Drawing.Size(342, 38);
            this.btnFindApt.TabIndex = 110;
            this.btnFindApt.Text = "Find";
            this.btnFindApt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindApt.UseVisualStyleBackColor = false;
            this.btnFindApt.Click += new System.EventHandler(this.btnFindApt_Click);
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(710, 42);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(59, 25);
            this.lblClassName.TabIndex = 109;
            this.lblClassName.Text = "Name";
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Location = new System.Drawing.Point(179, 120);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(59, 25);
            this.lblBuildingName.TabIndex = 108;
            this.lblBuildingName.Text = "Name";
            // 
            // cmbClassId
            // 
            this.cmbClassId.FormattingEnabled = true;
            this.cmbClassId.IntegralHeight = false;
            this.cmbClassId.Location = new System.Drawing.Point(532, 70);
            this.cmbClassId.MaxDropDownItems = 10;
            this.cmbClassId.Name = "cmbClassId";
            this.cmbClassId.Size = new System.Drawing.Size(342, 33);
            this.cmbClassId.TabIndex = 107;
            this.cmbClassId.SelectedIndexChanged += new System.EventHandler(this.cmbClassId_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 106;
            this.label2.Text = "Selected Class";
            // 
            // cmbBuildingId
            // 
            this.cmbBuildingId.FormattingEnabled = true;
            this.cmbBuildingId.IntegralHeight = false;
            this.cmbBuildingId.Location = new System.Drawing.Point(31, 148);
            this.cmbBuildingId.MaxDropDownItems = 10;
            this.cmbBuildingId.Name = "cmbBuildingId";
            this.cmbBuildingId.Size = new System.Drawing.Size(342, 33);
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
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Floor Number :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Selected Building";
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
            this.DGridApartments.Location = new System.Drawing.Point(64, 355);
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
            this.DGridApartments.TabIndex = 103;
            this.DGridApartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridApartments_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 115;
            this.label3.Text = "Results :";
            // 
            // FrmFindApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGridApartments);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFindApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFindApartments";
            this.Load += new System.EventHandler(this.FrmFindApartments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGridApartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.ComboBox cmbClassId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBuildingId;
        private System.Windows.Forms.ComboBox cmbFloorNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnFindApt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLocation;
        private FontAwesome.Sharp.IconButton btnClearFilters;
        private System.Windows.Forms.DataGridView DGridApartments;
        private System.Windows.Forms.Label label3;
    }
}