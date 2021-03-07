using LessonİnformationForms.Business;
using LessonİnformationForms.DataAccess;
using LessonİnformationForms.DataAccess.Bases;
using LessonİnformationForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonİnformationForms
{
    public partial class Form1 : Form
    {
        DersService service;
        public Form1()
        {
            InitializeComponent();
            IOperations operation = new FileOperations(Application.StartupPath.Replace(@"bin\Debug", "Data") + @"\DerslerData.txt");
            //IOperations operation = new MemoryOperations();
            service = new DersService(operation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            dgvDersler.DataSource = service.GetList().ToList();
        }

        private void bYeniDers_Click(object sender, EventArgs e)
        {
            gbYeni.Visible = !gbYeni.Visible;
            FillCategories();
        }

        private void FillCategories()
        {
            List<Kategoriler> categoryList = new List<Kategoriler>();
            categoryList = service.GetCategories();
            categoryList.Insert(0, new Kategoriler()
            {
                Text = "Seçiniz!",
                Value = 0
            });
            ddlKategori.DataSource = categoryList;
            ddlKategori.ValueMember = "Value";
            ddlKategori.DisplayMember = "Text"; 
        }



        private void bDetaylar_Click(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Listeden kayıt seçiniz!");
                return;
            }
            int id = Convert.ToInt32(dgvDersler.SelectedRows[0].Cells["id"].Value);
            Dersler dersler = service.GetDers(id);
            MessageBox.Show("Id: " + dersler.Id + "\n" + "Adi: " + dersler.Adi + "\n" +"Ders içeriği: " +dersler.Icerigi + "\n" + "Ders Kategorisi: "+dersler.Kategorisi.ToString() + "\n" + "Kredisi: " + dersler.Kredisi);
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            if (gbYeni.Visible)
                gbYeni.Visible = false;
            if (dgvDersler.SelectedRows.Count == 0)     
            {
                MessageBox.Show("Lütfen kayıt seçiniz.");
                return;
            }
            int id= Convert.ToInt32(dgvDersler.SelectedRows[0].Cells["Id"].Value);
            service.DeleteDers(id);
            FillGrid();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAdi.Text))
            {
                MessageBox.Show("Ders adi giriniz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbİcerigi.Text))
            {
                MessageBox.Show("Ders icerigi giriniz!");
                return;
            }
            if (Convert.ToInt32(ddlKategori.SelectedValue) == 0)
            {
                MessageBox.Show("Kategori seçiniz!");
                return;
            }
            if (nudKredi.Value < 1 && nudKredi.Value > 5)
            {
                MessageBox.Show("Ders kredisi 1-5 arası olmalıdır.");
                return;
            }
            Dersler dersler = new Dersler()
            {
                Adi = tbAdi.Text.Trim(),
                Icerigi = tbİcerigi.Text.Trim(),
                Kategorisi = (Enums.Kategori)ddlKategori.SelectedValue,
                Kredisi = Convert.ToInt32(nudKredi.Value)
            };
            service.AddDers(dersler);
            FillGrid();
        }
    }
}
