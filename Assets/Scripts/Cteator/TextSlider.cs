using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSlider : MonoBehaviour
{
    public GameObject Object;
    // Start is called before the first frame update

    public Slider YPositionSlider;


    // Update is called once per frame




    void Update()
    {
        Object.transform.position = new Vector3(0, YPositionSlider.value, 0);
    }
}
