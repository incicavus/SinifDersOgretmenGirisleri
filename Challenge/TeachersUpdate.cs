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
    public partial class TeachersUpdate : Form
    {
        public TeachersUpdate()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand(string.Format("update Teachers set Name='{0}' where TeacherID={1}", txtName.Text, txtID.Text), con);

            con.Open();
            güncelle.ExecuteNonQuery();
            con.Close();
        }

        private void TeachersUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
