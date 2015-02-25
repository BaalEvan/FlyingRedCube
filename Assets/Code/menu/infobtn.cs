using UnityEngine;
using System.Collections;

public class infobtn : MonoBehaviour {
    public GameObject info;
    public bool check = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDown()
    {
        if (check == true)
        {
            info.SetActive(true);
            check = false;
        }
        else
        {
            check = true;
            info.SetActive(false);
        }
    }
}
