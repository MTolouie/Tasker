using Tasker.MVVM.ViewModels;

namespace Tasker.MVVM.Views;

public partial class MainView : ContentPage
{
    private MainViewModel mainViewModel = new MainViewModel();

    public MainView()
    {
        InitializeComponent();
        BindingContext = mainViewModel;
    }

    private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        mainViewModel.UpdateData();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var newTaskPage = new NewTaskView()
        {

            BindingContext = new NewTaskViewModel()
            {
                Categories = mainViewModel.Categories,
                Tasks = mainViewModel.Tasks,

            }
        };

        await Navigation.PushAsync(newTaskPage);
    }
}