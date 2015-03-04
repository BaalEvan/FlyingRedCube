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
    public GameObject pausebtn;
    public bool glupota = true;

    public int pkt=0;

    //public postac pScript;

    public bool clicked;
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
		if (!dead)
			if (clicked)
			postac.rigidbody2D.AddForceAtPosition (new Vector2 (0, 63f), new Vector2 (0, 45f));

		if (dead)
		{
			gameObject.SetActive(false);
            punk.SetActive(false);
				}

		}

    void OnMouseDown()
    {
        if (glupota == true)
        {
            Debug.Log("Rozpoczecie gry");
            kwadratstart.rozpoczecie = false;
            contro.stop = false;
            zatrzymanieruchu.stopmove = true;
            taptoplay.SetActive(false);
            punk.SetActive(true);
           
            glupota = false;
        }
        clicked = true;
    }
    void OnMouseUp()
    {
        clicked = false;
    }
}
