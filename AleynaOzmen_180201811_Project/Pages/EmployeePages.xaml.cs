namespace AleynaOzmen_180201811_Project;
public partial class EmployeePages : ContentPage
{
    public object Emp_name { get; private set; }
    public int Emp_id { get; internal set; }

    public EmployeePages()
    {
        InitializeComponent();
        EmployeeList.ItemsSource = App.dBTransFixed.GetAllEmployee();
    }


  
    private void Add_Clicked(object sender, EventArgs e)
    {
        App.dBTransFixed.AddEmployee(new Models.Employee
        {
            Emp_name = EmployeeName.Text,
        }) ;
    }

    private void Show_Clicked(object sender, EventArgs e)
    {
        EmployeeList.ItemsSource = App.dBTransFixed.GetAllEmployee();
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        App.dBTransFixed.DeleteEmployee((int)button.BindingContext);
        EmployeeList.ItemsSource = App.dBTransFixed.GetAllEmployee();
    }

    private void DepartmentList_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }
}