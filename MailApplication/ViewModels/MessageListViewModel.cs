 using MailApplication.Models;
using MailApplication.Services;
using MailApplication.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MailApplication.ViewModels
{
    public class MessageListViewModel : ObservableObject
    {
        private IMessageDataService _service;

        private MessageDetailViewModel _messageDetailVM;
        public MessageDetailViewModel MessageDetailVM
        {
            get { return _messageDetailVM; }
            set { OnPropertyChanged(ref _messageDetailVM, value); }
        }
        public ICommand LoadMessagesCommand { get; set; }
        public MessageListViewModel(IMessageDataService service)
        {
            MessageDetailVM = new MessageDetailViewModel();
            _service = service;
            LoadMessagesCommand = new RelayCommand(LoadMessages);

        }
        public void LoadMessages()
        {
            MessageDetailVM.LoadMessages(_service.GetMessageModels());
        }
    }
}
