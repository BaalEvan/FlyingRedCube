using UnityEngine;
using System.Collections;

public class skrzydlascript : MonoBehaviour
{
    private Animator animator;
    public flyredcubefly frcf;
	// Use this for initialization
	void Start ()
	{

	    animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (frcf.dead == true)
	    {
            Destroy(GetComponent<Animator>());
        }

	    if (frcf.clicked == true)
	    {
	       // Debug.Log("Start animation");
	        animator.speed = 1;
	    }
      
        else
        {
            //Debug.Log("Stop animation");
            animator.speed = 0;
        }
       
	}
}
