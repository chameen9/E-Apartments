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
    public partial class FrmManageApplications : Form
    {
        public FrmManageApplications()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnExportPdf, "Click to export the" + Environment.NewLine + "applications data" + Environment.NewLine + "as a PDF file");
        }
        AppDbContext _appDbContext;
        /// <summary>Handles the Load event of the FrmManageApplications control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FrmManageApplications_Load(object sender, EventArgs e)
        {
            try
            {
                _appDbContext = new AppDbContext();
                
                DGridApplications.DataSource = _appDbContext.AptApplication
                        .Where(r => r.Status == "Pending")
                        .OrderBy(r => r.Status)
                        .ThenBy(r => r.CreatedAt)
                        .GroupBy(r => r.ApartmentId)
                        .Select(g => new {
                            Status = g.FirstOrDefault().Status,
                            Customer = g.Select(x => x.CustomerSave.CustomerName).FirstOrDefault(),
                            CustomerID = g.Select(x => x.CustomerId).FirstOrDefault(),
                            Apartment = g.Select(x => x.ApartmentId).FirstOrDefault(),
                            AppliedDate = g.Select(x => x.CreatedAt).FirstOrDefault(),
                            From = g.Select(x => x.ResrvedFrom).FirstOrDefault(),
                            To = g.Select(x => x.ResrvedTo).FirstOrDefault(),
                            AP_ID = g.Select(x => x.AddParkingId).FirstOrDefault()
                        })
                        .ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the Click event of the btnExportPdf control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            if (DGridApplications.Rows.Count > 0)
            {
                try
                {
                    // set the pdf name and path
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\Applications.pdf";

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
                    Paragraph title = new Paragraph("Applications",fontHeader);
                    title.Alignment = Element.ALIGN_CENTER;
                    pdfDoc.Add(title);

                    //add an page break
                    pdfDoc.Add(Chunk.NEWLINE);

                    // convert data grid to a table
                    PdfPTable pdfTable = new PdfPTable(DGridApplications.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                    for (int i = 0; i < DGridApplications.Columns.Count; i++)
                    {
                        pdfTable.AddCell(new Phrase(DGridApplications.Columns[i].HeaderText, fontHeader));
                    }

                    for (int i = 0; i < DGridApplications.Rows.Count; i++)
                    {
                        for (int j = 0; j < DGridApplications.Columns.Count; j++)
                        {
                            pdfTable.AddCell(new Phrase(DGridApplications.Rows[i].Cells[j].Value.ToString()));
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
        public static string thisStatus;
        public static string thisCustomerId;
        public static string thisCustomerName;
        public static string thisApartmentId;
        public static string thisAppliedDate;
        public static string thisAppliedFrom;
        public static string thisAppliedTo;
        public static string thisApID;
        /// <summary>Handles the CellContentClick event of the DGridApplications control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs" /> instance containing the event data.</param>
        private void DGridApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGridApplications.Rows.Count > 0)
            {
                thisStatus = DGridApplications.CurrentRow.Cells[0].Value.ToString();
                thisCustomerName = DGridApplications.CurrentRow.Cells[1].Value.ToString();
                thisCustomerId = DGridApplications.CurrentRow.Cells[2].Value.ToString();
                thisApartmentId = DGridApplications.CurrentRow.Cells[3].Value.ToString();
                thisAppliedDate = DGridApplications.CurrentRow.Cells[4].Value.ToString();
                thisAppliedFrom = DGridApplications.CurrentRow.Cells[5].Value.ToString();
                thisAppliedTo = DGridApplications.CurrentRow.Cells[6].Value.ToString();
                thisApID = DGridApplications.CurrentRow.Cells[7].Value.ToString();

                FrmMarkApplications frmMarkApplications = new FrmMarkApplications();
                frmMarkApplications.FormClosed += (s, args) => this.Enabled = true;
                frmMarkApplications.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Application Found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
