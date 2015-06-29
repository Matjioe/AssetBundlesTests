using UnityEditor;

public class BuildAssetBundles
{
	[MenuItem ("Assets/Build AssetBundles")]
	static void BuildAllAssetBundles ()
	{
//		BuildPipeline.BuildAssetBundles ("Assets/StreamingAssets", BuildAssetBundleOptions.UncompressedAssetBundle, BuildTarget.StandaloneOSXUniversal);
		BuildPipeline.BuildAssetBundles ("Assets/StreamingAssets");
	}
}
