using UnityEngine;
using System.Collections;

public class exitbtn : MonoBehaviour {
    public GameObject exit;
    public GameObject playbtn;
    public GameObject stats;
    public GameObject soud;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        exit.SetActive(true);
        playbtn.SetActive(false);
        stats.SetActive(false);
        soud.SetActive(false);
    }
}
