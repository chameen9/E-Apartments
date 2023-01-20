using E_Apartments.Data;
using E_Apartments.Forms.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms.CusForms
{
    public partial class FrmCusApplications : Form
    {
        public FrmCusApplications()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        private void FrmCusApplications_Load(object sender, EventArgs e)
        {
            Guid cusId = FrmCusDashboard.cusIdApplication;
            
            try
            {
                _appDbContext = new AppDbContext();
                DGridApplications.DataSource = _appDbContext.AptApplication
                    .Where(r => r.CustomerId == cusId)
                    .Select(x => new { Status = x.Status, Apartment = x.ApartmentId, From = x.ResrvedFrom, To = x.ResrvedTo, AddPKID = x.AddParkingId })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
