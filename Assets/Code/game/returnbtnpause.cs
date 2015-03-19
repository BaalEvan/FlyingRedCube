using UnityEngine;
using System.Collections;

public class returnbtnpause : MonoBehaviour {

    public GameObject pauza;
    public SpawnController contro;
    public figurki zatrzymanieruchu;
    public pausebtn pauzaa;
    public bool duzaglupota = true;
    public bool pauzazatrzymanie = true;
    public GameObject flyredcube;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (pauza == true)
        {
            Debug.Log("Powrot do gry");
            pauza.SetActive(false);
        }
       
    }
}
