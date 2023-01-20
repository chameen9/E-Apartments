namespace E_Apartments.Forms.Admin
{
    partial class FrmManageApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageApplications));
            this.btnExportPdf = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.DGridApplications = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGridApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnExportPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPdf.FlatAppearance.BorderSize = 0;
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnExportPdf.IconColor = System.Drawing.Color.White;
            this.btnExportPdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportPdf.IconSize = 25;
            this.btnExportPdf.Location = new System.Drawing.Point(855, 51);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExportPdf.Size = new System.Drawing.Size(114, 31);
            this.btnExportPdf.TabIndex = 112;
            this.btnExportPdf.Text = "Export";
            this.btnExportPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportPdf.UseVisualStyleBackColor = false;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 25);
            this.label11.TabIndex = 111;
            this.label11.Text = "Pending Applications";
            // 
            // DGridApplications
            // 
            this.DGridApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGridApplications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGridApplications.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.DGridApplications.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGridApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGridApplications.ColumnHeadersHeight = 29;
            this.DGridApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGridApplications.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGridApplications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGridApplications.Location = new System.Drawing.Point(67, 96);
            this.DGridApplications.Name = "DGridApplications";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGridApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGridApplications.RowHeadersVisible = false;
            this.DGridApplications.RowHeadersWidth = 51;
            this.DGridApplications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            this.DGridApplications.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGridApplications.RowTemplate.Height = 24;
            this.DGridApplications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGridApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGridApplications.ShowEditingIcon = false;
            this.DGridApplications.ShowRowErrors = false;
            this.DGridApplications.Size = new System.Drawing.Size(902, 507);
            this.DGridApplications.TabIndex = 110;
            this.DGridApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridApplications_CellContentClick);
            // 
            // FrmManageApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DGridApplications);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmManageApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Applications";
            this.Load += new System.EventHandler(this.FrmManageApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGridApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnExportPdf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DGridApplications;
    }
}