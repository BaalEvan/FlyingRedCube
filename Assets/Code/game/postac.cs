﻿using UnityEngine;
using System.Collections;

public class postac : MonoBehaviour
{
    public GameObject gameover;
    // Use this for initialization;
    public flyredcubefly frcf;
    public SpawnController contro;
    public GameObject Timer;
    public GameObject pause;
    public bool pausebool = true;
    public figurki zatrzymanieruchu;

    public int Pkt = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pausebool == true)
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause.SetActive(true);
                contro.stop = true;
                zatrzymanieruchu.stopmove = false;
                pausebool = false;
                Debug.Log("Otworzenie pauzy");
                Time.timeScale = 0;
            }   
    }

    void OnCollisionEnter2D(Collision2D Niemozebyc)
    {
        if (Niemozebyc.gameObject.tag == "WallUp")
        {

            Debug.Log("kolizja z gora");
        }

        if (Niemozebyc.gameObject.tag == "WallDown")
        {
            frcf.dead = true;
            contro.stop = true;

            gameover.SetActive(true);
            zatrzymanieruchu.stopmove = false;
			Destroy (GetComponent<Animator>());


            Debug.Log("kolizja z dolem");
        }
        if (Niemozebyc.gameObject.tag == "ENEMY")
        {
            frcf.dead = true;
            contro.stop = true;

            gameover.SetActive(true);
            zatrzymanieruchu.stopmove = false;
			Destroy (GetComponent<Animator>());

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            Pkt++;
            Timer.GetComponent<TextMesh>().text = Pkt.ToString();
            Destroy(other.gameObject);
        }


    }
}