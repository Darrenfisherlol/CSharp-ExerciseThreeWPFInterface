using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExerciseThreeWPFInterface
{
    public class Student
    {
        // user input
        public string fullName;
        public double weight;
        public double grade;

        public Student()
        {

        }
       
        // make student class object
        public Student(string name, double WeightInput, double gradeInput)
        {
            fullName = name;
            weight = WeightInput;
            grade = gradeInput;
        }

        // print students in list box in correct format
        public override string ToString()
        {
            return fullName;
        }
    }

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

    public partial class MainWindow : Window
    {

        List<Student> studentList;


        public MainWindow()
        {
            InitializeComponent();

            studentList = new List<Student>();




        }





    }
}
