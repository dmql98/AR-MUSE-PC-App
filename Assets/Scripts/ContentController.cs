using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentController : MonoBehaviour
{

    public API api;

    public void LoadContent(string name)
    {
        DestroyAllChildrenObject();
        api.GetBundleObject(name, OnContentLoaded, transform);
    }

    private void OnContentLoaded(GameObject content)
    {
        // TO-DO: when object is loaded
        Debug.Log($"Loaded {content.name}");
    }


    private void DestroyAllChildrenObject()
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
