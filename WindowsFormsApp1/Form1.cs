using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
           
            table.Columns.Add("id",typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("item_code", typeof(string));
            table.Columns.Add("price", typeof(int));

          
            table.Rows.Add(1,"Sabun Rinso","001",2000);
            table.Rows.Add(2, "Sabun Biore", "002", 3000);
            table.Rows.Add(3, "Mentega forvita", "003", 2500);
           
            dataGridView1.DataSource = table;
            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["name"].HeaderText = "Nama Barang";
            dataGridView1.Columns["item_code"].HeaderText = "Kode Item";
            dataGridView1.Columns["price"].HeaderText = "Harga Satuan";
            // 2. Tambahkan ButtonColumn secara terpisah ke DataGridView
            if (!dataGridView1.Columns.Contains("btnAdd"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnAdd";
                btnColumn.HeaderText = "Aksi";
                btnColumn.Text = "Add";
                btnColumn.UseColumnTextForButtonValue = true;

                // --- 2. MENGECILKAN UKURAN (Piksel: Kiri, Atas, Kanan, Bawah) ---
                // Semakin besar angka padding, semakin kecil tombolnya
                btnColumn.DefaultCellStyle.Padding = new Padding(5, 5, 5, 5);

                // Tambahkan ke koleksi kolom DataGridView
                dataGridView1.Columns.Add(btnColumn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Pastikan yang diklik adalah tombol "btnAdd" dan bukan Header (Index -1)
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnAdd")
            {
                // 2. Ambil objek Baris (Row) yang sedang diklik
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // 3. Ambil data dari kolom spesifik berdasarkan Nama Kolom di DataTable
                string id = row.Cells["id"].Value?.ToString();
                string nama = row.Cells["name"].Value?.ToString();
                string harga = row.Cells["price"].Value?.ToString();

                // 4. Contoh penggunaan data: Masukkan ke ListBox atau tampilkan Pesan
                //MessageBox.Show($"Menambahkan Item: {nama} dengan Harga: {harga}");

                // Anda bisa menggabungkan beberapa data menjadi satu baris teks
                if (!string.IsNullOrEmpty(nama))
                {
                    int y = total_item_list.Controls.Count * 25;
                    TextBox txtInput = new TextBox
                    {
                        Name = "item_id_" + id,
                        Text = harga,
                        Width = 50,
                        Location = new Point(10, y),
                        TextAlign = HorizontalAlignment.Center
                    };

                    TextBox txtItem = new TextBox
                    {
                        Name = "item_name_" + id,
                        Text = $"{nama} - Rp{harga}",
                        Width = 200,
                        Location = new Point(3, y),
                        Enabled = false
                    };

                    TextBox txtPrice = new TextBox
                    {
                        Name = "price_" + id,
                        Text = $"{harga}",
                        Width = 100,
                        Location = new Point(3, y),
                        Enabled = false
                    };

                    detail_item_name.Controls.Add(txtItem);
                    total_item_list.Controls.Add(txtInput);
                    detail_price.Controls.Add(txtPrice);

                    totalItem.Text = "1"; // add value 
                    totalPrice.Text = harga;
                }

                // Jika ingin memindahkan ke ListBox:
                // listBox1.Items.Add($"{nama} - {harga}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
