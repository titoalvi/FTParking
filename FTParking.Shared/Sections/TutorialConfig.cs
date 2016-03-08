using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.Html;
using AppStudio.DataProviders.LocalStorage;
using FTParking.Config;
using FTParking.ViewModels;

namespace FTParking.Sections
{
    public class TutorialConfig : SectionConfigBase<LocalStorageDataConfig, HtmlSchema>
    {
        public override DataProviderBase<LocalStorageDataConfig, HtmlSchema> DataProvider
        {
            get
            {
                return new HtmlDataProvider();
            }
        }

        public override LocalStorageDataConfig Config
        {
            get
            {
                return new LocalStorageDataConfig
                {
                    FilePath = "/Assets/Data/Tutorial.htm"
                };
            }
        }


        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("TutorialListPage");
            }
        }


        public override ListPageConfig<HtmlSchema> ListPage
        {
            get 
            {
                return new ListPageConfig<HtmlSchema>
                {
                    Title = "Tutorial",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Content = item.Content;
                    },
                    NavigationInfo = (item) =>
                    {
                        return null;
                    }
                };
            }
        }

        public override DetailPageConfig<HtmlSchema> DetailPage
        {
            get { return null; }
        }

        public override string PageTitle
        {
            get { return "Tutorial"; }
        }

    }
}
