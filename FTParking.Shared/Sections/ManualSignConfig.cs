using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.LocalStorage;
using AppStudio.DataProviders.Menu;
using FTParking.Config;
using System;
using System.Collections.Generic;
using AppStudio.Common;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.DataProviders.DynamicStorage;
using Windows.Storage;
using FTParking.ViewModels;

namespace FTParking.Sections
{
    public class ManualSignConfig : SectionConfigBase<LocalStorageDataConfig, MenuSchema>
    {
        public override DataProviderBase<LocalStorageDataConfig, MenuSchema> DataProvider
        {
            get
            {
                return new LocalStorageDataProvider<MenuSchema>();
            }
        }

        public override LocalStorageDataConfig Config
        {
            get
            {
                return new LocalStorageDataConfig
                {
                 
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("ManualSignPage");
            }
        }


        public override ListPageConfig<MenuSchema> ListPage
        {
            get 
            {
                return new ListPageConfig<MenuSchema>
                {
                    Title = "Choose Your Slot: ",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title;
                        viewModel.Image = item.Icon;
                    },
                    NavigationInfo = (item) =>
                    {
                        return item.ToNavigationInfo();
                    }
                };
            }
        }

        public override DetailPageConfig<MenuSchema> DetailPage
        {
            get { return null; }
        }

        public override string PageTitle
        {
            get { return "Choose Your Slot: "; }
        }

    }
}
