using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SYLLADEX_SHOW : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            iTween.MoveTo(gameObject, iTween.Hash("y", 200.07, "time", 1, "delay", 1));
        }
    }
}
