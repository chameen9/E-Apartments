using E_Apartments.Data;
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
    public partial class FrmManageReservations : Form
    {
        public FrmManageReservations()
        {
            InitializeComponent();

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnExportPdf, "Click to export the"+Environment.NewLine+"reservations data"+ Environment.NewLine + "as a PDF file");
        }
        AppDbContext _appDbContext;
        private void FrmManageReservations_Load(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                DGridReservations.DataSource = _appDbContext.Reservation
                    .Where(r => r.Status == "Pending" || r.Status == "Extended")
                    .Select(x => new { 
                        Customer = x.CustomerSave.CustomerName, 
                        Apartment = x.ApartmentId, 
                        Class = x.ClassID , 
                        From = x.ResrvedFrom, 
                        To = x.ResrvedTo, 
                        AP = x.AdditionalParkingFee, 
                        RFA = x.RefundableAmount, 
                        MI = x.MonthlyRate, 
                        Paid = x.PaidAmount, 
                        Total = x.TotalAmount, 
                        Balance = x.Balance,
                        Status = x.Status,
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string CustomerName;
        public static string ApartmentID;
        public static string ClassID;
        public static string ReservedFrom;
        public static string ReservedTo;
        public static string AddParkingFee;
        public static string RefubdableAmount;
        public static string MonthlyInstallment;
        public static string PaidAmount;
        public static string TotalAmount;
        public static string Balance;
        public static string Status;

        private void DGridReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGridReservations.Rows.Count > 0)
            {
                CustomerName = DGridReservations.CurrentRow.Cells[0].Value.ToString();
                ApartmentID = DGridReservations.CurrentRow.Cells[1].Value.ToString();
                ClassID = DGridReservations.CurrentRow.Cells[2].Value.ToString();
                ReservedFrom = DGridReservations.CurrentRow.Cells[3].Value.ToString();
                ReservedTo = DGridReservations.CurrentRow.Cells[4].Value.ToString();
                AddParkingFee = DGridReservations.CurrentRow.Cells[5].Value.ToString();
                RefubdableAmount = DGridReservations.CurrentRow.Cells[6].Value.ToString();
                MonthlyInstallment = DGridReservations.CurrentRow.Cells[7].Value.ToString();
                PaidAmount = DGridReservations.CurrentRow.Cells[8].Value.ToString();
                TotalAmount = DGridReservations.CurrentRow.Cells[9].Value.ToString();
                Balance = DGridReservations.CurrentRow.Cells[10].Value.ToString();
                Status = DGridReservations.CurrentRow.Cells[11].Value.ToString();

                FrmMarkReservations frmMarkReservations = new FrmMarkReservations();
                frmMarkReservations.FormClosed += (s, args) => this.Enabled = true;
                frmMarkReservations.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Reservations Found.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (DGridReservations.Rows.Count > 0)
            {
                try
                {
                    // set the pdf name and path
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Reservations.pdf";

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
                    // document formats
                    Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.Create));

                    //Pdf data
                    pdfDoc.Open();

                    // Add the title to the document
                    Paragraph title = new Paragraph("Reservations");
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    //add an page break
                    pdfDoc.Add(Chunk.NEWLINE);

                    // convert data grid to a table
                    PdfPTable pdfTable = new PdfPTable(DGridReservations.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    for (int i = 0; i < DGridReservations.Columns.Count; i++)
                    {
                        pdfTable.AddCell(new Phrase(DGridReservations.Columns[i].HeaderText));
                    }

                    for (int i = 0; i < DGridReservations.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGridReservations.Columns.Count; j++)
                        {
                            pdfTable.AddCell(new Phrase(DGridReservations.Rows[i].Cells[j].Value.ToString()));
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
