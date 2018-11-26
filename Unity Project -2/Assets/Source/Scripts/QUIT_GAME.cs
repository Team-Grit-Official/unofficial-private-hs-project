using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUIT_GAME : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Initiate.Fade("", Color.black, 2.0f);
            {
                Application.Quit();
                Debug.Log("Application has stopped");
            }
        }
	}
}
