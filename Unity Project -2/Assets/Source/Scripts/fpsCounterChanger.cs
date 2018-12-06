using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class fpsCounterChanger : MonoBehaviour
{

    public TMP_Dropdown tMP_Dropdown;
    public GameObject tMP_Text;

    // Use this for initialization
    void Start ()
    {
        tMP_Dropdown.value = 1;
        tMP_Text.SetActive(false);
        {
            tMP_Dropdown.value = 0;
            tMP_Text.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
            {
                Scene currentScene = SceneManager.GetActiveScene();
                string sceneName = currentScene.name;

                if (tMP_Dropdown.value == 1 && sceneName == "Options 3")
                {
                    tMP_Text.SetActive(false);
                }
                else if (tMP_Dropdown.value == 0 && sceneName == "Options 3")
                {
                    tMP_Text.SetActive(true);
                }

                if (tMP_Dropdown.value == 1 && sceneName == "Options 2")
                {
                    tMP_Text.SetActive(false);
                }
                else if (tMP_Dropdown.value == 0 && sceneName == "Options 2")
                {
                    tMP_Text.SetActive(true);
                }

                if (tMP_Dropdown.value == 1 && sceneName == "Options 1")
                {
                    tMP_Text.SetActive(false);
                }
                else if (tMP_Dropdown.value == 0 && sceneName == "Options 1")
                {
                    tMP_Text.SetActive(true);
                }

                if (tMP_Dropdown.value == 1 && sceneName == "Options")
                {
                    tMP_Text.SetActive(false);
                }
                else if (tMP_Dropdown.value == 0 && sceneName == "Options")
                {
                    tMP_Text.SetActive(true);
                }
            }
        }
    }
