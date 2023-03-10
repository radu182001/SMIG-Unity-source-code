using UnityEngine;
using System.Collections;
using admob;

public class AdManager : MonoBehaviour {

    public static AdManager Instance { set; get; }
    public string banner;
    public string video;

    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);


#if UNITY_EDITOR
#elif UNITY_ANDROID
        Admob.Instance().initAdmob(banner, video);
        Admob.Instance().loadInterstitial();

#endif
    }
    public void ShowBanner()
    {
#if UNITY_EDITOR
#elif UNITY_ANDROID
        Admob.Instance().showBannerRelative(AdSize.Banner,AdPosition.TOP_CENTER,0);
#endif
    }

    public void ShowVideo()
    {
#if UNITY_EDITOR
#elif UNITY_ANDROID
        if(Admob.Instance().isInterstitialReady())
        {
            Admob.Instance().showInterstitial();
        }
#endif
    }

    public void DestroyBanner()
    {
#if UNITY_EDITOR
#elif UNITY_ANDROID
        Admob.Instance().removeBanner(banner);
#endif
    }


}