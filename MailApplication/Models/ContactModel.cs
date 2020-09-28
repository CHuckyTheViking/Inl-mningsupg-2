using MailApplication.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailApplication.Models
{
    public class ContactModel : ObservableObject
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { OnPropertyChanged(ref _name, value); }
        }

        private string _imageSource;
        public string ImageSource
        {
            get { return _imageSource; }
            set { OnPropertyChanged(ref _imageSource, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { OnPropertyChanged(ref _email, value); }
        }

        private string _work;
        public string Work
        {
            get { return _work; }
            set { OnPropertyChanged(ref _work, value); }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { OnPropertyChanged(ref _phone, value); }
        }

    }
}
