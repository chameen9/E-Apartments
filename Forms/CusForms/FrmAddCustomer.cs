using E_Apartments.Data;
using E_Apartments.Models;
using E_Apartments.Validators;
using FluentValidation.Results;
using Microsoft.VisualStudio.Services.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = E_Apartments.Models.User;

namespace E_Apartments.Forms
{
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();

            cmbDepRelation.SelectedIndex = 0;

            //adding a event to checktextchange
            txtDepName.TextChanged += BtnStatusChangeEvent;
            nmbDepAge.ValueChanged += BtnStatusChangeEvent;
            cmbDepRelation.SelectedIndexChanged += BtnStatusChangeEvent;
        }
        //Global varibles
        AppDbContext _appDbContext;

        DBQueries dtbq = new DBQueries();

        // Public properties
        public static Guid customerId;
        public static string customerName;
        public string existingNIC;

        public string customerMailAddress;

        public Guid DependentId;

        public static int OccupentsCount;


        // Custom Methods

        /// <summary>Erases the customer details.</summary>
        /// <param name="clearCusName">if set to <c>true</c> [clear cus name].</param>
        private void EraseCustomerDetails(bool clearCusName)
        {
            if (clearCusName)
            {
                txtCusName.Text = string.Empty;
                txtCusName.Focus();
            }
            else
            {
                txtDepName.Focus();
            }
            nmbCusAge.Value = 1;
            txtCusEmail.Text = string.Empty;
            txtCusPhone.Text = string.Empty;
            txtCusNIC.Text = string.Empty;
            txtCusAddress.Text = string.Empty;
        }

        /// <summary>Customers the data fields status.</summary>
        /// <param name="ActiveStatus">if set to <c>true</c> [active status].</param>
        private void CustomerDataFieldsStatus(bool ActiveStatus)
        {
            txtCusName.Enabled = ActiveStatus;
            nmbCusAge.Enabled = ActiveStatus;
            txtCusEmail.Enabled = ActiveStatus;
            txtCusPhone.Enabled = ActiveStatus;
            txtCusNIC.Enabled = ActiveStatus;
            txtCusAddress.Enabled = ActiveStatus;
            btnAddCustomer.Enabled = ActiveStatus;
            btnClear.Enabled = ActiveStatus;
        }

        /// <summary>Shows the datain grid with details.</summary>
        private void ShowDatainGridWithDetails()   // get and show extracted data from datagrid
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridDependents.DataSource = _appDbContext.Dependents.Where(x => x.CustomerId == customerId)
                    .Select(x => new { Name = x.DependentName, Relation = x.Relationship, Age = x.Age })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Shows the datain grid without details.</summary>
        private void ShowDatainGridWithoutDetails() // get and show columns from datagrid
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridDependents.DataSource = _appDbContext.Dependents.Where(x => x.CustomerId == Guid.NewGuid())
                    .Select(x => new { Name = x.DependentName, Relation = x.Relationship, Age = x.Age })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Gets the occupent count.</summary>
        /// <param name="Skipped">if set to <c>true</c> [skipped].</param>
        private void GetOccupentCount(bool Skipped)
        {
            if (Skipped)
            {
                OccupentsCount = 1;
            }
            else
            {
                OccupentsCount = DGridDependents.RowCount + 1; // with the customer
            }
        }

        /// <summary>Erases the dependent details.</summary>
        private void EraseDependentDetails()
        {
            txtDepName.Text = String.Empty;
            nmbDepAge.Value = 0;
            cmbDepRelation.SelectedIndex = 0;
        }



        // Events


        private void btnClear_Click(object sender, EventArgs e)
        {
            EraseCustomerDetails(true);
        }
        
        /// <summary>Handles the Click event of the btnAddCustomer control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                //Validate Fields
                var customer = new CustomerSave();
                customer.CustomerId = customerId = Guid.NewGuid();
                customer.CustomerName = txtCusName.Text;
                customer.CustomerAge = Convert.ToInt32(nmbCusAge.Value);
                customer.CustomerPhone = txtCusPhone.Text;
                customer.NICPassport = txtCusNIC.Text;
                customer.CustomerEmail = customerMailAddress = txtCusEmail.Text;
                customer.CustomerAddress = txtCusAddress.Text;
                customer.Password = Encrypt.Encrypting(txtCusNIC.Text);

                CustomerValidator Cusvalidator = new CustomerValidator();
                ValidationResult Cusresults = Cusvalidator.Validate(customer);
                if (!Cusresults.IsValid)
                {
                    foreach (var failure in Cusresults.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    _appDbContext = new AppDbContext();
                    string enteredNIC = txtCusNIC.Text;
                    string enteredEmail = txtCusEmail.Text;
                    var existingNic = _appDbContext.CustomerSaves.Where(x => x.NICPassport == enteredNIC).FirstOrDefault();
                    var existingEmail = _appDbContext.CustomerSaves.Where(x => x.CustomerEmail == enteredEmail).FirstOrDefault();

                    if (existingNic != null)
                    {
                        MessageBox.Show("Customer exists !" + Environment.NewLine + "Already registered under this NIC / Passport Number." + Environment.NewLine + "(" + enteredNIC + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (existingEmail != null)
                    {
                        MessageBox.Show("Customer Email exists !" + Environment.NewLine + "Already registered with this email." + Environment.NewLine + "(" + enteredEmail + ")", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            _appDbContext = new AppDbContext();
                            var customerSave = new CustomerSave();

                            customerSave.CustomerId = customerId;
                            customerSave.CustomerName = customerName = txtCusName.Text;
                            customerSave.CustomerEmail = customerMailAddress;
                            customerSave.CustomerPhone = txtCusPhone.Text;
                            customerSave.CustomerAge = Convert.ToInt32(nmbCusAge.Value);
                            customerSave.CustomerAddress = txtCusAddress.Text;
                            customerSave.NICPassport = txtCusNIC.Text;
                            customerSave.CreatedAt = DateTime.Now;
                            customerSave.UpdatedAt = DateTime.Now;
                            customerSave.ReferenceNumber = customerId.ToString();
                            customerSave.Password = Encrypt.Encrypting(txtCusNIC.Text);

                            _appDbContext.CustomerSaves.Add(customerSave);
                            _appDbContext.SaveChanges();

                            _appDbContext = new AppDbContext();         // add as a user when create the customer
                            var user = new User();
                            user.UserId = Guid.NewGuid();
                            user.Email = txtCusEmail.Text;
                            user.Password = Encrypt.Encrypting(txtCusNIC.Text);
                            user.UserType = "Customer";
                            _appDbContext.Users.Add(user);
                            _appDbContext.SaveChanges();

                            EraseCustomerDetails(false);
                            btnSkip.Enabled = true;
                            CustomerDataFieldsStatus(false);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message+ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>BTNs the status change event.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        void BtnStatusChangeEvent(object sender, EventArgs e)
        {
            if (txtDepName.Text.Length > 0 || cmbDepRelation.SelectedIndex > 0 || nmbDepAge.Value > 0)  //if those fields has a value
            {
                btnDepAdd.Enabled = true;
                btnClearDependentDetails.Enabled = true;
            }
            else
            {
                btnClearDependentDetails.Enabled = false;
                btnDepAdd.Enabled = false;
            }
        }

        /// <summary>Handles the Click event of the btnDepAdd control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnDepAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //validate rule
                _appDbContext = new AppDbContext();
                Dependent dependent = new Dependent();
                dependent.DependentName = txtDepName.Text;
                dependent.DependentId = DependentId = Guid.NewGuid();
                dependent.Relationship = cmbDepRelation.Text;
                dependent.Age = (int)nmbDepAge.Value;

                DependentValidator Depvalidator = new DependentValidator();
                ValidationResult Depresults = Depvalidator.Validate(dependent);
                //validate rule

                if (!Depresults.IsValid)    //if errors
                {
                    foreach (var failure in Depresults.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                else    // if dont have errors
                {
                    _appDbContext = new AppDbContext();
                    var existingDependent = _appDbContext.Dependents.Where(x => x.DependentName == txtDepName.Text.ToString())
                                                                    .Where(x => x.Relationship == cmbDepRelation.Text.ToString())
                                                                    .Where(x => x.Age == nmbDepAge.Value)
                                                                    .Where(x => x.CustomerId == customerId)
                                                                    .Select(x => x).FirstOrDefault();

                    if (existingDependent != null)  // check existing entities
                    {
                        MessageBox.Show("Dependent Already Added !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            _appDbContext = new AppDbContext();
                            Dependent dependentSave = new Dependent();
                            dependentSave.DependentId = DependentId;
                            dependentSave.DependentName = txtDepName.Text;
                            dependentSave.Relationship = cmbDepRelation.Text.ToString();
                            dependentSave.Age = (int)nmbDepAge.Value;
                            dependentSave.CustomerId = customerId;
                            _appDbContext.Dependents.Add(dependentSave);
                            _appDbContext.SaveChanges();

                            btnSkip.Enabled = false;
                            btnFinish.Enabled = true;

                            ShowDatainGridWithDetails();
                            EraseDependentDetails();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Load event of the FrmAddCustomer control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            ShowDatainGridWithoutDetails();
            EraseDependentDetails();
        }

        /// <summary>Handles the Click event of the btnClearDependentDetails control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnClearDependentDetails_Click(object sender, EventArgs e)
        {
            EraseDependentDetails();
        }

        /// <summary>Handles the Click event of the btnSkip control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnSkip_Click(object sender, EventArgs e)
        {
            //check if the data grid is empty
            if (DGridDependents.Rows.Count == 0)
            {
                DialogResult Response = MessageBox.Show("Are you sure, Do you want to skip as No Dependents / Servents?" + Environment.NewLine + "Click OK to continue.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Response == DialogResult.OK)
                {
                    try
                    {
                        _appDbContext = new AppDbContext();
                        Dependent dependentSave = new Dependent();
                        dependentSave.DependentId = DependentId = Guid.NewGuid();
                        dependentSave.DependentName = "No_Dependent";
                        dependentSave.Relationship = "No_Relation";
                        dependentSave.Age = 0;
                        dependentSave.CustomerId = customerId;
                        _appDbContext.Dependents.Add(dependentSave);
                        _appDbContext.SaveChanges();

                        EraseDependentDetails();
                        EraseCustomerDetails(false);
                        ShowDatainGridWithoutDetails();
                        btnFinish.Enabled = true;

                        GetOccupentCount(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("You cannot skip if there are dependents recorded already!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Click event of the btnFinish control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            MailSender.SendMailWithoutMessage(customerMailAddress, "Registration Success !",
                    "<b>Congratulations <i>" + txtCusName.Text.ToString() + "<i></b><br>" +
                    "We are so glad you registered with us!<br>" +
                    "Here is you reference number: <b>" + customerId.ToString() + "<br>" +
                    "<b>NOTE:</b> Please use your NIC number as the Password when Log in to the system<br>" +
                    "Please use your Email as the username when Log in to the system" +
                    "<br>" +
                    "Registration Panel, <br>" +
                    "E-Apartments<br>" +
                    "Email: eapartments258@gmail.com <br>" +
                    "<br>" +
                    "<br>" +
                    "<br>" +
                    "You are reciving this e-mail because you just registered to our system."
                    );
            EraseDependentDetails();
            EraseCustomerDetails(true);
            GetOccupentCount(false);        //get the occupent count
            ShowDatainGridWithoutDetails(); //then clear the grid.
            CustomerDataFieldsStatus(true);
        }

        /// <summary>Handles the Click event of the btnExit control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
