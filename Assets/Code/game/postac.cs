using UnityEngine;
using System.Collections;

public class postac : MonoBehaviour
{
    public GameObject gameover;
    // Use this for initialization;
    public flyredcubefly frcf;
    public SpawnController contro;
    public GameObject Timer;
    public GameObject pause;
    public GameObject pausebtn;
    public figurki zatrzymanieruchu;
    public GameObject pktgo;
    public int Pkt = 0;
    public GameObject sciemnianie1;
    public GameObject sciemnianie2;
    public GameObject sciemnianie3;
    public GameObject sciemnianie4;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
            pktgo.SetActive(true);
            Destroy(GetComponent<Animator>());



            Debug.Log("kolizja z dolem");
        }
        if (Niemozebyc.gameObject.tag == "ENEMY")
        { 
            frcf.dead = true;
            contro.stop = true;
            pktgo.SetActive(true);

            gameover.SetActive(true);
            zatrzymanieruchu.stopmove = false;
            Destroy(GetComponent<Animator>());


        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            Pkt++;
            Timer.GetComponent<TextMesh>().text = Pkt.ToString();
            Destroy(other.gameObject);
            if (Pkt >= 25)
            {
                sciemnianie1.SetActive(true);
                if (Pkt >= 50)
                {
                    sciemnianie1.SetActive(false);
                    sciemnianie2.SetActive(true);
                    if (Pkt >= 100)
                    {
                        sciemnianie2.SetActive(false);
                        sciemnianie3.SetActive(true);
                    }
                    if (Pkt >= 200)
                    {
                        sciemnianie3.SetActive(false);
                        sciemnianie4.SetActive(true);
                        if (Pkt >= 400)
                        {
                            sciemnianie1.SetActive(true);
                            sciemnianie4.SetActive(true);
                        }
                    }
                }

            }

        }




    }
}