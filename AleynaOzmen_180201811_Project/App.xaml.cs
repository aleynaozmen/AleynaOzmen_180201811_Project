using AleynaOzmen_180201811_Project.DBTrans;

namespace AleynaOzmen_180201811_Project;

public partial class App : Application
{
    public static dBTransFixed dBTransFixed { get; private set; }

    public App(dBTransFixed dbTrans)
    {
        InitializeComponent();

        MainPage = new AppShell();
        dBTransFixed = dbTrans;
    }
}
