using MailApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailApplication.Services
{
    public class MockMessageDataService : IMessageDataService
    {
        private IEnumerable<MessageModel> _messageModels;

        public MockMessageDataService()
        {
            _messageModels = new List<MessageModel>()
            {
                new MessageModel
                {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Oscar.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Oscar Larsson",
                    MessageHeadline = "What is different about short",
                    Message = "To begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s important"
                },
                 new MessageModel
                 {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Göran.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Göran Karlsson",
                    MessageHeadline = "What kind of language is used?",
                    Message = "IK-profilen dömd tillIK-profilen dömd tillIK-profilen dömd tillIK-profilen dömd till"
                 },
                  new MessageModel
                  {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kurt.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Kurt Svensson",
                    MessageHeadline = "Some practical ideas",
                    Message = "MessageModelMessageModelMessageModelMessageModelMessageModelMessageModelMessageModelMessageModelMessageModelMessageModel"
                    
                  },
                   new MessageModel
                   {
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Åsa Lagerblad",
                    MessageHeadline = "What kind of language is used?",
                    Message = "IK-profilen dömd tillIK-profilen dömd tillIK-profilen dömd tillIK-profilen dömd till"
                   },
                   new MessageModel
                   {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kalle.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Kalle Eriksson",
                    MessageHeadline = "What is different about short",
                    Message = "To begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s important"                 
                   },
                   new MessageModel
                   {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Oscar.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Oscar Larsson",
                    MessageHeadline = "What is different about short",
                    Message = "To begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s important"
                   },
                   new MessageModel
                   {
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kalle.jpg",
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Kalle Eriksson",
                    MessageHeadline = "What is different about short",
                    Message = "To begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s important"
                   },
                   new MessageModel
                   {
                    ToName = "Jesper Müllern <jesper.mullern@utb.ecutveckling.se>",
                    FromName = "Åsa Lagerblad",
                    MessageHeadline = "What is different about short",
                    Message = "To begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s importantTo begin with it’s important"
                   }             
            };
        }
        public IEnumerable<MessageModel> GetMessageModels()
        {
            return _messageModels;
        }

        public void Save(IEnumerable<MessageModel> messageModels)
        {
            _messageModels = messageModels;
        }
    }
}
