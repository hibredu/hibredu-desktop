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
}