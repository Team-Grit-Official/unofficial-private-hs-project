using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gQualityChanger : MonoBehaviour
{

    public TMP_Dropdown tMP_Dropdown;

    // Use this for initialization
    void Start()
    {
        if (tMP_Dropdown.value == 3)
        {
            QualitySettings.SetQualityLevel(2, true);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (tMP_Dropdown.value == 0)
        {
            QualitySettings.SetQualityLevel(0, true);
        }
        if (tMP_Dropdown.value == 1)
        {
            QualitySettings.SetQualityLevel(1, true);
        }
        if (tMP_Dropdown.value == 2)
        {
            QualitySettings.SetQualityLevel(2, true);
        }
        if (tMP_Dropdown.value == 3)
        {
            QualitySettings.SetQualityLevel(3, true);
        }
        if (tMP_Dropdown.value == 4)
        {
            QualitySettings.SetQualityLevel(4, true);
        }
        if (tMP_Dropdown.value == 5)
        {
            QualitySettings.SetQualityLevel(5, true);
        }
    }
}
