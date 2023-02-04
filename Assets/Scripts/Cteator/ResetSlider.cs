using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ResetSlider : MonoBehaviour
{
    public Slider slider;
    public bool scale;

    public void Reset()
    {
        if (scale)
        {
            slider.value = 1;
        }
        else
        {
            slider.value = 0;
        }

    }


}
