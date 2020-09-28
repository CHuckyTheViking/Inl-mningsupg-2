using MailApplication.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MailApplication.Models
{
    public class MessageModel : ObservableObject
    {
        private string _toName;
        public string ToName
        {
            get { return _toName; }
            set { OnPropertyChanged(ref _toName, value); }
        }

        private string _fromName;
        public string FromName
        {
            get { return _fromName; }
            set { OnPropertyChanged(ref _fromName, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { OnPropertyChanged(ref _message, value); }
        }

        private string _messageHeadline;
        public string MessageHeadline
        {
            get { return _messageHeadline; }
            set { OnPropertyChanged(ref _messageHeadline, value); }
        }

        private string _imageSource;
        public string ImageSource
        {
            get { return _imageSource; }
            set { OnPropertyChanged(ref _imageSource, value); }
        }

    }
}
