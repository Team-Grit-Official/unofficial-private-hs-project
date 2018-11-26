using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class START_GAME : MonoBehaviour {
    public string scene;

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            Initiate.Fade("Begin", Color.black, 2.0f);
        }
	}
}
