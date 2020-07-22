using System.Windows;

namespace MultiForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();
        
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            DataContext = vm;
        }

        //update button click event
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (vm.EmployeeNotSelected())
                MessageBox.Show("Select the employee to update", "Error !");    
            else
            {   
                EmployeeWindow ew = new EmployeeWindow(vm)
                {
                    WindowStartupLocation = WindowStartupLocation.CenterOwner,
                    Owner = this
                };
                ew.ShowDialog();
            }
        }

        //delete button click event
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (vm.EmployeeNotSelected())
                MessageBox.Show("Select the employee to delete", "Error !");
            else
            {
                Database db = Database.GetInstance();
                db.Delete(vm.SelectedEmployee.employeeId);
                vm.Employees.Remove(vm.SelectedEmployee);
            }
        }

        //insert button click event
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            vm.NewSelectedEmployee();
            InsertEmployee insert = new InsertEmployee(vm)
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = this
            };
            insert.ShowDialog();
        }
    }
}
