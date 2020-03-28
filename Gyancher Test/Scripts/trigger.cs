using UnityEngine;
using UnityEngine.UI;

public class trigger : MonoBehaviour {



    public Animator anim;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("9"))
        {            
			anim.Play("parking");            
			anim.speed = 1; 
        }	
	
		if (Input.GetKeyDown("0"))
		{            
			anim.Play("parking"); 
			anim.speed = 0; 
        }	
			
    }

}
