using UnityEngine;
using System.Collections;

public class pausebtn : MonoBehaviour {
    public GameObject pauza;
    public SpawnController contro;
    public figurki zatrzymanieruchu;
    public pausebtn pauzaa;
    public bool duzaglupota = true;
    public pausebool pauzabool;
    public GameObject flyredcube;
    public GameObject returntbtnoause;
    public flyredcubefly frcf;
    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (duzaglupota == true)
            {
                Debug.Log("Wcisniecie przycisku Pause");
                pauza.SetActive(true);
                flyredcube.SetActive(false);
                Debug.Log("Otworzenie pauzy");
                Time.timeScale = 0;
                contro.stop = true;
                pauzabool.pauzazatrzymanie = false;
                duzaglupota = false;
            }
            else
            {
                Debug.Log("Wcisniecie przycisku Pause");
                pauza.SetActive(false);
                Debug.Log("Zamkniecie pauzy");
                flyredcube.SetActive(true);
                Time.timeScale = 1;
                contro.stop = false;
                pauzabool.pauzazatrzymanie = true;
                duzaglupota = true;
            }
        }

        if (frcf.pausebool == false)
        {
            Destroy(this.gameObject);
        }

    }
    void OnMouseDown()
    {
        if (duzaglupota == true)
        {
            Debug.Log("Wcisniecie przycisku Pause");
            pauza.SetActive(true);
            flyredcube.SetActive(false);
            Debug.Log("Otworzenie pauzy");
            Time.timeScale = 0;
            contro.stop = true;
            pauzabool.pauzazatrzymanie = false;
            duzaglupota = false;
        }
        else
        {
            Debug.Log("Wcisniecie przycisku Pause");
            pauza.SetActive(false);
            Debug.Log("Zamkniecie pauzy");
            flyredcube.SetActive(true);
            Time.timeScale = 1;
            contro.stop = false;
            pauzabool.pauzazatrzymanie = true;
            duzaglupota = true;
            
        }

    }
    }

