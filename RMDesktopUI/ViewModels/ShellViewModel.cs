using Caliburn.Micro;
using RMDesktopUI.EventModels;
using RMDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMDesktopUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SalesViewModel _salesVM;
        private ILoggedInUserModel _user;

        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM, ILoggedInUserModel user)
        {
            _events = events;
            _salesVM = salesVM;
            _user = user;

            _events.Subscribe(this);

            
            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public bool IsLoggedIn
        {
            get 
            {
                bool output = false;

                if (string.IsNullOrWhiteSpace(_user.Token) == false)
                {
                    output = true;
                }

                return output;
            }
        }

        /// <summary>
        /// Logs user out
        /// </summary>
        public void LogOut()
        {
            _user.LogOffuser(); //reset user model
            ActivateItem(IoC.Get<LoginViewModel>());  //Display the login page

            NotifyOfPropertyChange(() => IsLoggedIn);
        }

        /// <summary>
        /// closes the application
        /// </summary>
        public void ExitApplication()
        {
            TryClose();
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
            NotifyOfPropertyChange(() => IsLoggedIn);
        }
    }
}
