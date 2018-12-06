using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToTitle : MonoBehaviour {

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            Initiate.Fade("Title", Color.black, 2.0f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Initiate.Fade("Title", Color.black, 2.0f);
        }
    }
}
