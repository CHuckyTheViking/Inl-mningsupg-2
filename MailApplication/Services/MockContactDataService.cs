using MailApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailApplication.Services
{
    public class MockContactDataService : IContactDataService
    {
        private IEnumerable<ContactModel> _contactModels;

        public MockContactDataService()
        {
            _contactModels = new List<ContactModel>()
            {
                new ContactModel
                {
                    Name = "Oscar Larsson",
                    Work = "Truckdriver",
                    Email = "oscar.larsson@kopparbergs.se",
                    Phone = "070-7152235",
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Oscar.jpg"
                },
                new ContactModel
                {
                    Name = "Kurt Svensson",
                    Work = "Retired firefighter",
                    Email = "kurt.svensson1957@hotmail.com",
                    Phone = "073-4017560",
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kurt.jpg"
                },
                new ContactModel
                {
                    Name = "Göran Karlsson",
                    Work = "Car salesman",
                    Email = "göran.karlsson@bmwbilar.se",
                    Phone = "070-8120023",
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Göran.jpg"
                },
                new ContactModel
                {
                    Name = "Kalle Eriksson",
                    Work = "Retired",
                    Email = "kalle.eriksson@telia.se",
                    Phone = "076-2226459",
                    ImageSource = @"C:\Users\Jesper\source\repos\Inlämningsupg 2\MailApplication\Resources\Kalle.jpg"
                }
            };

        }

        public IEnumerable<ContactModel> GetContactModels()
        {
            return _contactModels;
        }

        public void Save(IEnumerable<ContactModel> contactModels)
        {
            _contactModels = contactModels;
        }

    }
}
