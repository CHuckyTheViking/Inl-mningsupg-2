using MailApplication.Models;
using MailApplication.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MailApplication.ViewModels
{
    public class ContactDetailViewModel : ObservableObject
    {
        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set { OnPropertyChanged(ref _selectedContact, value); }
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

        public ObservableCollection<ContactModel> Contacts { get; private set; }

        public ICommand DisplayContact { get; private set; }

        public ContactDetailViewModel()
        {
            DisplayContact = new RelayCommand(Display, CanDisplay);
        }

        private void Display()
        {
            IsDisplayMode = true;
        }
        private bool CanDisplay()
        {
            if (SelectedContact == null)
                return false;

            return !IsDisplayMode;
        }

        public void LoadContacts(IEnumerable<ContactModel> contacts)
        {
            Contacts = new ObservableCollection<ContactModel>(contacts);
            OnPropertyChanged("Contacts");
        }

    }
}
