using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iText.Layout.Properties;
//using iText.Kernel.Pdf;
//using PdfKernel = iText.Kernel.Pdf;



namespace SellingApp
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=PIERRE-KASANANI\SQLEXPRESS;Initial Catalog=CRUD;Integrated Security=True");
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select productId as 'Product ID', productNames as 'Product name' , unitPrice as 'Unit price', quantity as 'Quantity',expiryDate as 'Exp. Date', totalPrice as 'Total price'from  Product", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Product");
            productsInfo.DataSource = ds.Tables["Product"];
        }
        private void Displaysearchedproduct()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from  Product WHERE productId='" + prodSearchText.Text+ "'", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Product");
            productsInfo.DataSource = ds.Tables["Product"];
        }
        private void prodRegButt_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO product VALUES ('" + prodIdText.Text + "','" + prodNameText.Text + "','" + prodUPtxt.Text + "','" + prodQuText.Text + "','" + prodExpDate.Value.Date + "','" + (float.Parse(prodUPtxt.Text) * int.Parse(prodQuText.Text)) + "')", conn);

            //SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO product values('"+prodIdText.Text+ "','" + prodNameText.Text + "','"+prodUPtxt.Text+"','" + prodQuText.Text +"','" + prodExpDate.Value.Date+"','" +prodUPtxt.Text+ * +prodQuText.Text + "')", conn);
            conn.Open();
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product successfully registered !");
            DisplayProducts();
        }

        private void proUPtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodUpdButt_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE product SET productNames=@name, unitPrice=@price, quantity=@qty, expiryDate=@exp  where productId=@id", conn);
            cmd.Parameters.AddWithValue("@name", prodNameText.Text);
            cmd.Parameters.AddWithValue("@id", prodIdText.Text);
            cmd.Parameters.AddWithValue("@price", prodUPtxt.Text);
            cmd.Parameters.AddWithValue("@qty", prodQuText.Text);
            cmd.Parameters.AddWithValue("@exp", prodExpDate.Value.Date);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product successfully updated !");
            DisplayProducts();
        }

        private void productsInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsInfo.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in productsInfo.SelectedRows)
                {
                    prodIdText.Text = row.Cells[0].Value.ToString();
                    prodNameText.Text = row.Cells[1].Value.ToString();
                    prodUPtxt.Text = row.Cells[2].Value.ToString();
                    prodQuText.Text = row.Cells[3].Value.ToString();
                    prodExpDate.Text = row.Cells[4].Value.ToString();
                }
            }
            {

            }
        }

        private void prodDelButt_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM product WHERE productId='" + prodIdText.Text + "'", conn);
            conn.Open();
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Product  deleted !");
            DisplayProducts();
        }

        private void prodSearchButt_Click(object sender, EventArgs e)
        {
            if (prodSearchText.Text == "")
            {
                MessageBox.Show("Please enter the product ID to be searched");
            }
            else
            {
                Displaysearchedproduct();
            }
            
        }
       
        private void prodCanButt_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Form1 form = new Form1();
            form.Show();
        }

        private void productsInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DisplayReport(DataGridView dataGridView, string filePath)
        {
            string sqlQuery = "SELECT SUM(totalPrice) FROM product";
            
            Document document = new Document();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                int totalPrice = Convert.ToInt32(cmd.ExecuteScalar());
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                
                iTextSharp.text.Image MyImage = iTextSharp.text.Image.GetInstance("E:\\AUCA\\AUCA_COURSES\\semester_8\\DotNet\\SellingApp\\pharmaLogo\\png\\logo-color.png");
                MyImage.ScaleAbsoluteWidth(120f); 
                MyImage.ScaleAbsoluteHeight(120f);
                Paragraph paragraph = new Paragraph("PRODUCTS REPORT\n=================");
                paragraph.IndentationLeft = 200f;

                //BaseColor blueDark = new BaseColor(0, 0, 139);
                BaseColor lightBlue = new BaseColor(6, 159, 241);
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 27, iTextSharp.text.Font.BOLD, lightBlue);
                iTextSharp.text.Font addressFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 9, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                Paragraph address = new Paragraph("\n        +243 972 931280   |   +250 790 929 575   |   chikukaspierre@gmail.com ", addressFont);
                //address.IndentationLeft = 300;
                Paragraph Textheader = new Paragraph("\nYEREMIYA PHARMACY", headerFont); 
                //Chunk chunkAddress = new Chunk("");

                PdfPTable headerTable = new PdfPTable(2);
                headerTable.SetTotalWidth(new float[] {80,275} );

                Textheader.Add("\n"); 
                Textheader.Add(address);

                PdfPCell myimageCell = new PdfPCell(MyImage);
                myimageCell.Border = PdfPCell.NO_BORDER;
                headerTable.AddCell(myimageCell);

                
                PdfPCell headerCell = new PdfPCell(Textheader);
                headerCell.Border = PdfPCell.NO_BORDER;
                headerTable.AddCell(headerCell);

                document.Add(headerTable);

                document.Add(paragraph);
                //MyImage.ScalePercent(1f);
                //MyImage.ScaleToFit(50, 50);
                //MyImage.SetAbsolutePosition();
                //MyImage.ScaleToFitLineWhenOverflow(MyImage, paragraph); 
                //document.Add(MyImage);
                //document.Add(address);

                PdfPTable table = new PdfPTable(dataGridView.ColumnCount);
                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    table.AddCell(new Phrase(dataGridView.Columns[i].HeaderText));
                }
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        if (dataGridView[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView[j, i].Value.ToString()));
                        }
                    }
                }
                Paragraph totprice = new Paragraph("\n\nTotal price: "+ totalPrice);
                totprice.IndentationLeft = 50f;
                document.Add(table);
                document.Add(totprice);
                conn.Close();
            }
            catch (DocumentException de)
            {
                MessageBox.Show(de.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                document.Close();
            }
        }

        private void printReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    DisplayReport(productsInfo, filePath);
                    MessageBox.Show("Report downloaded!");
                }        
                
            

        }
    }
}
