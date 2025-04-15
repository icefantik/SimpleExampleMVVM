using SimpleExampleMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleExampleMVVM.ViewModels;

public class SendCommentViewModel : INotifyPropertyChanged
{
    //private SendCommentModel _sendCommentModel;

    private string? _comment;

    public string Comment
    {
        get => _comment!;
        set
        {
            if (_comment != value)
            {
                _comment = value;

                RaisePropertyChanged();

                RaisePropertyChanged(nameof(Comment));
            }
        }
    }

    //public SendCommentViewModel()
    //{
    //    _sendCommentModel = new SendCommentModel();
    //}

    public event PropertyChangedEventHandler? PropertyChanged;

    private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public void SendComment()
    {
        //_sendCommentModel.SendComment(Comment);
    }
}
