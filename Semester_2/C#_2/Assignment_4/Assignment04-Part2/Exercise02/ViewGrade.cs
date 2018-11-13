using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02
{
    public partial class ViewGrade : Form
    {
        public ViewGrade()
        {
            InitializeComponent();
        }


        class Student
        {
            public string Name { get; set; }
            public double Grades { get; set; }
            public Student(string name, double grades)
            {
                Name = name;
                Grades = grades;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        private void ViewGrade_Load(object sender, EventArgs e)
        {
            Student st1 = new Student("Peter Yoon", 100);
            Student st2 = new Student("Chris Brown", 90);
            Student st3 = new Student("Alice Green", 75);
            listBox1.Items.AddRange(new Student[] { st1, st2, st3 });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectedEmp = new Student("", 0);
            selectedEmp = (Student)listBox1.SelectedItem;
            lblOutput.Text = selectedEmp.Name + "'s grade is " +
                selectedEmp.Grades + "%";
        }
    }
}
