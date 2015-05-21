using UnityEngine;
using System.Collections;

public class skrzydlascript : MonoBehaviour
{
    private Animator anim;
    public flyredcubefly frcf;

	// Use this for initialization
	void Start ()
	{
	    anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

       
	    if (frcf.dead == true)
	    {
            Destroy(GetComponent<Animator>());
        }

	    if (frcf.clicked == true)
	    {
	        anim.speed = 3.25f;
	    }

	    else
	    {
	        anim.Rebind();
	    }
	}
}
