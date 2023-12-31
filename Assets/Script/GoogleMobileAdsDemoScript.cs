﻿using System; 
using UnityEngine; 
using GoogleMobileAds; 
using GoogleMobileAds.Api; 

public class GoogleMobileAdsDemoHandler : IInAppPurchaseHandler
{
	private readonly string[] validSkus = new string[]
	{
		"android.test.purchased"
	};
	
	public string AndroidPublicKey
	{
		get
		{
			return null;
		}
	}
	
	public void OnInAppPurchaseFinished(IInAppPurchaseResult result)
	{
		result.FinishPurchase();
		GoogleMobileAdsDemoScript.OutputMessage = "Purchase Succeeded! Credit user here.";
	}
	
	public bool IsValidPurchase(string sku)
	{
		string[] array = this.validSkus;
		for (int i = 0; i < array.Length; i++)
		{
			string b = array[i];
			if (sku == b)
			{
				return true;
			}
		}
		return false;
	}
}

public class GoogleMobileAdsDemoScript : MonoBehaviour
{
	private BannerView bannerView;
	
	private InterstitialAd interstitial;
	
	private static string outputMessage = string.Empty;
	
	public static string OutputMessage
	{
		set
		{
			GoogleMobileAdsDemoScript.outputMessage = value;
		}
	}
	
	private void Start()
	{
		UnityEngine.Object.DontDestroyOnLoad(this);
		this.RequestBanner();
		this.bannerView.Show();
	}
	
	private void OnLevelWasLoaded()
	{
		if (Application.loadedLevelName == "main" || Application.loadedLevelName == "menu" || Application.loadedLevelName == "about" || Application.loadedLevelName == "credit" || Application.loadedLevelName == "highscore")
		{
			this.bannerView.Destroy();
		}
		else
		{
			this.RequestBanner();
			this.bannerView.Show();
		}
	}
	
	private void RequestBanner() 
	{ 
		#if UNITY_EDITOR 
		string adUnitId = "unused"; 
		#elif UNITY_ANDROID 
		string adUnitId = "INSERT_ANDROID_BANNER_AD_UNIT_ID_HERE"; 
		#elif UNITY_IPHONE 
		string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE"; 
		#else 
		string adUnitId = "unexpected_platform"; 
		#endif 
		
		
		// Create a 320x50 banner at the top of the screen. 
		bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Top); 
		// Register for ad events. 
		bannerView.AdLoaded += HandleAdLoaded; 
		bannerView.AdFailedToLoad += HandleAdFailedToLoad; 
		bannerView.AdOpened += HandleAdOpened; 
		bannerView.AdClosing += HandleAdClosing; 
		bannerView.AdClosed += HandleAdClosed; 
		bannerView.AdLeftApplication += HandleAdLeftApplication; 
		// Load a banner ad. 
		bannerView.LoadAd(createAdRequest()); 
	} 
	
	
	private void RequestInterstitial() 
	{ 
		#if UNITY_EDITOR 
		string adUnitId = "unused"; 
		#elif UNITY_ANDROID 
		string adUnitId = "INSERT_ANDROID_INTERSTITIAL_AD_UNIT_ID_HERE"; 
		#elif UNITY_IPHONE 
		string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE"; 
		#else 
		string adUnitId = "unexpected_platform"; 
		#endif 
		
		
		// Create an interstitial. 
		interstitial = new InterstitialAd(adUnitId); 
		// Register for ad events. 
		interstitial.AdLoaded += HandleInterstitialLoaded; 
		interstitial.AdFailedToLoad += HandleInterstitialFailedToLoad; 
		interstitial.AdOpened += HandleInterstitialOpened; 
		interstitial.AdClosing += HandleInterstitialClosing; 
		interstitial.AdClosed += HandleInterstitialClosed; 
		interstitial.AdLeftApplication += HandleInterstitialLeftApplication; 
		GoogleMobileAdsDemoHandler handler = new GoogleMobileAdsDemoHandler(); 
		interstitial.SetInAppPurchaseHandler(handler); 
		// Load an interstitial ad. 
		interstitial.LoadAd(createAdRequest()); 
	} 
	
	
	// Returns an ad request with custom ad targeting. 
	private AdRequest createAdRequest() 
	{ 
		return new AdRequest.Builder() 
			.AddTestDevice(AdRequest.TestDeviceSimulator) 
				.AddTestDevice("0123456789ABCDEF0123456789ABCDEF") 
				.AddKeyword("game") 
				.SetGender(Gender.Male) 
				.SetBirthday(new DateTime(1985, 1, 1)) 
				.TagForChildDirectedTreatment(false) 
				.AddExtra("color_bg", "9B30FF") 
				.Build(); 
		
		
	} 
	
	
	private void ShowInterstitial() 
	{ 
		if (interstitial.IsLoaded()) 
		{ 
			interstitial.Show(); 
		} 
		else 
		{ 
			print("Interstitial is not ready yet."); 
		} 
	} 
	
	
	#region Banner callback handlers 
	
	
	public void HandleAdLoaded(object sender, EventArgs args) 
	{ 
		print("HandleAdLoaded event received."); 
	} 
	
	
	public void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args) 
	{ 
		print("HandleFailedToReceiveAd event received with message: " + args.Message); 
	} 
	
	
	public void HandleAdOpened(object sender, EventArgs args) 
	{ 
		print("HandleAdOpened event received"); 
	} 
	
	
	void HandleAdClosing(object sender, EventArgs args) 
	{ 
		print("HandleAdClosing event received"); 
	} 
	
	
	public void HandleAdClosed(object sender, EventArgs args) 
	{ 
		print("HandleAdClosed event received"); 
	} 
	
	
	public void HandleAdLeftApplication(object sender, EventArgs args) 
	{ 
		print("HandleAdLeftApplication event received"); 
	} 
	
	
	#endregion 
	
	
	#region Interstitial callback handlers 
	
	
	public void HandleInterstitialLoaded(object sender, EventArgs args) 
	{ 
		print("HandleInterstitialLoaded event received."); 
	} 
	
	
	public void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args) 
	{ 
		print("HandleInterstitialFailedToLoad event received with message: " + args.Message); 
	} 
	
	
	public void HandleInterstitialOpened(object sender, EventArgs args) 
	{ 
		print("HandleInterstitialOpened event received"); 
	} 
	
	
	void HandleInterstitialClosing(object sender, EventArgs args) 
	{ 
		print("HandleInterstitialClosing event received"); 
	} 
	
	
	public void HandleInterstitialClosed(object sender, EventArgs args) 
	{ 
		print("HandleInterstitialClosed event received"); 
	} 
	
	
	public void HandleInterstitialLeftApplication(object sender, EventArgs args) 
	{ 
		print("HandleInterstitialLeftApplication event received"); 
	} 
	
	
	#endregion 
} 