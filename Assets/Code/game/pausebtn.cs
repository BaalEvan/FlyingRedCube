using UnityEngine;
using System.Collections;

public class pausebtn : MonoBehaviour {
    public GameObject pause;
    public SpawnController contro;
    public figurki zatrzymanieruchu;
    public pause pauzaa;
    public bool duzaglupota = true;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (duzaglupota == true)
        {
            Debug.Log("Wcisniecie przycisku Pause");
            pause.SetActive(true);
            pauzaa.pausebool = true;
            contro.stop = true;
            zatrzymanieruchu.stopmovee = false;
            Debug.Log("Otworzenie pauzy");
            Time.timeScale = 0;
            duzaglupota = false;
        }
        else
        {
            Debug.Log("Wcisniecie przycisku Pause");
            pause.SetActive(false);
            pauzaa.pausebool = false;
            contro.stop = false;
            zatrzymanieruchu.stopmovee = true;
            Debug.Log("Otworzenie pauzy");
            Time.timeScale = 1;
            duzaglupota = true;
        }

    }
    }

