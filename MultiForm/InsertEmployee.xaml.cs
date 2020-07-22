using System.Windows;

namespace MultiForm
{
    /// <summary>
    /// Interaction logic for InsertEmployee.xaml
    /// </summary>
    public partial class InsertEmployee : Window
    {
        VM vm;
        public InsertEmployee(VM vm)
        {
            InitializeComponent();
            this.vm = vm;
            DataContext = vm;
        }
        //click event for insert
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectedEmployee.name is null && vm.SelectedEmployee.position is null && vm.SelectedEmployee.hourly_pay_rate is null)
                MessageBox.Show("Insert the values", "Error Message!");
            else
            {
                Database db = Database.GetInstance();
                db.Insert(vm.SelectedEmployee);
                Close();
                vm.Employees.Add(vm.SelectedEmployee);
            }
        }
    }
}
