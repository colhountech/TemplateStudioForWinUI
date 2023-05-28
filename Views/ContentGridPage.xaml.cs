using Microsoft.UI.Xaml.Controls;

using TemplateStudioForWinUI.ViewModels;

namespace TemplateStudioForWinUI.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
