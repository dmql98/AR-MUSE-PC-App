using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SFB;
using UnityEditor;

public class SaveBundle : MonoBehaviour
{
    public OpenFile of;
    public string prefabPath;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnClickSaveBundle()
    {
        string temp = prefabPath;
        // Create runtime prefabs
        GameObject obj = GameObject.Find(of.model.name);
        string tempPath = prefabPath + obj.name + ".prefab";
        PrefabUtility.SaveAsPrefabAsset(obj, tempPath, out bool success);
        if (!success)
            return;
        
        //AssetBundleBuild[] assetBundleBuild = new AssetBundleBuild[1];

        // Open file browser
        string outputPath = StandaloneFileBrowser.SaveFilePanel("Save Asset Bundle", "", "AssetBundle", "ab");
        if (!string.IsNullOrEmpty(outputPath))
        {
            //BuildPipeline.BuildAssetBundles(outputPath, assetBundleBuild, BuildAssetBundleOptions.None, BuildTarget.Android);
        }
    }
}
