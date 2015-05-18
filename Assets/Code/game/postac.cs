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
    public GameObject sciemnianie1;
    public GameObject sciemnianie2;
    public GameObject sciemnianie3;
    public GameObject sciemnianie4;
    public GameObject gamesound;
    public GameObject zonk;

    public GameObject lifeAll;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

	public GameObject baza;
    public GameObject panda;
    public GameObject mummy;
    public GameObject rambo;
    public GameObject ninja;
    public GameObject gentleman;
    public Animation skrzydla;

    public int Pkt = 0;
    public int FigureLife;

    private void Start()
    {
        // Life

        if (PlayerPrefs.GetInt("setfigure2") == 1)
        {
            life2.SetActive(true);
            FigureLife = 2;
        }

        if (PlayerPrefs.GetInt("setfigure3") == 1)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            FigureLife = 3;
        }
       

        // Outfit
        if (PlayerPrefs.GetInt("setoutfit1", 0) == 1)
        {
			baza.SetActive(true);
            panda.SetActive(false);
            mummy.SetActive(false);
            rambo.SetActive(false);
            ninja.SetActive(false);
            gentleman.SetActive(false);
        }
        if (PlayerPrefs.GetInt("setoutfit2", 0) == 1)
        {
			baza.SetActive(false);
            panda.SetActive(true);
            mummy.SetActive(false);
            rambo.SetActive(false);
            ninja.SetActive(false);
            gentleman.SetActive(false);
        }
        if (PlayerPrefs.GetInt("setoutfit3", 0) == 1)
        {
			baza.SetActive(false);
            panda.SetActive(false);
            mummy.SetActive(true);
            rambo.SetActive(false);
            ninja.SetActive(false);
            gentleman.SetActive(false);
        }
        if (PlayerPrefs.GetInt("setoutfit4", 0) == 1)
        {
			baza.SetActive(false);
            panda.SetActive(false);
            mummy.SetActive(false);
            rambo.SetActive(true);
            ninja.SetActive(false);
            gentleman.SetActive(false);
        }
        if (PlayerPrefs.GetInt("setoutfit5", 0) == 1)
        {
			baza.SetActive(false);
            panda.SetActive(false);
            mummy.SetActive(false);
            rambo.SetActive(false);
            ninja.SetActive(true);
            gentleman.SetActive(false);
        }
        if (PlayerPrefs.GetInt("setoutfit6", 0) == 1)
        {
			baza.SetActive(false);
            panda.SetActive(false);
            mummy.SetActive(false);
            rambo.SetActive(false);
            ninja.SetActive(false);
            gentleman.SetActive(true);
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (FigureLife == 0)
        {
            life3.SetActive(false);
        }
        if (FigureLife == 1)
        {
            life2.SetActive(false);
        }
        if (FigureLife == 2)
        {
            life1.SetActive(false);
        }
    }

    IEnumerator FigureHit()
    {
        FigureLife = FigureLife - 1;
        yield return new WaitForSeconds(0.1f);
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
            lifeAll.SetActive(false);
            pktgo.SetActive(true);
            gamesound.SetActive(false);
            Destroy(GetComponent<Animator>());
            zonk.SetActive(true);
            Debug.Log("kolizja z dolem");
        }

        if (Niemozebyc.gameObject.tag == "ENEMY")
        {

            if (PlayerPrefs.GetInt("setfigure2") == 1)
            {
                StartCoroutine(FigureHit());
                if (FigureLife == 0)
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

            if (PlayerPrefs.GetInt("setfigure3") == 1)
            {
                StartCoroutine(FigureHit());
                if (FigureLife == 0)
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

            if (PlayerPrefs.GetInt("setfigure1") == 1)
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
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            GetComponent<AudioSource>().Play();
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