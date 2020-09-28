using MailApplication.Services;
using MailApplication.Utility;
using MailApplication.ViewModels;
using MailApplication.Views;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Input;

namespace MailApplication
{
    public class AppViewModel :  ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { OnPropertyChanged(ref _currentView, value); }
        }

        private MessageListViewModel _messageListVM;
        public MessageListViewModel MessageListVM
        {
            get { return _messageListVM; }
            set { OnPropertyChanged(ref _messageListVM, value); }
        }

        private ContactListViewModel _contactListVM;
        public ContactListViewModel ContactListVM
        {
            get { return _contactListVM; }
            set { OnPropertyChanged(ref _contactListVM, value); }
        }
        
        public dynamic dataMessageService = new MockMessageDataService();
        public dynamic dataContactService = new MockContactDataService();
        public AppViewModel()
        {

        }

        public AppViewModel(string val)
        {
            if (val == "Contact")
            {
                ContactListVM = new ContactListViewModel(dataContactService);
                CurrentView = ContactListVM;
            }
            if (val == "Message")
            {
                MessageListVM = new MessageListViewModel(dataMessageService);
                CurrentView = MessageListVM;
            }
        }

    }

    
}
