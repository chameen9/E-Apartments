using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms
{
    public partial class FrmCreateLease : Form
    {
        public FrmCreateLease()
        {
            InitializeComponent();

            //ToolTips
            ToolTip tooltip = new ToolTip();
            Control[] labels = { lblCl1, lblCl2, lblCl3, lblCl4, lblCl5, lblCl6, lblCl7, lblCl8, lblCl9 };
            string[] tooltips = { 
                "Allowed Max Occupents Count",
                "Refundable Amount (Rs)",
                "Monthly Installment Fee (Rs)",
                "Rooms With Attached Bathrooms",
                "Comman Bathrooms",
                "Comman Rooms",
                "Servant's Bathrooms",
                "Servant's Rooms",
                "Additional Parking Fee (Per 1)",
            };

            for (int i = 0; i < labels.Length; i++)
            {
                tooltip.SetToolTip(labels[i], tooltips[i]);
            }
        }
        public static Guid LeaseId = Guid.NewGuid();
        private void FrmCreateLease_Load(object sender, EventArgs e)
        {
            txtCusID.Text = FrmAddCustomer.customerId.ToString();
            //txtCusName.Text = FrmAddCustomer.customerName.ToString();
            txtLeaseId.Text = LeaseId.ToString();
        }
    }
}
