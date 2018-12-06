using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class aaChanger : MonoBehaviour
{

    public TMP_Dropdown tMP_Dropdown;

    // Use this for initialization
    void Start()
    {
        if (tMP_Dropdown.value == 0)
        {
            QualitySettings.antiAliasing = 0;
        }
    }


    // Update is called once per frame
    void Update ()
    {
        if (tMP_Dropdown.value == 0)
        {
            QualitySettings.antiAliasing = 0;
        }
        if (tMP_Dropdown.value == 1)
        {
            QualitySettings.antiAliasing = 1;
        }
    }
}
