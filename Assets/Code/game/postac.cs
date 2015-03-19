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
    public GameObject gamesound;
    public GameObject zonk;


    private void Start()
    {

    }


    // Update is called once per frame
    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D Niemozebyc)
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
            gamesound.SetActive(false);
            Destroy(GetComponent<Animator>());
            zonk.SetActive(true);
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
            gamesound.SetActive(false);
            zonk.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            Pkt++;
            Timer.GetComponent<TextMesh>().text = Pkt.ToString();
            Destroy(other.gameObject);

                int x = PlayerPrefs.GetInt("punktacja", 0) + 1;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("uzbierałeś razem: " + x + "punktów");
            

            if (Pkt >= 20)
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
                    if (Pkt >= 150)
                    {
                        sciemnianie3.SetActive(false);
                        sciemnianie4.SetActive(true);
                        if (Pkt >= 250)
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