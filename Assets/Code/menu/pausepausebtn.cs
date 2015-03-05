using UnityEngine;
using System.Collections;

public class pausepausebtn : MonoBehaviour {
    public GameObject pauza;
    public SpawnController contro;
    public figurki zatrzymanieruchu;
    public pausebtn pauzaa;
    public GameObject flyredcube;
    public pausebtn pauzaaaa;
    public pausebool pauzabool;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        Debug.Log("Wcisniecie przycisku Pause");
        flyredcube.SetActive(true);
        pauza.SetActive(false);
        Debug.Log("Zamkniecie pauzy");
        Time.timeScale = 1;
        contro.stop = false;
        pauzabool.pauzazatrzymanie = true;
        pauzaaaa.duzaglupota = true;

    }
}