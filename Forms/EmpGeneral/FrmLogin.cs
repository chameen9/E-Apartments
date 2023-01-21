using E_Apartments.Data;
using E_Apartments.Forms;
using E_Apartments.Forms.Customer;
using E_Apartments.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // Create the tooltip
            ToolTip tooltip = new ToolTip();

            // Set the tooltip text
            tooltip.SetToolTip(icoInfo, "Please use your NIC number as " + Environment.NewLine+ "the password when login as a Customer.");
        }

        AppDbContext _appDbContext;

        /// <summary>The public variables</summary>
        public static string userName;
        public static string userEmail;
        public static string userType;
        public static Guid userId;


        /// <summary>Handles the Click event of the btnExit control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>Handles the Click event of the btnLogin control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public static string leasingId;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //addUser();
            try
            {
                if (String.IsNullOrEmpty(txtEmailUsername.Text) || String.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Username,email or Password is Empty. Please enter proper Details !", "Fileds Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _appDbContext = new AppDbContext();

                    var user = _appDbContext.Users.FirstOrDefault(u => u.Username == txtEmailUsername.Text || u.Email == txtEmailUsername.Text);// && Encrypt.Decrypting(u.Password) == txtPassword.Text
                    
                    

                    if (user != null)
                    {
                        string decryptedPassword = Encrypt.Decrypting(user.Password);
                        if (decryptedPassword == txtPassword.Text)
                        {
                            // If Authorized
                            var CheckeduserType = user.UserType;

                            var employee = new Employee();

                            userName = user.Username;
                            userType = user.UserType;
                            userId = user.UserId;

                            if (CheckeduserType == "Customer")
                            {
                                userEmail = user.Email;
                                var FoundCustomerWithLeaseId = _appDbContext.CustomerSaves.Where(x => x.CustomerEmail == txtEmailUsername.Text && x.LeasingId != null).FirstOrDefault();
                                if (FoundCustomerWithLeaseId != null)
                                {
                                    leasingId = FoundCustomerWithLeaseId.LeasingId.ToString();
                                    
                                }
                                else
                                {
                                    leasingId = string.Empty;
                                }
                                //MessageBox.Show(userEmail);
                                FrmCusDashboard frmCusDashboard = new FrmCusDashboard();
                                frmCusDashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                FrmDashboard frmDashboard = new FrmDashboard();
                                frmDashboard.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        // Invalid username or password
                        MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addUser()
        {
            try
            {
                _appDbContext = new AppDbContext();

                User userToSave = new User();
                userToSave.UserId = Guid.NewGuid();
                userToSave.Username = txtEmailUsername.Text;
                userToSave.Password = Encrypt.Encrypting(txtPassword.Text);
                userToSave.Email = "sample@gmail.com";
                userToSave.UserType = "Clerk";

                _appDbContext.Users.Add(userToSave);
                _appDbContext.SaveChanges();


                MessageBox.Show(Encrypt.Encrypting(txtPassword.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>Handles the Click event of the lblRegisterAsNewCustomer control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void lblRegisterAsNewCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.Show();
            this.Hide();
        }
    }
}
