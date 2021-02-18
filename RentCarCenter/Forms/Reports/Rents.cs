using RentCarCenter.Models;
using MoreLinq.Extensions;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentCarCenter.Utilities;
using RentCarCenter.Services;
using RentCarCenter.ViewModels;
using System.Linq;

namespace RentCarCenter
{
    public partial class Rents : Form
    {
        private GenericRepository<RentDetail> _rents;
        private IList<RentDetailVM> Data { get; set; }
        public Rents()
        {
            _rents = new GenericRepository<RentDetail>();
            InitializeComponent();
        }

        private async void Rents_Load(object sender, EventArgs e)
        {
            await RefreshGridView(null, null);
        }

        private async Task RefreshGridView(DateTime? since, DateTime? to)
        {
            Data = new List<RentDetailVM>();

            var rents = await _rents.GetAll(nameof(Employee), nameof(Vehicle), nameof(Customer), nameof(Vehicle) + "." + nameof(Vehicle.VehicleModel));

            if (since != null && to != null)
                rents = rents.Where(r => r.RentDate >= since && r.RentDate <= to).ToList();

            foreach (var rent in rents)
                Data.Add(new RentDetailVM(rent));

            GridRents.DataSource = Data.ToDataTable();
        }

        private void PdfBtn_Click(object sender, EventArgs e)
        {
            CreatePDF((GridRents.DataSource as DataTable).DefaultView.ToTable());
        }

        private void CreatePDF(object data)
        {
            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.Pages.Add();

            PdfGrid pdfGrid = new PdfGrid
            {
                DataSource = data
            };

            pdfGrid.Draw(page, new PointF(10, 10));

            string folderPath = "C:\\PdfTest\\";
            if (!System.IO.Directory.Exists(folderPath))
                System.IO.Directory.CreateDirectory(folderPath);

            string fullPath = folderPath + "Reporte_de_rentas_" + DateTime.Now.ToString("ddMMyyyy_HHmmss") + ".pdf";

            doc.Save(fullPath);

            doc.Close(true);

            var wb = new WebBrowser();
            wb.Navigate(fullPath);

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchString = SearchTextBox.Text.Trim(); 
            (GridRents.DataSource as DataTable).DefaultView.RowFilter = string.Format("CedulaCliente LIKE '%{0}%' OR Cliente LIKE '%{0}%'", searchString);

        }

        private async void btnDateFilter_Click(object sender, EventArgs e)
        {
            await RefreshGridView(tpSince.Value, tpTo.Value);
        }
    }
}
