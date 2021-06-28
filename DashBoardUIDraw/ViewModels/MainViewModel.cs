using DashBoardUIDraw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoardUIDraw.ViewModels
{
    public class MainViewModel
    {
        List<MeunInfo> meunInfos = null;

        MeunInfo currentMenu = null;

        List<SaleInfo> saleInfos = null;

        GeoInfo geoInfo = null;

        public MainViewModel()
        {
            meunInfos = new List<MeunInfo>();
            meunInfos.Add(new MeunInfo { Icon = "\xedcd", Title = "Office Online" });
            meunInfos.Add(new MeunInfo { Icon = "\xe653", Title = "Outlook" });
            meunInfos.Add(new MeunInfo { Icon = "\xe648", Title = "Skype" });
            meunInfos.Add(new MeunInfo { Icon = "\xf26c", Title = "XBox Game" });
            meunInfos.Add(new MeunInfo { Icon = "\xeb4c", Title = "Bing" });
            meunInfos.Add(new MeunInfo { Icon = "\xec16", Title = "Azure" });

            currentMenu = meunInfos.First();

            saleInfos = new List<SaleInfo>();
            saleInfos.Add(new SaleInfo { Rank = 1, Country = "USA", Revenue = 2920, Percent = 53.23f });
            saleInfos.Add(new SaleInfo { Rank = 2, Country = "China", Revenue = 1300, Percent = 20.43f });
            saleInfos.Add(new SaleInfo { Rank = 3, Country = "Australia", Revenue = 760, Percent = 10.35f });
            saleInfos.Add(new SaleInfo { Rank = 4, Country = "United Kingdom", Revenue = 690, Percent = 7.87f });
            saleInfos.Add(new SaleInfo { Rank = 5, Country = "Romania", Revenue = 600, Percent = 5.94f });
            saleInfos.Add(new SaleInfo { Rank = 6, Country = "Brazil", Revenue = 550, Percent = 4.43f });

            geoInfo = new GeoInfo();

            var r = new Random();

            geoInfo.Values = new Dictionary<string, double>();

            geoInfo.Values["US"] = 2920;
            geoInfo.Values["CN"] = 1300;
            geoInfo.Values["AU"] = 760;
            geoInfo.Values["UK"] = 690;
            geoInfo.Values["RO"] = 600;
            geoInfo.Values["BR"] = 550;

            geoInfo.LanguagePack = new Dictionary<string, string>();
        }
        public GeoInfo GeoInfo
        {
            get
            {
                return geoInfo;
            }

            set
            {
                geoInfo = value;
            }
        }

        public List<SaleInfo> SaleInfos
        {
            get
            {
                return saleInfos;
            }

            set
            {
                saleInfos = value;
            }
        }

        public List<MeunInfo> MeunInfos
        {
            get
            {
                return meunInfos;
            }

            set
            {
                meunInfos = value;
            }
        }

        public MeunInfo CurrentMenu
        {
            get
            {
                return currentMenu;
            }

            set
            {
                currentMenu = value;
            }
        }
    }
}
