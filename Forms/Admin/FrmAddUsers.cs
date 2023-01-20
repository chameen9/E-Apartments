using E_Apartments.Data;
using E_Apartments.Models;
using E_Apartments.Validators;
using FluentValidation.Results;
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

namespace E_Apartments.Forms.Admin
{
    public partial class FrmAddUsers : Form
    {
        public FrmAddUsers()
        {
            InitializeComponent();

            // Create the tooltip
            ToolTip tooltip = new ToolTip();

            // Set the tooltip text
            tooltip.SetToolTip(icoInfo, 
                "All of the Passwords are" + Environment.NewLine + 
                "Displayed as an Encrypted." + Environment.NewLine +
                "Value. Because of the" + Environment.NewLine +
                "(GDPR , CCPA) Policies."
                );
        }
        AppDbContext _appDbContext;
        private void clear()
        {
            cmbUserType.SelectedIndex = 0;
            cmbFilterUserType.SelectedIndex = 0;
            txtEmail.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtUsername.Focus();
            viewGrid();
        }

        private void viewGrid()
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridUsers.DataSource = _appDbContext.Users
                    .Where(x=>x.UserType != "SuperAdmin" && x.UserType != "Customer")
                    .Select(x => new { Email = x.Email, Username = x.Username, Type = x.UserType, Password = x.Password })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddUsers_Load(object sender, EventArgs e)
        {
            clear();
            viewGrid();
        }

        private void DGridUsers_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void DGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGridUsers.Rows.Count > 0)
            {
                txtEmail.Text = DGridUsers.CurrentRow.Cells[0].Value.ToString();
                txtUsername.Text = DGridUsers.CurrentRow.Cells[1].Value.ToString();
                cmbUserType.Text = DGridUsers.CurrentRow.Cells[2].Value.ToString();

                btnAdd.Visible = false;
                btnClear.Visible = false;
                btnCancel.Visible = true;
                btnUpdate.Visible = true;

                txtEmail.ReadOnly = true;
                txtUsername.ReadOnly = true;

                cmbFilterUserType.Enabled= false;
                btnSearch.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Users Found.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public Guid thisUserId;
        public string thisUserPassword;

        private string generateNewPaswword()
        {
            // Create a new instance of the RNGCryptoServiceProvider class
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            // Create a byte array to hold the random value
            byte[] randomBytes = new byte[8]; //Change the size of array to 8

            // Fill the array with a random value
            rng.GetBytes(randomBytes);

            // Convert the byte array to a string
            string randomString = Convert.ToBase64String(randomBytes);
            // Trim the string to 8 characters
            randomString = randomString.Substring(0, 8);
            // Assign the random string to the TextBox
            
            return randomString;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            thisUserPassword = Encrypt.Encrypting(generateNewPaswword());
            //model
            var valUser = new User();
            valUser.UserId = thisUserId = Guid.NewGuid();
            valUser.Email = txtEmail.Text;
            valUser.Username = txtUsername.Text;
            valUser.Password = thisUserPassword;
            valUser.UserType = cmbUserType.Text.ToString();

            UserValidator userValidator = new UserValidator();
            ValidationResult results = userValidator.Validate(valUser);
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    MessageBox.Show(failure.ErrorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                // check exist
                _appDbContext = new AppDbContext();
                var existUser = _appDbContext.Users.FirstOrDefault(x=>x.Username == txtUsername.Text || x.Email == txtEmail.Text);
                if (existUser != null)
                {
                    MessageBox.Show("This user already exists. Please change the username or "+Environment.NewLine+"try again with another Email address.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        _appDbContext = new AppDbContext();
                        var newUser = new User();
                        newUser.UserId = thisUserId = thisUserId;
                        newUser.Email = txtEmail.Text;
                        newUser.Username = txtUsername.Text;
                        newUser.Password = thisUserPassword;
                        newUser.UserType = cmbUserType.Text.ToString();

                        _appDbContext.Users.Add(newUser);
                        _appDbContext.SaveChanges();


                        MailSender.SendMailWithoutMessage(
                            txtEmail.Text,
                            "User credentials for E-Apartments",
                            "Dear user, <br>" +
                            "The username and Password for the E-Apartments included in below.<br>" +
                            "<b>NOTE: Plaese make sure to change the password once you logged in.<br>" + "</b>" +
                            "Username: " + txtUsername.Text + "<br>" +
                            "Password: " + Encrypt.Decrypting(thisUserPassword) + "<br>" +
                            "Type: " + cmbUserType.Text
                            );

                        viewGrid();
                        clear();
                        MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void cancelEvent()
        {
            btnAdd.Visible = true;
            btnClear.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;

            txtUsername.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cmbFilterUserType.Enabled = true;
            btnSearch.Enabled = true;
            clear();
            viewGrid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelEvent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!btnAdd.Visible && cmbUserType.SelectedIndex != 0)
            {
                try
                {
                    _appDbContext = new AppDbContext();
                    var userToUpdate = _appDbContext.Users.FirstOrDefault(x => x.Username == txtUsername.Text && x.Email == txtEmail.Text);
                    if (userToUpdate != null)
                    {
                        userToUpdate.UserType = cmbUserType.Text.ToString();

                        _appDbContext.Entry(userToUpdate).State = System.Data.Entity.EntityState.Modified;
                        _appDbContext.SaveChanges();
                        MessageBox.Show("User updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewGrid();
                        clear();
                        cancelEvent();
                    }
                    else
                    {
                        MessageBox.Show("User not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a User type.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbFilterUserType.SelectedIndex != 0)
            {
                try
                {
                    _appDbContext = new AppDbContext();
                    DGridUsers.DataSource = _appDbContext.Users
                        .Where(x => x.UserType != "SuperAdmin" && x.UserType != "Customer" && x.UserType == cmbFilterUserType.Text)
                        .Select(x => new { Email = x.Email, Username = x.Username, Type = x.UserType, Password = x.Password })
                        .ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select an usertype to Filter.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
