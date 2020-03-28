using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;


public class Parking : MonoBehaviour
{
    public Animator anim;
    bool open;

    void Start()
    {

        open = false;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
    
        if (Input.GetKeyDown("E"))
        {
            open = true;
            anim.Play("parking");
            anim.speed = 1;
        }
        else
        {
            open = false;
            anim.Play("parking");
            anim.speed = 0;
        }

        if (open)
        {
            open = true;
            anim.Play("parking");
            anim.speed = 1;
        }
        else
        {
            open = false;
            anim.Play("parking");
            anim.speed = 0;
        }
    }

}