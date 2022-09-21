using System.Linq;
using Hibredu.Data;
using System.Windows;

namespace Hibredu;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly Context context;
    Student NewProduct = new();
    Student selectedProduct = new();

    public MainWindow(Context context)
    {
        this.context = context;
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
        context.SaveChanges();
        GetProducts();
    }
}