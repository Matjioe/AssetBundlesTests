using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour {

	string url = "Level1";
	private AssetBundleLoader loader;

	void Start () {
		loader = new AssetBundleLoader();
	}

	public void LoadScene1()
	{
		url = "file://" + Application.streamingAssetsPath + "/levels/level1";
		StartCoroutine(loader.LoadLevelBundle("Level1", url, 1));
//		loader.LoadLevelBundleFromFile("Level1", url);
	}

	public void LoadScene2()
	{
		url = "file://" + Application.streamingAssetsPath + "/levels/level2";
		StartCoroutine(loader.LoadLevelBundle("Level2", url, 1));
//		loader.LoadLevelBundleFromFile("Level2", url);
	}
}
