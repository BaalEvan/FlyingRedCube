using UnityEngine;
using System.Collections;

public class nobtn : MonoBehaviour {
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
        exit.SetActive(false);
        playbtn.SetActive(true);
        stats.SetActive(true);
        soud.SetActive(true);
    }
}
