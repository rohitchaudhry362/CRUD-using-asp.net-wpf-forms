using System.Windows;

namespace MultiForm
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        VM vm;
        public EmployeeWindow(VM vm)
        {
            InitializeComponent();
            this.vm = vm;
            DataContext = vm;
        }

        //Save button click event
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Database db = Database.GetInstance();
            db.Update(vm.SelectedEmployee);
            Close();
        }
    }
}
