using MailApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailApplication.Services
{
    public interface IMessageDataService
    {
        IEnumerable<MessageModel> GetMessageModels();
        void Save(IEnumerable<MessageModel> messageModels);
    }
}
