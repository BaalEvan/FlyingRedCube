using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    //public GameObject SoundController;
    public GameObject soundoff;
    public bool soundoffbtn = true;

    public GameObject pauza;
    public SpawnController contro;
    public bool duzaglupota = true;
    public pausebool pauzabool;
    public GameObject flyredcube;
    public flyredcubefly frcf;

    void Start ()
    {
    }
	

	void Update ()
	{
	    
	    if(Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("koniec");
	}

    public void ChangeScene(string name)
    {
        Application.LoadLevel(name);
    }

    public void OnLevelWasLoaded(int level)
    {
        if(level == 1)
            print("loaded");
    }

    public void SoudOfButton()
    {
        soundoffbtn = !soundoffbtn;
        
    }

    public void Quit()
    {
        Application.Quit();
            Debug.Log("Application Quit");
    }

    public void exit()
    {
        Debug.Log("exit on");
    }

    public void pause()
    {
        if (duzaglupota == true)
        {
            Debug.Log("Wcisniecie przycisku Pause");
            pauza.SetActive(true);
            flyredcube.SetActive(false);
            contro.stop = true;
            pauzabool.pauzazatrzymanie = false;
            duzaglupota = false;
            Time.timeScale = 0;
            Debug.Log("Otworzenie pauzy");
        }
        else
        {
            Debug.Log("Wcisniecie przycisku Pause");
            pauza.SetActive(false);
            flyredcube.SetActive(true);
            contro.stop = false;
            pauzabool.pauzazatrzymanie = true;
            duzaglupota = true;
            Time.timeScale = 1;
            Debug.Log("Zamkniecie pauzy");

        }
    }

}

