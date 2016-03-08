using System;
using AppStudio.Common;
using Windows.ApplicationModel;

namespace FTParking.ViewModels
{
    public class AboutThisAppViewModel : ObservableBase
    {
        public string Publisher
        {
            get
            {
                return "AppStudio";
            }
        }

        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }

        public string AboutText
        {
            get
            {
                return "Application by Tito Alvi Nugroho :D";
            }
        }
    }
}

