﻿using UnityEngine;
using System.Collections;

public class pausebtn : MonoBehaviour {
    public GameObject pauza;
    public SpawnController contro;
    public figurki zatrzymanieruchu;
    public pausebtn pauzaa;
    public bool duzaglupota = true;
    public bool pauzazatrzymanie = true;
    public GameObject flyredcube;
    public GameObject returntbtnoause;
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
            pauza.SetActive(true);
            flyredcube.SetActive(false);
            //  zatrzymanieruchu.stopmovee = true;
            Debug.Log("Otworzenie pauzy");
            Time.timeScale = 0;
            contro.stop = true;
            pauzazatrzymanie = false;
            duzaglupota = false;
        }
        else
        {
            Debug.Log("Wcisniecie przycisku Pause");
            pauza.SetActive(false);
            //   zatrzymanieruchu.stopmovee = false;
            Debug.Log("Zamkniecie pauzy");
            flyredcube.SetActive(true);
            Time.timeScale = 1;
            contro.stop = false;
            pauzazatrzymanie = true;
            duzaglupota = true;
            
        }

    }
    }

