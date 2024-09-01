using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cod : MonoBehaviour
{
    public Canvas panel;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            panel.gameObject.SetActive(true);
            Screen.lockCursor = false;
        }

    }
    void OnTriggerExit(Collider col)
    {
        panel.gameObject.SetActive(false);
        Screen.lockCursor = true;
    }
}
