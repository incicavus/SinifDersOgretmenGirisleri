using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Challenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void veriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers();
            teacher.ShowDialog();

        }

        private void lessonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lessons lessons = new Lessons();
            lessons.ShowDialog();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();
            classes.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void teachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TeachersUpdate update = new TeachersUpdate();
            update.ShowDialog();
        }

        private void lessonsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LessonsUpdate update = new LessonsUpdate();
            update.ShowDialog();
        }

        private void classessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassesUpdate update = new ClassesUpdate();
            update.ShowDialog();
        }

        private void teachersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TeachersDelete delete = new TeachersDelete();
            delete.ShowDialog();
        }

        private void lessonsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            LessonsDelete delete = new LessonsDelete();
            delete.ShowDialog();
        }

        private void classessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClassesDelete delete = new ClassesDelete();
            delete.ShowDialog();
        }

        

       

     

    }
}
