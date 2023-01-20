using E_Apartments.Data;
using E_Apartments.Models;
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
    public partial class FrmManageAdditionalParkings : Form
    {
        public FrmManageAdditionalParkings()
        {
            InitializeComponent();

            //cmbParkingId.SelectedIndexChanged += new System.EventHandler(cmbParkingId_SelectedIndexChanged);
        }
        AppDbContext _appDbContext;


        private void loadBuildingIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var classIds = _appDbContext.Buildings.Select(c => c.BuildingId).ToList();
                classIds.Insert(0, "-Select-"); // add "-Select-" as the first item
                cmbBuildingId.DataSource = classIds;
                cmbFilterBuilding.DataSource = classIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void loadParkingStatuses()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var statuses = _appDbContext.AdditionalParkings.Select(p => p.AddStatus).Distinct().ToList();
                statuses.Insert(0, "-Select-");
                cmbFilterStatus.DataSource = statuses;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void ViewGrid()
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridParkings.DataSource = _appDbContext.AdditionalParkings
                    .Select(x => new { ID = x.AddParkingId, Building_ID = x.BuildingId, Status = x.AddStatus })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clear()
        {
            nmbParkingId.Value = 0;
            cmbBuildingId.SelectedIndex = 0;
            cmbFilterBuilding.SelectedIndex= 0;
            cmbFilterStatus.SelectedIndex= 0;
            
        }
        private void fetchDataToFields(string key, int selectedIndex)
        {
            try
            {
                _appDbContext = new AppDbContext();
                var selcetedParkingId = Convert.ToInt32(key);
                var selectedParking = _appDbContext.AdditionalParkings.FirstOrDefault(c => c.AddParkingId == selcetedParkingId);
                if (selectedParking != null)
                {
                    nmbParkingId.Value = selectedParking.AddParkingId;
                    cmbBuildingId.Text = selectedParking.BuildingId;

                    
                }
                else if (selectedIndex == 0)
                {
                    clear();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void filterDGrid()
        {
            try
            {
                if (cmbFilterBuilding.SelectedItem != null && cmbFilterStatus.SelectedItem != null)
                {
                    _appDbContext = new AppDbContext();
                    string FilterbuildingId = cmbFilterBuilding.SelectedItem.ToString();
                    string status = cmbFilterStatus.SelectedItem.ToString();
                    if (FilterbuildingId != "-Select-" && status != "-Select-")
                    {
                        DGridParkings.DataSource = _appDbContext.AdditionalParkings
                            .Where(p => p.BuildingId == FilterbuildingId && p.AddStatus == status)
                            .Select(x => new { ID = x.AddParkingId, Building_ID = x.BuildingId, Status = x.AddStatus })
                            .ToList();
                    }
                    else if (FilterbuildingId != "-Select-" && status == "-Select-")
                    {
                        DGridParkings.DataSource = _appDbContext.AdditionalParkings
                            .Where(p => p.BuildingId == FilterbuildingId)
                            .Select(x => new { ID = x.AddParkingId, Building_ID = x.BuildingId, Status = x.AddStatus })
                            .ToList();
                    }
                    else if (FilterbuildingId == "-Select-" && status != "-Select-")
                    {
                        DGridParkings.DataSource = _appDbContext.AdditionalParkings
                            .Where(p => p.AddStatus == status)
                            .Select(x => new { ID = x.AddParkingId, Building_ID = x.BuildingId, Status = x.AddStatus })
                            .ToList();
                    }
                    else
                    {
                        ViewGrid();
                    }
                }
                else
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmManageAdditionalParkings_Load(object sender, EventArgs e)
        {
            loadParkingStatuses();
            loadBuildingIds();
            clear();
            ViewGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var buildingAdditionalParkingsCount = _appDbContext.Buildings.Where(x => x.BuildingId == cmbBuildingId.Text).Select(x => x.AdditionalParkingsCount).FirstOrDefault();

                var addedParkingsCount = _appDbContext.AdditionalParkings.Where(x => x.BuildingId == cmbBuildingId.Text).Count();

                int addPkId = (int)nmbParkingId.Value;
                var existingParkingId = _appDbContext.AdditionalParkings.Where(x => x.AddParkingId == addPkId).FirstOrDefault();

                if (existingParkingId != null)
                {
                    MessageBox.Show("Building ID Aleready Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nmbParkingId.Value == 0)
                {
                    MessageBox.Show("Please Enter a Parking Id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbBuildingId.SelectedIndex == 0)
                {
                    MessageBox.Show("Please Select a Building", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (buildingAdditionalParkingsCount == addedParkingsCount)
                {
                    MessageBox.Show("You already entered the Maximum Limit of the Parkings in that Building.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    _appDbContext = new AppDbContext();
                    var addParking = new AdditionalParking();
                    addParking.AddParkingId = addPkId;
                    addParking.BuildingId = cmbBuildingId.Text.ToString();
                    addParking.AddStatus = "Available";

                    _appDbContext.AdditionalParkings.Add(addParking);
                    _appDbContext.SaveChanges();
                    //MessageBox.Show("Saved");
                    clear();
                    loadBuildingIds();
                    ViewGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbParkingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbFilterBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDGrid();
        }

        private void cmbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterDGrid();
        }
    }
}
