namespace E_Apartments.Forms.Admin
{
    partial class FrmMarkReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarkReservations));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentDue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReservationFee = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClassId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApartmentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCusId = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnLaese = new FontAwesome.Sharp.IconButton();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblCurrentDue);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblPaid);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtReservationFee);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtClassId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApartmentId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblCusId);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnLaese);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(814, 456);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservation Details";
            // 
            // lblCurrentDue
            // 
            this.lblCurrentDue.AutoSize = true;
            this.lblCurrentDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDue.Location = new System.Drawing.Point(606, 314);
            this.lblCurrentDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentDue.Name = "lblCurrentDue";
            this.lblCurrentDue.Size = new System.Drawing.Size(77, 28);
            this.lblCurrentDue.TabIndex = 159;
            this.lblCurrentDue.Text = "Current";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(579, 314);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 28);
            this.label12.TabIndex = 165;
            this.label12.Text = "Rs.";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(606, 272);
            this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(45, 25);
            this.lblPaid.TabIndex = 162;
            this.lblPaid.Text = "Paid";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(578, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 25);
            this.label11.TabIndex = 164;
            this.label11.Text = "Rs.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(606, 235);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 25);
            this.lblTotal.TabIndex = 160;
            this.lblTotal.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(579, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 25);
            this.label9.TabIndex = 163;
            this.label9.Text = "Rs.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 161;
            this.label10.Text = "Paid  : ";
            // 
            // txtReservationFee
            // 
            this.txtReservationFee.Location = new System.Drawing.Point(35, 311);
            this.txtReservationFee.Name = "txtReservationFee";
            this.txtReservationFee.ReadOnly = true;
            this.txtReservationFee.Size = new System.Drawing.Size(335, 31);
            this.txtReservationFee.TabIndex = 157;
            this.txtReservationFee.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 158;
            this.label8.Text = "Reservation Fee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 156;
            this.label7.Text = "Total : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 155;
            this.label6.Text = "Current Due : ";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Location = new System.Drawing.Point(445, 153);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(335, 31);
            this.dtpEnd.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 153;
            this.label5.Text = "End Date";
            // 
            // dtpStart
            // 
            this.dtpStart.Enabled = false;
            this.dtpStart.Location = new System.Drawing.Point(37, 153);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(335, 31);
            this.dtpStart.TabIndex = 152;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 151;
            this.label4.Text = "Start Date";
            // 
            // txtClassId
            // 
            this.txtClassId.Location = new System.Drawing.Point(37, 232);
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.ReadOnly = true;
            this.txtClassId.Size = new System.Drawing.Size(335, 31);
            this.txtClassId.TabIndex = 149;
            this.txtClassId.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 150;
            this.label3.Text = "Class ID";
            // 
            // txtApartmentId
            // 
            this.txtApartmentId.Location = new System.Drawing.Point(445, 74);
            this.txtApartmentId.Name = "txtApartmentId";
            this.txtApartmentId.ReadOnly = true;
            this.txtApartmentId.Size = new System.Drawing.Size(335, 31);
            this.txtApartmentId.TabIndex = 147;
            this.txtApartmentId.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 148;
            this.label2.Text = "Apartment ID";
            // 
            // lblCusId
            // 
            this.lblCusId.AutoSize = true;
            this.lblCusId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusId.Location = new System.Drawing.Point(220, 15);
            this.lblCusId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusId.Name = "lblCusId";
            this.lblCusId.Size = new System.Drawing.Size(46, 25);
            this.lblCusId.TabIndex = 145;
            this.lblCusId.Text = "C ID";
            this.lblCusId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancel.IconColor = System.Drawing.Color.White;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 25;
            this.btnCancel.Location = new System.Drawing.Point(35, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(335, 38);
            this.btnCancel.TabIndex = 138;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLaese
            // 
            this.btnLaese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(143)))), ((int)(((byte)(251)))));
            this.btnLaese.FlatAppearance.BorderSize = 0;
            this.btnLaese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaese.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnLaese.IconColor = System.Drawing.Color.White;
            this.btnLaese.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLaese.IconSize = 25;
            this.btnLaese.Location = new System.Drawing.Point(445, 385);
            this.btnLaese.Name = "btnLaese";
            this.btnLaese.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.btnLaese.Size = new System.Drawing.Size(335, 38);
            this.btnLaese.TabIndex = 137;
            this.btnLaese.Text = "Lease This";
            this.btnLaese.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLaese.UseVisualStyleBackColor = false;
            this.btnLaese.Click += new System.EventHandler(this.btnLaese_Click);
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(37, 74);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.ReadOnly = true;
            this.txtCusName.Size = new System.Drawing.Size(335, 31);
            this.txtCusName.TabIndex = 0;
            this.txtCusName.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 112;
            this.label1.Text = "Customer Name";
            // 
            // FrmMarkReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(868, 507);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMarkReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Reservation";
            this.Load += new System.EventHandler(this.FrmMarkReservations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApartmentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCusId;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnLaese;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCurrentDue;
        private System.Windows.Forms.TextBox txtReservationFee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}