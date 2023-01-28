using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatorSliders : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update
    public Slider XPositionSlider;

    public Slider YPositionSlider;

    public Slider ZPositionSlider;

    public Slider XRotateSlider;

    public Slider YRotateSlider;

    public Slider ZRotateSlider;

    public Slider ScaleSlider;

    // Update is called once per frame




    void Update()
    {
        if (Object == null)
        {
            Object = GameObject.Find("WavefrontObject");
        }

        Object.transform.position = new Vector3(XPositionSlider.value, YPositionSlider.value, ZPositionSlider.value);
        Object.transform.eulerAngles = new Vector3(XRotateSlider.value, YRotateSlider.value, ZRotateSlider.value);
        Object.transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
    }
}
