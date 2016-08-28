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
    public partial class TeachersDelete : Form
    {
        public TeachersDelete()
        {
            InitializeComponent();
        }
 SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand(string.Format("delete Teachers where TeacherID={0}",txtID.Text), con);

            con.Open();
            sil.ExecuteNonQuery();
            con.Close();
        }

        private void TeachersDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
