using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliding : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    bool open;

    void Start()
    {

        open = false;
        anim = GetComponent<Animator>();


    }



    void OnTriggerEnter(Collider col)
    {

        if (open == false)
        {
            anim.Play("slidingOpen");
        }

        if (open == true)
        {
            anim.Play("slidingClose");
        }

    }


}