﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belajar_koneksi
{
    public partial class tabel_pelanggan : Form
    {
        public tabel_pelanggan()
        {
            InitializeComponent();
        }

        private void tabel_pelanggan_Load(object sender, EventArgs e)
        {
            var str = "server=localhost; port=5432; user id=postgres; database=contoh_koneksi; password=12345";
            NpgsqlConnection conn = new NpgsqlConnection(str);
            conn.Open();

            var sql = "select * from transaksi";

            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            var dataReader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dataReader);

            conn.Close();

            dataGridView1.DataSource = dt;
        }
    }
}
