using MailApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MailApplication.Utility
{
    public class UpdateViewCommand : ICommand
    {
        private AppViewModel appviewModel;
        

        public UpdateViewCommand(AppViewModel appviewModel)
        {
            this.appviewModel = appviewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "Message")
            {
                appviewModel.GotoMessageListVM();
                //appviewModel.MessageListVM = new MessageListViewModel(appviewModel.dataMessageService);
                //appviewModel.CurrentView = appviewModel.MessageListVM;
                
            }
            else if (parameter.ToString() == "Contact")
            {
                appviewModel.GotoContactListVM();
                //appviewModel.ContactListVM = new ContactListViewModel(appviewModel.dataContactService);
                //appviewModel.CurrentView = appviewModel.ContactListVM;
            }
        }
    }
}
