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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                SqlCommand ekle = new SqlCommand();
                ekle.CommandText = "insert Teachers (Name) values ('" + txtName.Text + "')";

                ekle.Connection = con;
                con.Open();
                ekle.ExecuteNonQuery();
                con.Close();
            }

            else
            {
                MessageBox.Show("Name alanı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Teachers_Load(object sender, EventArgs e)
        {

        }
    }
}
