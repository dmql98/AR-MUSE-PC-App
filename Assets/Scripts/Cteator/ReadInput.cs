using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReadInput : MonoBehaviour
{
    public TextMeshPro text;
    public TMP_InputField intputField;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(intputField.text);
    }

}
