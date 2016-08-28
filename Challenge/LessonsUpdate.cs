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
    public partial class LessonsUpdate : Form
    {
        public LessonsUpdate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
  SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand güncelle = new SqlCommand(string.Format("update Lessons set Subject='{0}',Hour={1},Credit={2} where LessonID={3}", txtSubject.Text, txtHour.Text, txtCredit.Text, txtID.Text), con);
            con.Open();
            güncelle.ExecuteNonQuery();
            con.Close();
        }

        private void LessonsUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
