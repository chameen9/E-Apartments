using E_Apartments.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms.Admin
{
    public partial class FrmManageCustomers : Form
    {
        public FrmManageCustomers()
        {
            InitializeComponent();
            
        }

        AppDbContext _appDbContext;
        /// <summary>Handles the Load event of the FrmManageCustomers control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmManageCustomers_Load(object sender, EventArgs e)
        {
            try
            {

                _appDbContext = new AppDbContext();

                DGridCustomers.DataSource = _appDbContext.CustomerSaves
                        .Select(g => new {
                            Name = g.CustomerName,
                            Email = g.CustomerEmail,
                            NIC = g.NICPassport,
                            LeasingID = g.LeasingId

                        })
                        .ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
