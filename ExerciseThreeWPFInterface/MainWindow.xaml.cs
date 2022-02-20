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
            string message = "Name: " + fullName + ", Weight: " + weight +", Grade: " + grade;
            return message;
        }

    }

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

    public partial class MainWindow : Window
    {
        // initialize the student list 
        List<Student> studentList;

        // store total student weights
        public List<double> gradelist = new List<double>();
        public List<double> WeightList = new List<double>();

        public MainWindow()
        {
            InitializeComponent();

            studentList = new List<Student>();

            studentListBox.ItemsSource = studentList;
        }

        private void addButtonClicked(object sender, RoutedEventArgs e)
        {
            // get user data
            string nameInput = userFullNametxtbox.Text;
            double userWeight = Convert.ToDouble(userWeighttxtbox.Text);
            double userGrade = Convert.ToDouble(userGradetxtbox.Text);
            
            Student newStudent = new Student(nameInput,userWeight,userGrade);
            
            // add user to list for later retrieval and display
            studentList.Add(newStudent);

            WeightList.Add(userWeight);
            gradelist.Add(userGrade);

            // make sure the new user input appears into the text box
            studentListBox.Items.Refresh();

            // display the proper txtbox for total amount of students weight and grade
            usersAvgWeighttxtbox.Text = getAvgWeight();
            userAvgGradetxtbox.Text = getAvgGrade();
        }

          // created 2 functions to calculate averages 
          // ~~ you could use one but lets use 2 for no confusion
     
        private string getAvgWeight()
        {
            double sum = 0;
            foreach (var x in WeightList)
            {
                sum = sum + x;
            }
            return (sum / WeightList.Count).ToString();
        }
        
        private string getAvgGrade()
        {
            double sum = 0;
            foreach (var x in gradelist)
            {
                sum = sum + x;
            }
            return (sum / WeightList.Count).ToString();
        }

        private void studentNameDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            // show student grade if clicked on
            if (studentListBox.SelectedIndex != -1)
            {
                // created a new student within this class to display the total weight
                Student receipt = (Student)this.studentListBox.SelectedItem;
                MessageBox.Show(receipt.ToString());
                
            }





        }
    }
}
