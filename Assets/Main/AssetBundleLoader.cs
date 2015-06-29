using UnityEngine;
using System.Collections;

public class AssetBundleLoader {

	public IEnumerator LoadLevelBundle(string levelName, string url, int version) 
	{	
//		WWW download;
//		download = WWW.LoadFromCacheOrDownload( url, version );

		WWW download;
		if ( Caching.enabled ) { 
			while (!Caching.ready)
				yield return null;
			download = WWW.LoadFromCacheOrDownload( url, version );
		}
		else {
			download = new WWW (url);
		}

//		WWW download = new WWW(url);
//
		yield return download;
		if ( download.error != null ) {
			Debug.LogError( download.error );
			download.Dispose();
			yield break;
		}

		AssetBundle assetBundle = download.assetBundle;
		download.Dispose();
		download = null;

		if (assetBundle.LoadAllAssets() != null)
			Application.LoadLevel(levelName);
		
		assetBundle.Unload(false);
	}

	public void LoadLevelBundleFromFile(string levelName, string url) 
	{
		AssetBundle assetBundle = AssetBundle.CreateFromFile(url);
		
		if (assetBundle.LoadAllAssets() != null)
			Application.LoadLevel(levelName);
		
		assetBundle.Unload(false);
	}
}