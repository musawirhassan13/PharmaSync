using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;


namespace PHARMASYNC
{
    public partial class InvoiceForm : Form
    {
        private DataTable dtSale;
        private decimal totalAmount = 0;
        private decimal grandTotal = 0;
        private decimal discountPercent = 0;
        public InvoiceForm(DataTable saleData, string custID, string custName, string phone, string address, decimal discount, string sellerID)
        {
            InitializeComponent();
            dtSale = saleData;
            discountPercent = discount;

            // Fill customer data
            lblCustomerID.Text = custID;
            lblCustomerName.Text = custName;
            lblPhone.Text = phone;
            lblAddress.Text = address;

            // Fill seller data
            lblSellerID.Text = Session.CurrentUserID;
            lblSellerName.Text = Session.CurrentUserName;

            // Auto generate invoice number
            lblInvoiceNo.Text = GenerateInvoiceNo();
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");

            // Load grid + calculate totals
            LoadInvoiceGrid();
            CalculateTotals();
        }
        private string GenerateInvoiceNo()
        {
            string prefix = "INV-";
            string timestamp = DateTime.Now.ToString("yyMMddHHmmss");
            return prefix + timestamp;
        }
        private void LoadInvoiceGrid()
        {
            dataGridViewInvoice.DataSource = dtSale;
            dataGridViewInvoice.ReadOnly = true;
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CalculateTotals()
        {
            totalAmount = 0;
            foreach (DataRow row in dtSale.Rows)
            {
                totalAmount += Convert.ToDecimal(row["TOTAL"]);
            }

            lblTotalValue.Text = totalAmount.ToString("0.00");


            decimal discountAmount = totalAmount * (discountPercent / 100);
            grandTotal = totalAmount - discountAmount;
            lblDiscount.Text = $"{Math.Round(discountPercent, 0)}%";
            lblGrandTotalValue.Text = Math.Round(grandTotal, 0).ToString("0");

        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF Files|*.pdf";
            saveDialog.Title = "Save Invoice As PDF";
            saveDialog.FileName = $"{lblInvoiceNo.Text}.pdf";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                GeneratePDF(saveDialog.FileName);
                MessageBox.Show("Invoice exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GeneratePDF(string filePath)
        {
            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();





            doc.Add(new Paragraph($"Invoice No: {lblInvoiceNo.Text}        Date: {lblDate.Text}"));
            doc.Add(new Paragraph($"Seller ID: {lblSellerID.Text}        Seller Name: {lblSellerName.Text}"));
            doc.Add(new Paragraph($"Customer ID: {lblCustomerID.Text}    Name: {lblCustomerName.Text}"));
            doc.Add(new Paragraph($"Phone: {lblPhone.Text}               Address: {lblAddress.Text}"));
            doc.Add(new Paragraph(" "));

            // Table
            PdfPTable table = new PdfPTable(5);
            table.WidthPercentage = 100;
            table.AddCell("ID");
            table.AddCell("NAME");
            table.AddCell("SALE_RATE");
            table.AddCell("QUANTITY");
            table.AddCell("TYPE");
            table.AddCell("TOTAL");

            foreach (DataRow row in dtSale.Rows)
            {
                table.AddCell(row["ID"].ToString());
                table.AddCell(row["NAME"].ToString());
                table.AddCell(row["SALE_RATE"].ToString());
                table.AddCell(row["QUANTITY"].ToString());
                table.AddCell(row["TYPE"].ToString());
                table.AddCell(row["TOTAL"].ToString());
            }

            doc.Add(table);
            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph($"Total: {lblTotalValue.Text}"));
            doc.Add(new Paragraph($"Discount: {lblDiscount.Text}"));
            doc.Add(new Paragraph($"Grand Total: {lblGrandTotalValue.Text}"));





            doc.Close();
        }
    }
}


