using UnityEngine;
using System.Collections;

public class closeembtn : MonoBehaviour {
    public GameObject EM;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown ()
    {
        EM.SetActive(false);
    }
}
