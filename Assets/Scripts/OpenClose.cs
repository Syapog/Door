using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && Password.OpenClosse == true)
        {
            animator.Play("Open");
        }
        Debug.Log("ffff");

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && Password.OpenClosse == true)
        {
            animator.Play("Close");
        }
        Debug.Log("aaa");
    }
}
