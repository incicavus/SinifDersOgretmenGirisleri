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
    public partial class Lessons : Form
    {
        public Lessons()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.; database=WN11; integrated security=true");
        private void Lessons_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSubject.Text))
            {
                SqlCommand ekle = new SqlCommand();
                ekle.CommandText = string.Format("insert Lessons (Subject,Hour,Credit) values ('{0}',{1},{2})",txtSubject.Text,txtHour.Text,txtCredit.Text);

                ekle.Connection = con;
                con.Open();
                ekle.ExecuteNonQuery();
                con.Close();
            }

            else
            {
                MessageBox.Show("Subject alanı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        }
    }

