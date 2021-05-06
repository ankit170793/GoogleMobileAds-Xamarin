using GoogleAdmob;
using GoogleAdmob.Utilities;
using MarcTron.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoogleAdmob_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            bannerAd.AdsId = StringReference.BannerId;
            CrossMTAdmob.Current.OnInterstitialLoaded += (sender, e) => { CrossMTAdmob.Current.ShowInterstitial(); };
            CrossMTAdmob.Current.OnRewardedVideoAdLoaded += (sender, e) => { CrossMTAdmob.Current.ShowRewardedVideo(); };
        }

        private void interstitial_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadInterstitial(StringReference.InterstitialId);
        }

        private void reward_Clicked(object sender, EventArgs e)
        {
            CrossMTAdmob.Current.LoadRewardedVideo(StringReference.VideoId);
        }

        
    }
}
