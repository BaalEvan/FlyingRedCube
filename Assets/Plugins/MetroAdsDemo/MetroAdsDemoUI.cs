using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Prime31;
using Prime31.MetroAds;


public class MetroAdsDemoUI : MonoBehaviourGUI
{
	void Start()
	{
		// add events and log all data for illustration purposes
		MetroAd.adIsEngagedChangedEvent += ( adUnitId, isEngaged ) =>
		{
			Debug.Log( adUnitId + " isEngaged: " + isEngaged );
		};
		
		MetroAd.adErrorOccurredEvent += ( adUnitId, exc, code ) =>
		{
			Debug.Log( adUnitId + " adErrorOccurredEvent: " + exc.Message + ", code: " + code );	
		};
		
		MetroAd.adRefreshedEvent += ( adUnitId ) =>
		{
			Debug.Log( adUnitId + " adRefreshed" );	
		};
		
		MetroAd.adLoadedEvent += ( adUnitId ) =>
		{
			Debug.Log( adUnitId + " adLoadedEvent" );
		};
	}
	
	
	void OnGUI()
	{
		beginColumn();
		
		if( GUILayout.Button( "Display Ad Banner (bottom-center)" ) )
		{
			// replace the test adUnitId and applicationId with your own!
			var adConfig = new MetroAdConfig()
			{
				adUnitId = "10043000",
				applicationId = "d25517cb-12d4-4699-8bdc-52040c712cab",
				horizontalAlignment = MetroAdHorizontalAlignment.Center,
				verticalAlignment = MetroAdVerticalAlignment.Bottom,
				width = 728,
				height = 90
			};
			
			MetroAd.createAdControl( adConfig );			
		}
		
		
		if( GUILayout.Button( "Display Ad Banner (top-right padded)" ) )
		{
			var adConfig = new MetroAdConfig()
			{
				adUnitId = "10043105",
				applicationId = "d25517cb-12d4-4699-8bdc-52040c712cab",
				horizontalAlignment = MetroAdHorizontalAlignment.Right,
				verticalAlignment = MetroAdVerticalAlignment.Top,
				width = 250,
				height = 250,
				margins = new RectOffset( 50, 50, 50, 0 )
			};
			
			MetroAd.createAdControl( adConfig );
		}
		
		
		if( GUILayout.Button( "Destroy Ad Banners" ) )
		{
			MetroAd.removeAd( "10043000" );
			MetroAd.removeAd( "10043105" );
		}
		
		endColumn();
	}

}
