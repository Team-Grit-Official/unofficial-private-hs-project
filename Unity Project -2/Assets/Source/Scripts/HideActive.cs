using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideActive : MonoBehaviour
{   
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<CanvasRenderer>();
            CanvasRenderer.Destroy(gameObject);
            gameObject.GetComponent<HideActive>().enabled = false;
            
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            GetComponent<CanvasRenderer>();
            CanvasRenderer.Destroy(gameObject);
            gameObject.GetComponent<HideActive>().enabled = false;
        }
    }
}
