using MailApplication.Models;
using MailApplication.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MailApplication.ViewModels
{
    public class MessageDetailViewModel : ObservableObject
    {
        private MessageModel _selectedMessage;
        public MessageModel SelectedMessage
        {
            get { return _selectedMessage; }
            set { OnPropertyChanged(ref _selectedMessage, value); }
        }

        private bool _isDisplayMode;
        public bool IsDisplayMode
        {
            get { return _isDisplayMode; }
            set
            {
                OnPropertyChanged(ref _isDisplayMode, value);
            }
        }

        public ObservableCollection<MessageModel> Messages { get; private set; }

        public ICommand DisplayMessage { get; private set; }


        public MessageDetailViewModel()
        {
            DisplayMessage = new RelayCommand(Display, CanDisplay);
        }

        private void Display()
        {
            IsDisplayMode = true;
        }
        private bool CanDisplay()
        {
            if (SelectedMessage == null)
                return false;

            return !IsDisplayMode;
        }



        public void LoadMessages(IEnumerable<MessageModel> messages)
        {
            Messages = new ObservableCollection<MessageModel>(messages);
            OnPropertyChanged("Messages");
        }
    }
}
