using E_Apartments.Data;
using E_Apartments.Forms.Customer;
using E_Apartments.Models;
using E_Apartments.Validators;
using FluentValidation.Results;
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
    public partial class FrmCusOccupents : Form
    {
        public FrmCusOccupents()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        public Guid CustomerId;

        /// <summary>Views the grid.</summary>
        private void viewGrid()   
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridDependents.DataSource = _appDbContext.Dependents.Where(x => x.CustomerId == CustomerId)
                    .Select(x => new { Name = x.DependentName, Relation = x.Relationship, Age = x.Age })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>Handles the Load event of the FrmCusOccupents control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmCusOccupents_Load(object sender, EventArgs e)
        {
            try
            {
                CustomerId = FrmCusDashboard.CustomerId;
                _appDbContext = new AppDbContext();
                var foundCustomer = _appDbContext.CustomerSaves.FirstOrDefault(x => x.CustomerId == CustomerId);
                if (foundCustomer != null)
                {
                    txtCusAddress.Text = foundCustomer.CustomerAddress;
                    txtCusEmail.Text = foundCustomer.CustomerEmail;
                    txtCusName.Text = foundCustomer.CustomerName;
                    nmbCusAge.Value = foundCustomer.CustomerAge;
                    txtCusPhone.Text = foundCustomer.CustomerPhone;
                    txtNic.Text = foundCustomer.NICPassport;
                    txtPassword.Text = Encrypt.Decrypting(foundCustomer.Password);
                }
                else
                {
                    MessageBox.Show("Customer Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                viewGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>Handles the Click event of the btnUpdate control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate Fields
                var customer = new CustomerSave();
                customer.CustomerId = CustomerId;
                customer.CustomerName = txtCusName.Text;
                customer.CustomerAge = Convert.ToInt32(nmbCusAge.Value);
                customer.CustomerPhone = txtCusPhone.Text;
                customer.CustomerEmail = txtCusEmail.Text;
                customer.CustomerAddress = txtCusAddress.Text;
                customer.Password = txtPassword.Text;
                customer.NICPassport = txtNic.Text;

                CustomerValidator Cusvalidator = new CustomerValidator();
                ValidationResult Cusresults = Cusvalidator.Validate(customer);
                if (!Cusresults.IsValid)
                {
                    foreach (var failure in Cusresults.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        _appDbContext = new AppDbContext();
                        //Get existing class from database
                        var customerToUpdate = _appDbContext.CustomerSaves.FirstOrDefault(c => c.CustomerId == CustomerId);
                        if (customerToUpdate != null)
                        {
                            customerToUpdate.CustomerName = txtCusName.Text;
                            customerToUpdate.CustomerAge = Convert.ToInt32(nmbCusAge.Value);
                            customerToUpdate.CustomerPhone = txtCusPhone.Text;
                            customerToUpdate.CustomerEmail = txtCusEmail.Text;
                            customerToUpdate.CustomerAddress = txtCusAddress.Text;
                            customerToUpdate.UpdatedAt = DateTime.Now;
                            customerToUpdate.ReferenceNumber = CustomerId.ToString();
                            customerToUpdate.Password = Encrypt.Encrypting(txtPassword.Text);
                            customerToUpdate.NICPassport = txtNic.Text;

                            _appDbContext.Entry(customerToUpdate).State = System.Data.Entity.EntityState.Modified;
                            _appDbContext.SaveChanges();
                            //MessageBox.Show("Customer Updated");
                        }
                        else
                        {
                            MessageBox.Show("Customer Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                        _appDbContext = new AppDbContext();
                        var userToUpdate = _appDbContext.Users.FirstOrDefault(x => x.Email == customerToUpdate.CustomerEmail && x.UserType == "Customer");
                        if (userToUpdate != null)
                        {
                            userToUpdate.Password = customerToUpdate.Password;

                            _appDbContext.Entry(userToUpdate).State = System.Data.Entity.EntityState.Modified;
                            _appDbContext.SaveChanges();
                            //MessageBox.Show("User Updated");
                        }
                        else
                        {
                            MessageBox.Show("User Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Your Details Successfully Update.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                        viewGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Click event of the icoShowPw control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void icoShowPw_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            icoHidePw.Visible = true;
            icoShowPw.Visible = false;
        }

        /// <summary>Handles the Click event of the icoHidePw control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void icoHidePw_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            icoHidePw.Visible = false;
            icoShowPw.Visible = true;
        }
    }
}
