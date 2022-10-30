using System.Linq;
using Hibredu.Data;
using System.Windows;

using System;
using System.Collections.Generic;
using MathNet.Numerics.Statistics;

namespace Hibredu;

public partial class MainWindow : Window
{
    private readonly Context context;
    Student NewStudent = new();
    Student selectedStudent = new();

    public MainWindow(Context context)
    {
        this.context = context;
        InitializeComponent();
        GetStudents();
        NewStudentGrid.DataContext = NewStudent;
    }

    private void GetStudents()
    {
        var students = context.Students.ToList();
        StudentsDataAverage.ItemsSource = students;
        StudentsDataFrequency.ItemsSource = students;
        StudentDataGrid.ItemsSource = students;
        StudentesInGradeRange.ItemsSource = StudentesInGradeRanges(students);
        StudentesInFrequencyRange.ItemsSource = StudentesInFrequencyRanges(students);
        StudentesAverageInfo.ItemsSource = StudentesAverageInfos(students);
        StudentesFrequencyInfo.ItemsSource = StudentesFrequencyInfos(students);
    }

    private void AddStudent(object s, RoutedEventArgs e)
    {
        context.Students.Add(NewStudent);
        context.SaveChanges();
        GetStudents();
        NewStudent = new Student();
        NewStudentGrid.DataContext = NewStudent;
    }

    private void UpdateStudent(object s, RoutedEventArgs e)
    {
        context.Update(selectedStudent);
        context.SaveChanges();
        GetStudents();
    }

    private void DeleteStudent(object s, RoutedEventArgs e)
    {
        var studentToDelete = (s as FrameworkElement).DataContext as Student;
        context.Students.Remove(studentToDelete);
        context.SaveChanges();
        GetStudents();
    }

    private List<GenericTable> StudentesInGradeRanges(List<Student> listStudents)
    {
        var listRanges = new List<GenericTable> { new GenericTable
            {
                column1 = 0,
                column2 = 0,
                column3 = 0,
                column4 = 0
            }};

        for(int studentNum = 0; studentNum < listStudents.Count; studentNum++)
        {
            if (listStudents[studentNum].Average < 2.5)
            {
                listRanges[0].column1++;
            }else if (listStudents[studentNum].Average < 5.0)
            {
                listRanges[0].column2++;
            }
            else if (listStudents[studentNum].Average < 7.5)
            {
                listRanges[0].column3++;
            }
            else
            {
                listRanges[0].column4++;
            }

        }

        return listRanges;

    }

    private List<GenericTable> StudentesInFrequencyRanges(List<Student> listStudents)
    {
        var listRanges = new List<GenericTable> { new GenericTable
            {
                column1 = 0,
                column2 = 0,
                column3 = 0,
                column4 = 0
            }};

        for (int studentNum = 0; studentNum < listStudents.Count; studentNum++)
        {
            if (listStudents[studentNum].Frequency < 0.25)
            {
                listRanges[0].column1++;
            }
            else if (listStudents[studentNum].Frequency < 0.50)
            {
                listRanges[0].column2++;
            }
            else if (listStudents[studentNum].Frequency < 0.75)
            {
                listRanges[0].column3++;
            }
            else
            {
                listRanges[0].column4++;
            }

        }

        return listRanges;

    }

    private List<GenericTable> StudentesAverageInfos(List<Student> listStudents)
    {
        double studentGrade;

        var averageInfo = new List<GenericTable> { new GenericTable
            {
                column1 = 0,
                column2 = 0,
                column3 = 0,
                column4 = 0,
                column5 = 0
            }};

        var averageList = new List<double>();

        for (int studentNum = 0; studentNum < listStudents.Count; studentNum++)
        {
            studentGrade = listStudents[studentNum].Average;
            averageList.Add(studentGrade);
        }

        averageInfo[0].column1 = Math.Round(averageList.Average(), 3);
        averageInfo[0].column2 = Math.Round(averageList.Median(), 3);
        averageInfo[0].column3 = Math.Round(averageList.StandardDeviation(), 3);
        averageInfo[0].column4 = Math.Round(averageList.Min(), 3);
        averageInfo[0].column5 = Math.Round(averageList.Max(), 3);

        return averageInfo;
    }

    private List<GenericTable> StudentesFrequencyInfos(List<Student> listStudents)
    {
        double studentGrade;

        var frequencyInfo = new List<GenericTable> { new GenericTable
            {
                column1 = 0,
                column2 = 0,
                column3 = 0,
                column4 = 0,
                column5 = 0
            }};

        var frequencyList = new List<double>();

        for (int studentNum = 0; studentNum < listStudents.Count; studentNum++)
        {
            studentGrade = listStudents[studentNum].Frequency;
            frequencyList.Add(studentGrade);
        }

        frequencyInfo[0].column1 = Math.Round(frequencyList.Average(), 3);
        frequencyInfo[0].column2 = Math.Round(frequencyList.Median(), 3);
        frequencyInfo[0].column3 = Math.Round(frequencyList.StandardDeviation(), 3);
        frequencyInfo[0].column4 = Math.Round(frequencyList.Min(), 3);
        frequencyInfo[0].column5 = Math.Round(frequencyList.Max(), 3);

        return frequencyInfo;
    }
}