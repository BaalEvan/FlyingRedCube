using UnityEngine;
using System.Collections;

public class flyredcubefly : MonoBehaviour
{
    public GameObject postac;
    public kwadratprzesuniecie kwadratstart;

    public flyredcubefly frcf;
    public SpawnController contro;
    public figurki zatrzymanieruchu;
    public GameObject taptoplay;
    public GameObject punk;
    public GameObject gamesound;
    public GameObject pausebtn;
    public GameObject jump;
    //   public GameObject loading;
    public bool glupota = true;
    public bool pausebool = true;



    public int pkt=0;

    //public postac pScript;

    public bool clicked = false;
    public bool dead;
    public bool click = false;
    // Use this for initialization
    void Start()
    {
        kwadratstart.rozpoczecie = true;
        contro.stop = true;
        zatrzymanieruchu.stopmove = false;
    }



    // Update is called once per frame
    void Update()
    {

    //    DestroyObject(loading);
        if (!dead)
            if (clicked)
            {
                postac.GetComponent<Rigidbody2D>().AddForceAtPosition(new Vector2(0, 63f), new Vector2(0, 45f));
            }
        if (!clicked)
        {
            GetComponent<AudioSource>().Play();
        }

        if (dead)
        {
            gameObject.SetActive(false);
            punk.SetActive(false);
            pausebool = false;
        }

    }

    void OnMouseDown()
    {
        if (glupota == true)
        {

            GetComponent<AudioSource>().mute = false;
            Debug.Log("Rozpoczecie gry");
            kwadratstart.rozpoczecie = false;
            contro.stop = false;
            zatrzymanieruchu.stopmove = true;
            taptoplay.SetActive(false);
            punk.SetActive(true);
            glupota = false;
            gamesound.SetActive(true);
        }
        clicked = true;
    }

    void OnMouseUp()
    {
        clicked = false;
    }
}
