﻿using E_Apartments.Data;
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

namespace E_Apartments.Forms.Clerk
{
    public partial class FrmCheckAvailability : Form
    {
        public FrmCheckAvailability()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;

        private void loadBuildingIds(string location)
        {
            try
            {
                if (location == null)
                {
                    _appDbContext = new AppDbContext();
                    var Ids = _appDbContext.Buildings.Select(c => c.BuildingId).ToList();
                    Ids.Insert(0, "(All)"); // add "-Select-" as the first item
                    cmbBuildingId.DataSource = Ids;
                }
                else if (location == "(All)")
                {
                    _appDbContext = new AppDbContext();
                    var Ids = _appDbContext.Buildings.Select(c => c.BuildingId).ToList();
                    Ids.Insert(0, "(All)"); // add "-Select-" as the first item
                    cmbBuildingId.DataSource = Ids;
                }
                else
                {
                    _appDbContext = new AppDbContext();
                    var Ids = _appDbContext.Buildings.Where(x => x.Location == location).Select(c => c.BuildingId).ToList();
                    //Ids.Insert(0, "(All)"); // add "-Select-" as the first item
                    cmbBuildingId.DataSource = Ids;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadClassIds()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var ids = _appDbContext.Classes.Select(c => c.ClassId).ToList();
                ids.Insert(0, "(All)");
                cmbClassId.DataSource = ids;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadLocations()
        {
            try
            {
                _appDbContext = new AppDbContext();
                var locations = _appDbContext.Buildings.Select(c => c.Location).ToList();
                locations.Insert(0, "(All)");
                cmbLocation.DataSource = locations;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void calculateFloorNumber(string buildingId)
        {
            try
            {
                if (buildingId != "(All)")
                {
                    var buildingFloorNumbers = _appDbContext.Buildings.Where(x => x.BuildingId == buildingId)
                                                                  .Select(x => x.FLoorCount)
                                                                  .FirstOrDefault();
                    cmbFloorNumber.DataSource = Enumerable.Range(1, buildingFloorNumbers).Take(buildingFloorNumbers).ToList();
                }
                else
                {
                    cmbFloorNumber.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void viewGrid()
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridApartments.DataSource = _appDbContext.Apartments
                    .Select(x => new { ID = x.ApartmentId, Floor = x.FloorNumber, Building = x.BuildingId, Location = x.Building.Location, Class = x.ClassId, Status = x.CustomerId == null ? "Available" : "Taken" })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCheckAvailability_Load(object sender, EventArgs e)
        {
            loadBuildingIds(null);
            loadLocations();
            loadClassIds();
            viewGrid();

            lblBuildingName.Text = string.Empty;
            lblClassName.Text = string.Empty;
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbLocation.SelectedIndex = 0;
            //cmbBuildingId.SelectedIndex = 0;
            cmbClassId.SelectedIndex = 0;
            //cmbFloorNumber.SelectedIndex = 0;
            viewGrid();
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadBuildingIds(cmbLocation.SelectedValue.ToString());
            calculateFloorNumber(cmbBuildingId.SelectedValue.ToString());
            if (cmbLocation.SelectedIndex != 0)
            {
                lblBuildingName.Text = "(" + _appDbContext.Buildings.Where(x => x.BuildingId == cmbBuildingId.SelectedValue.ToString()).Select(x => x.BuildingName).FirstOrDefault() + ")";
            }
            else
            {
                lblBuildingName.Text = string.Empty;
            }
        }

        private void cmbBuildingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuildingId.SelectedIndex != 0)
            {
                calculateFloorNumber(cmbBuildingId.SelectedValue.ToString());
                lblBuildingName.Text = "(" + _appDbContext.Buildings.Where(x => x.BuildingId == cmbBuildingId.SelectedValue.ToString()).Select(x => x.BuildingName).FirstOrDefault() + ")";
            }
            else
            {
                lblBuildingName.Text = string.Empty;
            }
        }

        private void cmbClassId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClassId.SelectedIndex != 0)
            {
                lblClassName.Text = "(" + _appDbContext.Classes.Where(x => x.ClassId == cmbClassId.SelectedValue.ToString()).Select(x => x.ClassName).FirstOrDefault() + ")";
            }
            else
            {
                lblClassName.Text = string.Empty;
            }
        }

        private void btnFindApt_Click(object sender, EventArgs e)
        {
            if (cmbBuildingId.SelectedIndex == 0 && cmbLocation.SelectedIndex == 0 && cmbClassId.SelectedIndex == 0)
            {
                //MessageBox.Show("cant");
                viewGrid();
            }
            else if (cmbClassId.SelectedIndex != 0 && cmbLocation.SelectedIndex == 0)
            {
                DGridApartments.DataSource = _appDbContext.Apartments.Where(x => x.ClassId == cmbClassId.Text)
                    .Select(x => new { ID = x.ApartmentId, Floor = x.FloorNumber, Building = x.BuildingId, Location = x.Building.Location, Class = x.ClassId, Status = x.CustomerId == null ? "Available" : "Taken" })
                    .ToList();

                DGridApartments.Refresh();
            }
            else if (cmbClassId.SelectedIndex == 0 && cmbLocation.SelectedIndex != 0)
            {
                var floorNmb = Convert.ToInt32(cmbFloorNumber.Text);
                if (floorNmb != null)
                {
                    var DSoarce = _appDbContext.Apartments.Where(x => x.BuildingId == cmbBuildingId.Text && x.FloorNumber == floorNmb)
                                  .Select(x => new { ID = x.ApartmentId, Floor = x.FloorNumber, Building = x.BuildingId, Location = x.Building.Location, Class = x.ClassId, Status = x.CustomerId == null ? "Available" : "Taken" })
                                  .ToList();

                    DGridApartments.DataSource = DSoarce;
                    DGridApartments.Refresh();
                }
                else
                {
                    //if there is no floor number
                }

            }
            else if (cmbClassId.SelectedIndex != 0 && cmbLocation.SelectedIndex != 0)
            {
                var floorNmb = Convert.ToInt32(cmbFloorNumber.Text);

                if (floorNmb != null)
                {
                    var DSoarce = _appDbContext.Apartments.Where(x => x.BuildingId == cmbBuildingId.Text && x.ClassId == cmbClassId.Text && x.FloorNumber == floorNmb)
                   .Select(x => new { ID = x.ApartmentId, Floor = x.FloorNumber, Building = x.BuildingId, Location = x.Building.Location, Class = x.ClassId, Status = x.CustomerId == null ? "Available" : "Taken" })
                   .ToList();

                    DGridApartments.DataSource = DSoarce;
                    DGridApartments.Refresh();
                }
                else
                {
                    //if there is no floor number
                }

            }
        }
    }
}