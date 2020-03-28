using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{


    public Animator anim;
    bool open;
   
    void Start()
    {

        open = false;
        anim = GetComponent<Animator>();


    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {

            open = true;
            anim.Play("slidingOpen");

        }
    }


    void OnTriggerExit(Collider col)
    {

        if (open)
        {

           open = false;
            anim.Play("rotating1");

        }
    }

}
