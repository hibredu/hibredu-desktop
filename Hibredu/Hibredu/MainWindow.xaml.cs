using System.Linq;
using Hibredu.Data;
using System.Windows;

using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Hibredu;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly Context context;
    public List<Student> StudentsData { get; set; }
    Student NewProduct = new();
    Student selectedProduct = new();

    public MainWindow(Context context)
    {
        this.context = context;
        this.StudentsData = context.Students.ToList();
        InitializeComponent();
        GetProducts();
        NewStudentGrid.DataContext = NewProduct;
    }

    private void GetProducts()
    {
        StudentDataGrid.ItemsSource = context.Students.ToList();
        StudentesInGradeRange.ItemsSource = StudentesInGradeRanges(context.Students.ToList());
    }

    private void AddItem(object s, RoutedEventArgs e)
    {
        context.Students.Add(NewProduct);
        context.StudentsData.Add(NewProduct);
        context.SaveChanges();
        GetProducts();
        NewProduct = new Student();
        NewStudentGrid.DataContext = NewProduct;
    }

    private void UpdateItem(object s, RoutedEventArgs e)
    {
        context.Update(selectedProduct);
        context.SaveChanges();
        GetProducts();
    }

    private void DeleteStudent(object s, RoutedEventArgs e)
    {
        var productToDelete = (s as FrameworkElement).DataContext as Student;
        context.Students.Remove(productToDelete);
        context.StudentsData.Remove(productToDelete);
        context.SaveChanges();
        GetProducts();
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
}