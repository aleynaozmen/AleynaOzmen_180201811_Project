namespace AleynaOzmen_180201811_Project;

public partial class AssignmentPages: ContentPage
{
    public AssignmentPages()
    {
        InitializeComponent();
        Assignment.ItemsSource = App.dBTransFixed.GetAllAssignment();
    }

    public int Assignment_id { get; internal set; }

    private void Project_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }

    private void Employee_ItemTapped(object sender, ItemTappedEventArgs e)
    {

    }

    private void Add_Clicked(object sender, EventArgs e)
    {

    }

    private void Show_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}