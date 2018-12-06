using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fullscreenChanger : MonoBehaviour
{

    public TMP_Dropdown tMP_Dropdown;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if (tMP_Dropdown.value == 0)
        {
            Screen.SetResolution(1280, 720, true);
        }
        if (tMP_Dropdown.value == 1)
        {
            Screen.SetResolution(1280, 720, false);
        }
    }
}
