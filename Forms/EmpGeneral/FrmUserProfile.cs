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

namespace E_Apartments.Forms.EmpGeneral
{
    public partial class FrmUserProfile : Form
    {
        public FrmUserProfile()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        public string thisUsersPassword;
        private void btnDefaultShowPw_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            btnDefaultHidePw.Visible = true;
            btnDefaultShowPw.Visible = false;
        }

        private void btnDefaultHidePw_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnDefaultHidePw.Visible = false;
            btnDefaultShowPw.Visible = true;
        }

        private void btnShowPw_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
            txtConfirmedPassword.UseSystemPasswordChar = false;

            btnHidePw.Visible = true;
            btnShowPw.Visible = false;
        }

        private void btnHidePw_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = true;
            txtConfirmedPassword.UseSystemPasswordChar = true;

            btnHidePw.Visible = false;
            btnShowPw.Visible = true;
        }

        private void FrmUserProfile_Load(object sender, EventArgs e)
        {
            if(FrmLogin.userName != null)
            {
                _appDbContext = new AppDbContext();
                string thisUsername = FrmLogin.userName;
                var thisUser = _appDbContext.Users.FirstOrDefault(x=>x.Username == thisUsername);

                if(thisUser != null)
                {
                    txtEmail.Text = thisUser.Email;
                    txtUsername.Text = thisUser.Username;
                    txtUserType.Text = thisUser.UserType;
                    thisUsersPassword = Encrypt.Decrypting(thisUser.Password);
                }
            }
            else
            {
                if (FrmLogin.userEmail != null)
                {
                    _appDbContext = new AppDbContext();
                    string thisEmail = FrmLogin.userEmail;
                    var thisUser = _appDbContext.Users.FirstOrDefault(x => x.Email == thisEmail);

                    if (thisUser != null)
                    {
                        txtEmail.Text = thisUser.Email;
                        txtUsername.Text = thisUser.Username;
                        txtUserType.Text = thisUser.UserType;
                        thisUsersPassword = Encrypt.Decrypting(thisUser.Password);
                    }
                }
                else
                {
                    MessageBox.Show("User search failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("User search failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == thisUsersPassword)
            {
                icoPasswordCheck.Visible = true;
                txtNewPassword.Enabled = true;
                txtConfirmedPassword.Enabled = true;
                btnUpdate.Visible= true;
            }
            else
            {
                icoPasswordCheck.Visible = false;
                txtNewPassword.Enabled = false;
                txtConfirmedPassword.Enabled = false;
                btnUpdate.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtNewPassword.Text != string.Empty && txtConfirmedPassword.Text != string.Empty)
            {
                if (txtNewPassword.Text == txtConfirmedPassword.Text)
                {
                    if (txtConfirmedPassword.Text == thisUsersPassword)
                    {
                        MessageBox.Show("New password must be different than old password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //update
                        _appDbContext = new AppDbContext();
                        var userToUpdate = _appDbContext.Users.FirstOrDefault(x => x.Username == txtUsername.Text && x.Email == txtEmail.Text);
                        if (userToUpdate != null)
                        {
                            userToUpdate.Password = Encrypt.Encrypting(txtConfirmedPassword.Text);

                            _appDbContext.Entry(userToUpdate).State = System.Data.Entity.EntityState.Modified;
                            _appDbContext.SaveChanges();
                            
                            clear();

                            MailSender.SendMailWithoutMessage(
                                txtEmail.Text.ToString(),
                                "Securrity Alert!",
                                "Your Password has been changed on "+DateTime.Now.ToString()
                                );

                            DialogResult result = MessageBox.Show("Password updated. Please login to the system again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("New password and Confirmed password must be equal.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a proper password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void clear()
        {
            txtPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmedPassword.Text = string.Empty;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
