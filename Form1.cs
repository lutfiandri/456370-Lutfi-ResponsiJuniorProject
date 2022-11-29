using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Responsi
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            var connstring = "Host=localhost;Port=2022;Username=lutfiandri;Password=glhf;Database=responsi";
            conn = new NpgsqlConnection(connstring);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                Console.WriteLine("db connected");
                //MessageBox.Show("db connected");
            }
            catch
            {
                MessageBox.Show("Gagal konek db");
            }

            loadData();
            loadKeterangan();

            var deps = getListDep();
            for (int i = 0; i > deps.Count; i++)
            {
                inputDepartemen.AutoCompleteCustomSource.Add(deps[i]);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if(inputDepartemen.Text == "" || inputNama.Text == "")
                {
                    MessageBox.Show("Nama Karyawan dan Dep. Departemen harus diisi");
                    return;
                }

                var idDep = getDepId(inputDepartemen.Text);
                if(idDep == 0)
                {
                    MessageBox.Show("Mohon tulis dengan departemen yang tersedia. HR, Engineer, Delevoper, Product M, Finance.");
                    return;

                }

                var sql = "select * from insert_karyawan(:nama, :id_dep)";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("nama", inputNama.Text);
                cmd.Parameters.AddWithValue("id_dep", idDep);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan!");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data gagal ditambahkan. {ex.Message}");
            }
        }

        private int getDepId(string dep_name)
        {
            switch(dep_name) {
                case "HR":
                    return 1;
                case "Engineer":
                    return 2;
                case "Developer":
                    return 3;
                case "Product M":
                    return 4;
                case "Finance":
                    return 5;
                default:
                    return 0;
            }
        }

        private List<string> getListDep()
        {
            var list = new List<string>();
            list.Add("HR");
            list.Add("Engineer");
            list.Add("Developer");
            list.Add("Product M");
            list.Add("Finance");

            return list;
        }

        private string formatBoxKaryawan(NpgsqlDataReader data)
        {
            var text = "List Karyawan\n";
            if (data.HasRows)
            {
                while (data.Read())
                {
                    var row = $"ID: {data.GetInt32(0)} --- Nama: {data.GetString(1)} --- Departemen: {data.GetString(2)}\n";
                    text += row;
                }
            }

            return text;
        }

        private void loadData()
        {
            try
            {
                var sql = "select * from select_all_karyawan()";
                var cmd = new NpgsqlCommand(sql, conn);

                var data = cmd.ExecuteReader();

                // ngga tau cara set data ke grid view :(

                boxKaryawan.Text = formatBoxKaryawan(data);

                data.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat mengambil data. {ex.Message}");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(inputKaryawanId.Text == "")
                {
                    MessageBox.Show("ID Karyawan harus diisi");
                    return;
                }

                if (inputDepartemen.Text == "" || inputNama.Text == "")
                {
                    MessageBox.Show("Nama Karyawan dan Dep. Departemen harus diisi");
                    return;
                }

                var idDep = getDepId(inputDepartemen.Text);
                if (idDep == 0)
                {
                    MessageBox.Show("Mohon tulis dengan departemen yang tersedia. HR, Engineer, Delevoper, Product M, Finance.");
                    return;
                }

                var sql = "select * from update_karyawan(:id, :nama, :id_dep)";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(inputKaryawanId.Text));
                cmd.Parameters.AddWithValue("nama", inputNama.Text);
                cmd.Parameters.AddWithValue("id_dep", idDep);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diubah!");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data gagal diubah. {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputKaryawanId.Text == "")
                {
                    MessageBox.Show("ID Karyawan harus diisi");
                    return;
                }

                var sql = "select * from delete_karyawan(:id)";
                var cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(inputKaryawanId.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil dihapus!");
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data gagal dihapus. {ex.Message}");
            }
        }

        private void loadKeterangan()
        {
            boxKeterangan.Text = "\nID Departemen\n";
            boxKeterangan.Text += "HR: HR\n";
            boxKeterangan.Text += "ENG: Engineer\n";
            boxKeterangan.Text += "DEV: Developer\n";
            boxKeterangan.Text += "PM: Product M\n";
            boxKeterangan.Text += "FIN: Finance\n";
        }
    }
}
