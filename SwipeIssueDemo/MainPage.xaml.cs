using System.Collections.ObjectModel;


namespace SwipeIssueDemo;

public partial class MainPage : ContentPage
{

    public ObservableCollection<string> StrList
    {
        get;
        //private set so that client won't be able to set 
        private set;
    }



    public MainPage()
	{
		InitializeComponent();
        StrList=new ObservableCollection<string>();
        for (int i = 0; i < 10; i++)
        {
            StrList.Add(string.Format("item {0}",i));  
        }
		BindingContext = this;
	}

    void OnButtonClicked(object sender, EventArgs e)
    {
        StrList.Clear();
        StrList.Add("New one");
    }

}

