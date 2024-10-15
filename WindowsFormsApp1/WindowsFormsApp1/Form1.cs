using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if (dt != null)
            {
                List<SirketGridDeneme> sirketGridDenemes = new List<SirketGridDeneme>(); 
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SirketGridDeneme sirketGridDeneme = new SirketGridDeneme();
                    sirketGridDeneme.SirketId = dt.Rows[i]["SirketId"].ToString();
                    sirketGridDeneme.FaturaTuru = dt.Rows[i]["FaturaTuru"].ToString();
                    sirketGridDeneme.FaturaNo = dt.Rows[i]["FaturaNo"].ToString();
                    sirketGridDeneme.FaturaTarihi = dt.Rows[i]["FaturaTarihi"].ToString();
                    sirketGridDeneme.FisTarihi = dt.Rows[i]["FisTarihi"].ToString();
                    sirketGridDeneme.CariNo = dt.Rows[i]["CariNo"].ToString();
                    sirketGridDeneme.CariAdi = dt.Rows[i]["CariAdi"].ToString();
                    sirketGridDeneme.VergiDairesi = dt.Rows[i]["VergiDairesi"].ToString();
                    sirketGridDeneme.VergiNo = dt.Rows[i]["VergiNo"].ToString();
                    sirketGridDeneme.StokKodu = dt.Rows[i]["StokKodu"].ToString();
                    sirketGridDeneme.StokMalzemeAciklamasi = dt.Rows[i]["StokMalzemeAciklamasi"].ToString();
                    sirketGridDeneme.Gtip = dt.Rows[i]["Gtip"].ToString();
                    sirketGridDeneme.OtvOrani = dt.Rows[i]["OtvOrani"].ToString();
                    sirketGridDeneme.Miktar = dt.Rows[i]["Miktar"].ToString();
                    sirketGridDeneme.DovizKodu = dt.Rows[i]["DovizKodu"].ToString();
                    sirketGridDeneme.DovizKuru = dt.Rows[i]["DovizKuru"].ToString();
                    sirketGridDeneme.TlMatrah = dt.Rows[i]["TlMatrah"].ToString();
                    sirketGridDeneme.TlKdv = dt.Rows[i]["TlKdv"].ToString();
                    sirketGridDeneme.TlGenelToplam = dt.Rows[i]["TlGenelToplam"].ToString();
                    sirketGridDeneme.TlOtvTutar = dt.Rows[i]["TlOtvTutar"].ToString();
                    sirketGridDeneme.Kdv_Kodu = dt.Rows[i]["KdvKodu"].ToString();
                    sirketGridDeneme.Hesap = dt.Rows[i]["Hesap"].ToString();
                    sirketGridDenemes.Add(sirketGridDeneme);
                }
                sirketGridDenemeBindingSource.DataSource = sirketGridDenemes;
            }
        }

        DataTableCollection tableCollection;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })
            {
                
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        txtFileName.Text = openFileDialog.FileName;
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                cboSheet.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                    cboSheet.Items.Add(table.TableName);//Add Sheet to Combobox
                            }
                        }
                    }
                }
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=.;Database=dbdeneme; User Id=sa;Password=123;";
                DapperPlusManager.Entity<SirketGridDeneme>().Table("sirketdeneme");
                List<SirketGridDeneme> sirketGridDenemes = sirketGridDenemeBindingSource.DataSource as List<SirketGridDeneme>;
                if (sirketGridDenemes != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(sirketGridDenemes);
                    }
                }
                MessageBox.Show("Aktarma Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
