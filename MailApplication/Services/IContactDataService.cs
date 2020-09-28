using MailApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailApplication.Services
{
    public interface IContactDataService
    {
        IEnumerable<ContactModel> GetContactModels();
        void Save(IEnumerable<ContactModel> contactModels);
    }
}
