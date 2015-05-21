using UnityEngine;
using System.Collections;

public class skrzydlascript : MonoBehaviour
{
    public flyredcubefly frcf;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (frcf.dead == true)
	    {
            Destroy(GetComponent<Animator>());
        }
	}
}
