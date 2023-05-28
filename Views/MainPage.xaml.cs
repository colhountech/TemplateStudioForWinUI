using Microsoft.UI.Xaml.Controls;

using TemplateStudioForWinUI.ViewModels;

namespace TemplateStudioForWinUI.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
