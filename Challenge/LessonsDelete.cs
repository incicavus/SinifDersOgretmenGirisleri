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
    public partial class LessonsDelete : Form
    {
        public LessonsDelete()
        {
            InitializeComponent();
        }
 SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand(string.Format("delete Lessons where LessonID={0}", txtID.Text), con);
            con.Open();
            sil.ExecuteNonQuery();
            con.Close();
        }
    }
}
