using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class resolutionChanger : MonoBehaviour
{

    public TMP_Dropdown tMP_Dropdown;
    public TMP_Dropdown tMP_Dropdown2;

    // Use this for initialization
    void Start()
    {
        if (tMP_Dropdown.value == 5)
        {
            Screen.SetResolution(1280, 720, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 5 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
                Screen.SetResolution(1280, 720, true);
            }
    }

    // Update is called once per frame
    void Update ()
    {
        if (tMP_Dropdown.value == 12)
        {
            Screen.SetResolution(720, 576, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 12 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(720, 576, true);
        }
        if (tMP_Dropdown.value == 11)
        {
            Screen.SetResolution(800, 600, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 11 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(800, 600, true);
        }
        if (tMP_Dropdown.value == 10)
        {
            Screen.SetResolution(1024, 768, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 10 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1024, 768, true);
        }
        if (tMP_Dropdown.value == 9)
        {
            Screen.SetResolution(1152, 864, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 9 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1152, 864, true);

        }
        if (tMP_Dropdown.value == 8)
        {
            Screen.SetResolution(1280, 720, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 8 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1280, 720, true);
        }
        if (tMP_Dropdown.value == 7)
        {
            Screen.SetResolution(1280, 800, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 7 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1280, 800, true);
        }
        if (tMP_Dropdown.value == 6)
        {
            Screen.SetResolution(1280, 960, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 6 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1280, 960, true);
        }
        if (tMP_Dropdown.value == 5)
        {
            Screen.SetResolution(1280, 1024, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 5 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1280, 1024, true);
        }
        if (tMP_Dropdown.value == 4)
        {
            Screen.SetResolution(1400, 1050, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 4 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1400, 1050, true);
        }
        if (tMP_Dropdown.value == 3)
        {
            Screen.SetResolution(1440, 900, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 3 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1440, 900, true);
        }
        if (tMP_Dropdown.value == 2)
        {
            Screen.SetResolution(1600, 900, false);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 2 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1600, 900, true);
        }
        if (tMP_Dropdown.value == 1)
        {
            Screen.SetResolution(1680, 1050, true);
        }
#pragma warning disable CS0642 // Possible mistaken empty statement
        else if (tMP_Dropdown.value == 1 && (tMP_Dropdown2.value == 0)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            Screen.SetResolution(1680, 1050, false);
        }
    }
}
