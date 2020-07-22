using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MultiForm
{
    public class VM : INotifyPropertyChanged
    {
        public BindingList<Employee> Employees { get; set; }

        private Employee selectedEmployee;

        public Employee SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;
                onChange();
            }
        }

        //constructor of VM class
        public VM()
        {
            Employees = new BindingList<Employee>(Database.GetInstance().Read());
        }

        //check whether the employee is selected or not
        public bool EmployeeNotSelected()
        {
            return selectedEmployee is null;
        }

        //creating new empty employee and assign it to SelectedEmployee
        public void NewSelectedEmployee()
        {
            Employee e = new Employee();
            SelectedEmployee = e;
        }
        #region propertychanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void onChange([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
