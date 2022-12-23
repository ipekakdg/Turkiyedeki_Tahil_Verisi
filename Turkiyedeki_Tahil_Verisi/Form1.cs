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

namespace Turkiyedeki_Tahil_Verisi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }
        void tahilVerileri()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");
           
            baglanti.Open();
            da = new SqlDataAdapter("Select * From Tahillar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void tuketimVerileri()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From Tuketim", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void uretimVerileri()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From Uretim", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void stokVerileri()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From Stok", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void tahilkullanimalani()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From TahilinKullanimYeri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void encokuretilenyer()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From EnÇokUretilenYer", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void ithalat()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From İthalat", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void ihracat()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From Ihracat", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void yil()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From Yillar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void sehir()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From EnÇokUretilenYer", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void ulke()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From Ulkeler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void tabanalimi()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("Select * From TabanAlımı", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void encoktahilyetistirilenyer()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1RI3SA7\\SQLEXPRESS;Initial Catalog=Turkiyede_Tahil;Integrated Security=True");

            baglanti.Open();
            da = new SqlDataAdapter("SELECT tahil_no AS TahilId,sehir_adi AS SehirAdi,sehir_uretim_miktari_yuzdeligi as UretimMiktari FROM EnÇokUretilenYer Where sehir_uretim_miktari_yuzdeligi IN (SELECT MAX(sehir_uretim_miktari_yuzdeligi) FROM EnÇokUretilenYer GROUP BY tahil_no) ORDER BY tahil_no", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tuketimVerileri();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tahilVerileri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uretimVerileri();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stokVerileri();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tahilkullanimalani();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabanalimi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ithalat();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ihracat();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            yil();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sehir();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ulke();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            encoktahilyetistirilenyer();
        }
    }
}
