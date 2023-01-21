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
    public partial class FrmCusMadeReservations : Form
    {
        public FrmCusMadeReservations()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        /// <summary>Handles the Load event of the FrmCusMadeReservations control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmCusMadeReservations_Load(object sender, EventArgs e)
        {
            Guid cusId = FrmCusDashboard.cusIdforReservation;
            //var Resrvations = _appDbContext.Reservation.FirstOrDefault(r => r.CustomerId == cusId);

            try
            {
                _appDbContext = new AppDbContext();
                DGridReservations.DataSource = _appDbContext.Reservation
                    .Where(r => r.CustomerId == cusId)
                    .Select(x => new { Status = x.Status, Apartment = x.ApartmentId, From = x.ResrvedFrom, To = x.ResrvedTo })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGridReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
