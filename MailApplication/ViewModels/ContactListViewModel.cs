using MailApplication.Services;
using MailApplication.Utility;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace MailApplication.ViewModels
{
    public class ContactListViewModel : ObservableObject
    {
        private IContactDataService _service;

        private ContactDetailViewModel _contactDetailVM;
        public ContactDetailViewModel ContactDetailVM
        {
            get { return _contactDetailVM; }
            set { OnPropertyChanged(ref _contactDetailVM, value); }
        }

        public ICommand LoadContactsCommand { get; set; }

        public ContactListViewModel(IContactDataService service)
        {
            ContactDetailVM = new ContactDetailViewModel();
            _service = service;
            LoadContactsCommand = new RelayCommand(LoadContacts);
        }

        public void LoadContacts()
        {
            ContactDetailVM.LoadContacts(_service.GetContactModels());
        }

        

    }
}
