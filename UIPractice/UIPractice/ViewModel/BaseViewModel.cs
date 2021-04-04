using System;
using System.ComponentModel;
using Prism.Navigation;

namespace UIPractice.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged 
    {
        public  INavigationService NavigationService { get; }

        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
