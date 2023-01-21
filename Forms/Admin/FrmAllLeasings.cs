using E_Apartments.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms.Admin
{
    public partial class FrmAllLeasings : Form
    {
        public FrmAllLeasings()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        /// <summary>Handles the Load event of the FrmAllLeasings control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmAllLeasings_Load(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();

                DGridLeasings.DataSource = _appDbContext.Leasings
                        .Select(g => new {
                            ID = g.LeasingId,
                            ApartmentID = g.ApartmentID,
                            Start = g.StartedDate,
                            End = g.EndDate,
                            Class = g.ClassID,
                            
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
