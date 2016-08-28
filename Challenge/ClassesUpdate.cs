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
    public partial class ClassesUpdate : Form
    {
        public ClassesUpdate()
        {
            InitializeComponent();
        }
  SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand(string.Format("update Classes set Room='{0}',Capacity={1} where ClassID={2}", txtRoom.Text.ToString(), txtCapacity.Text, txtID.Text), con);
            con.Open();
            güncelle.ExecuteNonQuery();
            con.Close();
        }

        private void ClassesUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
