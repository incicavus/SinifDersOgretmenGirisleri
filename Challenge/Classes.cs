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
namespace Challenge
{
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        } 
        SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");

        private void Classes_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRoom.Text))
            {
                SqlCommand ekle = new SqlCommand();
                ekle.CommandText = string.Format("insert Classes (Room,Capacity) values('{0}',{1})", txtRoom.Text, txtCapacity.Text);
                ekle.Connection = con;
                con.Open();
                ekle.ExecuteNonQuery();
                con.Close();
            }

            else
            {
                MessageBox.Show("Room alanı boş bırakılamaz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
