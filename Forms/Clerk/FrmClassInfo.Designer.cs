namespace E_Apartments.Forms.Clerk
{
    partial class FrmClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClassInfo));
            this.cmbClassID = new System.Windows.Forms.ComboBox();
            this.btnSearch = new FontAwesome.Sharp.IconPictureBox();
            this.nmbCommonBathroomsCount = new System.Windows.Forms.NumericUpDown();
            this.nmbRoomsWithAttachedBathroomsCount = new System.Windows.Forms.NumericUpDown();
            this.nmbMaxOccuoentsCount = new System.Windows.Forms.NumericUpDown();
            this.nmbServentRoomsCount = new System.Windows.Forms.NumericUpDown();
            this.nmbServentBathroomCount = new System.Windows.Forms.NumericUpDown();
            this.nmbCommonRoomsCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdditionalParkingFee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonthlyInstallment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNonRefundableReservationFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRefundableAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCommonBathroomsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRoomsWithAttachedBathroomsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxOccuoentsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbServentRoomsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbServentBathroomCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCommonRoomsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClassID
            // 
            this.cmbClassID.FormattingEnabled = true;
            this.cmbClassID.Location = new System.Drawing.Point(87, 79);
            this.cmbClassID.Name = "cmbClassID";
            this.cmbClassID.Size = new System.Drawing.Size(327, 33);
            this.cmbClassID.TabIndex = 65;
            this.cmbClassID.SelectedIndexChanged += new System.EventHandler(this.cmbClassID_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 36;
            this.btnSearch.Location = new System.Drawing.Point(420, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 36);
            this.btnSearch.TabIndex = 62;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // nmbCommonBathroomsCount
            // 
            this.nmbCommonBathroomsCount.Location = new System.Drawing.Point(580, 564);
            this.nmbCommonBathroomsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbCommonBathroomsCount.Name = "nmbCommonBathroomsCount";
            this.nmbCommonBathroomsCount.Size = new System.Drawing.Size(371, 31);
            this.nmbCommonBathroomsCount.TabIndex = 60;
            // 
            // nmbRoomsWithAttachedBathroomsCount
            // 
            this.nmbRoomsWithAttachedBathroomsCount.Location = new System.Drawing.Point(580, 370);
            this.nmbRoomsWithAttachedBathroomsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbRoomsWithAttachedBathroomsCount.Name = "nmbRoomsWithAttachedBathroomsCount";
            this.nmbRoomsWithAttachedBathroomsCount.Size = new System.Drawing.Size(371, 31);
            this.nmbRoomsWithAttachedBathroomsCount.TabIndex = 59;
            // 
            // nmbMaxOccuoentsCount
            // 
            this.nmbMaxOccuoentsCount.Location = new System.Drawing.Point(580, 79);
            this.nmbMaxOccuoentsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbMaxOccuoentsCount.Name = "nmbMaxOccuoentsCount";
            this.nmbMaxOccuoentsCount.Size = new System.Drawing.Size(371, 31);
            this.nmbMaxOccuoentsCount.TabIndex = 58;
            // 
            // nmbServentRoomsCount
            // 
            this.nmbServentRoomsCount.Location = new System.Drawing.Point(580, 273);
            this.nmbServentRoomsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbServentRoomsCount.Name = "nmbServentRoomsCount";
            this.nmbServentRoomsCount.Size = new System.Drawing.Size(371, 31);
            this.nmbServentRoomsCount.TabIndex = 57;
            // 
            // nmbServentBathroomCount
            // 
            this.nmbServentBathroomCount.Location = new System.Drawing.Point(580, 176);
            this.nmbServentBathroomCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbServentBathroomCount.Name = "nmbServentBathroomCount";
            this.nmbServentBathroomCount.Size = new System.Drawing.Size(371, 31);
            this.nmbServentBathroomCount.TabIndex = 56;
            // 
            // nmbCommonRoomsCount
            // 
            this.nmbCommonRoomsCount.Location = new System.Drawing.Point(580, 467);
            this.nmbCommonRoomsCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmbCommonRoomsCount.Name = "nmbCommonRoomsCount";
            this.nmbCommonRoomsCount.Size = new System.Drawing.Size(371, 31);
            this.nmbCommonRoomsCount.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(575, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 25);
            this.label12.TabIndex = 54;
            this.label12.Text = "Allowed Max Occupents";
            // 
            // txtAdditionalParkingFee
            // 
            this.txtAdditionalParkingFee.Location = new System.Drawing.Point(85, 563);
            this.txtAdditionalParkingFee.Name = "txtAdditionalParkingFee";
            this.txtAdditionalParkingFee.Size = new System.Drawing.Size(371, 31);
            this.txtAdditionalParkingFee.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 25);
            this.label8.TabIndex = 52;
            this.label8.Text = "Additional Parking Fee";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "Servant\'s Room Count";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(575, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 25);
            this.label10.TabIndex = 50;
            this.label10.Text = "Servant\'s Bathroom Count";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(575, 439);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "Common Rooms Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Common Bathrooms Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Rooms With Attached Bathrooms";
            // 
            // txtMonthlyInstallment
            // 
            this.txtMonthlyInstallment.Location = new System.Drawing.Point(85, 466);
            this.txtMonthlyInstallment.Name = "txtMonthlyInstallment";
            this.txtMonthlyInstallment.Size = new System.Drawing.Size(371, 31);
            this.txtMonthlyInstallment.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Monthly Installment";
            // 
            // txtNonRefundableReservationFee
            // 
            this.txtNonRefundableReservationFee.Location = new System.Drawing.Point(85, 369);
            this.txtNonRefundableReservationFee.Name = "txtNonRefundableReservationFee";
            this.txtNonRefundableReservationFee.Size = new System.Drawing.Size(371, 31);
            this.txtNonRefundableReservationFee.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Non-Refundable Reservation Fee";
            // 
            // txtRefundableAmount
            // 
            this.txtRefundableAmount.Location = new System.Drawing.Point(85, 272);
            this.txtRefundableAmount.Name = "txtRefundableAmount";
            this.txtRefundableAmount.Size = new System.Drawing.Size(371, 31);
            this.txtRefundableAmount.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Refundable Amount";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(85, 176);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(371, 31);
            this.txtClassName.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Class Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Class ID";
            // 
            // FrmClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.cmbClassID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.nmbCommonBathroomsCount);
            this.Controls.Add(this.nmbRoomsWithAttachedBathroomsCount);
            this.Controls.Add(this.nmbMaxOccuoentsCount);
            this.Controls.Add(this.nmbServentRoomsCount);
            this.Controls.Add(this.nmbServentBathroomCount);
            this.Controls.Add(this.nmbCommonRoomsCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAdditionalParkingFee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonthlyInstallment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNonRefundableReservationFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRefundableAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmClassInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Info";
            this.Load += new System.EventHandler(this.FrmClassInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCommonBathroomsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbRoomsWithAttachedBathroomsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbMaxOccuoentsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbServentRoomsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbServentBathroomCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbCommonRoomsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClassID;
        private FontAwesome.Sharp.IconPictureBox btnSearch;
        private System.Windows.Forms.NumericUpDown nmbCommonBathroomsCount;
        private System.Windows.Forms.NumericUpDown nmbRoomsWithAttachedBathroomsCount;
        private System.Windows.Forms.NumericUpDown nmbMaxOccuoentsCount;
        private System.Windows.Forms.NumericUpDown nmbServentRoomsCount;
        private System.Windows.Forms.NumericUpDown nmbServentBathroomCount;
        private System.Windows.Forms.NumericUpDown nmbCommonRoomsCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAdditionalParkingFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthlyInstallment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNonRefundableReservationFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRefundableAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}