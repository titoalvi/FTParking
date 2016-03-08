using System;
using System.Collections.Generic;
using AppStudio.Common;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.DynamicStorage;
using Windows.Storage;
using FTParking.Config;
using FTParking.ViewModels;

namespace FTParking.Sections
{
    public class UserProfileConfig : SectionConfigBase<DynamicStorageDataConfig, UserProfile1Schema>
    {
        public override DataProviderBase<DynamicStorageDataConfig, UserProfile1Schema> DataProvider
        {
            get
            {
                return new DynamicStorageDataProvider<UserProfile1Schema>();
            }
        }

        public override DynamicStorageDataConfig Config
        {
            get
            {
                return new DynamicStorageDataConfig
                {
                    Url = new Uri("http://ds.winappstudio.com/api/data/collection?dataRowListId=a4dc2e83-f553-48ad-b511-2ba1d236acfe&appId=29b68e9b-1f30-40b9-bc34-f38e5f1205f1"),
                    AppId = "29b68e9b-1f30-40b9-bc34-f38e5f1205f1",
                    StoreId = ApplicationData.Current.LocalSettings.Values[LocalSettingNames.StoreId] as string,
                    DeviceType = ApplicationData.Current.LocalSettings.Values[LocalSettingNames.DeviceType] as string
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("UserProfileListPage");
            }
        }

        public override ListPageConfig<UserProfile1Schema> ListPage
        {
            get 
            {
                return new ListPageConfig<UserProfile1Schema>
                {
                    Title = "User Profile",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Name.ToSafeString();
                        viewModel.SubTitle = item.Surname.ToSafeString();
                        viewModel.Description = "";
                        viewModel.Image = item.Thumbnail.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("UserProfileDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<UserProfile1Schema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, UserProfile1Schema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Name.ToSafeString();
                    viewModel.Title = item.Surname.ToSafeString();
                    viewModel.Description = item.PersonalSummary.ToSafeString();
                    viewModel.Image = item.Image.ToSafeString();
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Other data";
                    viewModel.Title = "";
                    viewModel.Description = item.Other.ToSafeString();
                    viewModel.Image = "";
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "Detail";
                    viewModel.Title = item.Phone.ToSafeString();
                    viewModel.Description = item.Mail.ToSafeString();
                    viewModel.Image = "";
                    viewModel.Content = null;
                });

				var actions = new List<ActionConfig<UserProfile1Schema>>
				{
                    ActionConfig<UserProfile1Schema>.Mail("Mail", (item) => item.Mail.ToSafeString()),
                    ActionConfig<UserProfile1Schema>.Phone("Phone", (item) => item.Phone.ToSafeString()),
				};

                return new DetailPageConfig<UserProfile1Schema>
                {
                    Title = "User Profile",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "User Profile"; }
        }

    }
}
