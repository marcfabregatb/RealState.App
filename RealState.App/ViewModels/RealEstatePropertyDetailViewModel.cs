﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RealEstate.App.Models;
using RealEstate.App.ViewModels.Interfaces;

namespace RealEstate.App.ViewModels
{
    
    public partial class RealEstatePropertyDetailViewModel : BaseViewModel, IRealEstatePropertyDetailViewModel, IQueryAttributable
    {
        [ObservableProperty]private RealEstateProperty _realEstateProperty;

        public RealEstatePropertyDetailViewModel()
        {

        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            RealEstateProperty = query["RealEstateProperty"] as RealEstateProperty;
        }

        [RelayCommand]
        private async void NavigateToAgentProfile(Agent agentProfile)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "AgentProfile", agentProfile }
            };
            await Shell.Current.GoToAsync("AgentProfilePage", navigationParameter);
        }
    }
}
