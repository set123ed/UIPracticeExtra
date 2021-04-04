using System;
using System.ComponentModel;
using Prism.Navigation;

namespace UIPractice.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged 
    {
        public  INavigationService NavigationService { get; }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
