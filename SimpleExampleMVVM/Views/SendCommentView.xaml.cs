using SimpleExampleMVVM.ViewModels;
using System.Windows;

namespace SimpleExampleMVVM.Views;

/// <summary>
/// Interaction logic for SendCommentView.xaml
/// </summary>
public partial class SendCommentView : Window
{
    public SendCommentView()
    {
        InitializeComponent();

        //DataContext = new SendCommentViewModel();
    }
}
