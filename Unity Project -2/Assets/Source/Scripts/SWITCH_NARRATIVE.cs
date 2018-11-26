using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SWITCH_NARRATIVE : MonoBehaviour {

    public GameObject narrative0;
    public GameObject narrative1;
    public GameObject text0;
    public GameObject text1;

    // Use this for initialization
    void Start() {
        narrative0.gameObject.SetActive(true);
        text0.gameObject.SetActive(true);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.X))
        {
            narrative0.gameObject.SetActive(false);
            text0.gameObject.SetActive(false);
            text1.gameObject.SetActive(true);
            narrative1.gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            text1.gameObject.SetActive(false);
            narrative1.gameObject.SetActive(false);
        }
    }
}
