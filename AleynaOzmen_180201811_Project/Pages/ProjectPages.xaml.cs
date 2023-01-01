namespace AleynaOzmen_180201811_Project;

public partial class ProjectPages : ContentPage
{


	
	public ProjectPages()
	{
		InitializeComponent();
        ProjectList.ItemsSource = App.dBTransFixed.GetAllProject();
	}


    private void Add_Clicked(object sender, EventArgs e)
    {
        App.dBTransFixed.AddProject(new Models.Project
        { 
          Project_name = ProjectName.Text,
        });
    }

    private void Show_Clicked(object sender, EventArgs e)
    {
        ProjectList.ItemsSource = App.dBTransFixed.GetAllProject();
    }



   
	private void Button_Clicked(object sender, EventArgs e)
	{

	}

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        ProjectList.ItemsSource = App.dBTransFixed.GetAllProject();
    }


}