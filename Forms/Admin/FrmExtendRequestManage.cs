using E_Apartments.Data;
using E_Apartments.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Apartments.Forms.Admin
{
    public partial class FrmExtendRequestManage : Form
    {
        public FrmExtendRequestManage()
        {
            InitializeComponent();
        }
        AppDbContext _appDbContext;
        public static Guid LeaseId;
        public static Guid CustomerId;

        public static double RefundableAmount;
        public static double Balance;
        public static double newRefundableAmount;
        public static DateTime EstEndDate;

        private void viewGrid()
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridReqests.DataSource = _appDbContext.LeaseExtendRequest
                    .Where(x => x.Status == "Requested")
                    .Select(x => new { LeasingID = x.LeasingId, Status = x.Status, RequestedAt = x.RequestedAt, EstDate = x.RequestedEndDate })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmExtendRequestManage_Load(object sender, EventArgs e)
        {
            viewGrid();
        }

        private void DGridReqests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAccept.Enabled = true;
            if(DGridReqests.Rows.Count > 0)
            {
                LeaseId = Guid.Parse(DGridReqests.CurrentRow.Cells[0].Value.ToString());
                txtLeaseId.Text = DGridReqests.CurrentRow.Cells[0].Value.ToString();
                EstEndDate = Convert.ToDateTime(DGridReqests.CurrentRow.Cells[3].Value);

                _appDbContext = new AppDbContext();
                var thisLeasing = _appDbContext.Leasings.FirstOrDefault(x=>x.LeasingId == LeaseId);
                if (thisLeasing != null)
                {
                    txtApartmentId.Text = thisLeasing.ApartmentID.ToString();


                    _appDbContext = new AppDbContext();
                    var thisCustomer = _appDbContext.CustomerSaves.FirstOrDefault(x=>x.LeasingId == LeaseId);
                    if (thisCustomer != null)
                    {
                        txtCustomerName.Text = thisCustomer.CustomerName.ToString();
                        CustomerId= thisCustomer.CustomerId;
                        lblRfa.Text = thisLeasing.RefundableAmount.ToString();
                        RefundableAmount = thisLeasing.RefundableAmount;
                        lblBalance.Text = thisLeasing.Balance.ToString();
                        Balance= thisLeasing.Balance;
                        newRefundableAmount = RefundableAmount - Balance;
                        lblNewRfa.Text = newRefundableAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Leasing Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                btnAccept.Enabled = false;
                MessageBox.Show("No Requests Selected.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(txtLeaseId.Text == string.Empty || txtCustomerName.Text == string.Empty || txtApartmentId.Text == string.Empty)
            {
                MessageBox.Show("Select a Request to continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _appDbContext = new AppDbContext();
                var checkedReservation = _appDbContext.Reservation.FirstOrDefault(x => x.CustomerId == CustomerId && x.ApartmentId == txtApartmentId.Text && x.Status == "Pending");

                if (checkedReservation != null)
                {
                    MessageBox.Show("Extended Request already marked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _appDbContext = new AppDbContext();
                    var existingExtendRequest = _appDbContext.LeaseExtendRequest.FirstOrDefault(x => x.LeasingId == LeaseId);
                    if (existingExtendRequest != null)
                    {
                        existingExtendRequest.Status = "Completed";

                        _appDbContext.Entry(existingExtendRequest).State = System.Data.Entity.EntityState.Modified;
                        _appDbContext.SaveChanges();

                        _appDbContext = new AppDbContext();
                        var existingReservation = _appDbContext.Reservation.FirstOrDefault(x => x.CustomerId == CustomerId && x.ApartmentId == txtApartmentId.Text);
                        if (existingReservation != null)
                        {
                            _appDbContext = new AppDbContext();
                            var newReservation = new Reservation();

                            newReservation.ResvId = Guid.NewGuid();
                            newReservation.Status = "Pending";
                            newReservation.CustomerId = CustomerId;
                            newReservation.ApartmentId = txtApartmentId.Text;
                            newReservation.CreatedAt = DateTime.Now;
                            newReservation.ResrvedFrom = existingReservation.ResrvedTo;
                            newReservation.ResrvedTo = EstEndDate;
                            newReservation.AdditionalParkingFee = 0.00;
                            newReservation.RefundableAmount = Convert.ToDouble(lblNewRfa.Text);
                            newReservation.MonthlyRate = existingReservation.MonthlyRate;
                            newReservation.TotalAmount = Convert.ToDouble(lblNewRfa.Text);
                            newReservation.PaidAmount = 0.00;
                            newReservation.Balance = 0.00;
                            newReservation.ClassID = existingReservation.ClassID;

                            _appDbContext.Reservation.Add(newReservation);
                            _appDbContext.SaveChanges();

                        }
                        else
                        {
                            MessageBox.Show("Existing Resv Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Request Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (DGridReqests.Rows.Count > 0)
            {
                try
                {
                    // set the pdf name and path
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\ExtendRequests.pdf";

                    // chck existing files in the directory
                    if (!Directory.Exists(Path.GetDirectoryName(path)))
                        Directory.CreateDirectory(Path.GetDirectoryName(path));

                    int counter = 1;
                    while (File.Exists(path))
                    {
                        string newPath = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + "(" + counter + ")" + Path.GetExtension(path));
                        if (!File.Exists(newPath))
                        {
                            path = newPath;
                            break;
                        }
                        counter++;
                    }
                    // Create a font object for the header texts
                    iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD);

                    // document formats
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.Create));

                    //Pdf data
                    pdfDoc.Open();

                    // Add the title to the document
                    Paragraph title = new Paragraph("Extend Requests", fontHeader);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    //add an page break
                    pdfDoc.Add(Chunk.NEWLINE);

                    // convert data grid to a table
                    PdfPTable pdfTable = new PdfPTable(DGridReqests.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    for (int i = 0; i < DGridReqests.Columns.Count; i++)
                    {
                        pdfTable.AddCell(new Phrase(DGridReqests.Columns[i].HeaderText, fontHeader));
                    }

                    for (int i = 0; i < DGridReqests.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGridReqests.Columns.Count; j++)
                        {
                            pdfTable.AddCell(new Phrase(DGridReqests.Rows[i].Cells[j].Value.ToString()));
                        }
                    }

                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    //close pdf data

                    MessageBox.Show("PDF export successfully. The file is located at :" + Environment.NewLine + path, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show(ioEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Cannot export a report without data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
