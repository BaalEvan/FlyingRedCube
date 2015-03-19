using UnityEngine;
using System.Collections;

public class playbtn : MonoBehaviour
{


    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update () {

    }

	void OnMouseDown ()
	{
        GetComponent<AudioSource>().Play();
		Application.LoadLevel("game");
	}
}
