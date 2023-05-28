using Microsoft.UI.Xaml.Controls;

using TemplateStudioForWinUI.ViewModels;

namespace TemplateStudioForWinUI.Views;

public sealed partial class TodoPage : Page
{
    public TodoViewModel ViewModel
    {
        get;
    }

    public TodoPage()
    {
        ViewModel = App.GetService<TodoViewModel>();
        InitializeComponent();
    }
}
