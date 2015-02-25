using UnityEngine;
using System.Collections;

public class soundbtn : MonoBehaviour {
    public GameObject soundoff;
    public bool dzwiekwlacz = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown ()
    {
        if (dzwiekwlacz == false)
        {
            dzwiekwlacz = true;
            soundoff.SetActive(true);

        }
        else
        {
            dzwiekwlacz = false;
            soundoff.SetActive(false);

        }
    }
}
