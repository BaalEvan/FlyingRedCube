

using UnityEngine;
using System.Collections;

public class SoundController : MenuButtonClass
{ 

    public GameObject soundoff;
    public GameObject sound;
    public bool dzwiekwlacz;
    public ButtonController BC;

    // Use this for initialization
    void Start()
    {
        int cos = PlayerPrefs.GetInt("soundset", 0);
        sound.SetActive(true);

        if (cos == 0)
        {
            //soundoff.SetActive(false);
            Debug.Log("soundoff false");
        }
        else
        {
            //soundoff.SetActive(true);
            AudioListener.pause = true;
            Debug.Log("soundoff true");
        }

        
    }

    void Update()
    {
        if (BC.soundoffbtn == false)
        {

            dzwiekwlacz = false;
            //soundoff.SetActive(true);
            AudioListener.pause = true;
            PlayerPrefs.SetInt("soundset", 1);

        }
        else
        {

            dzwiekwlacz = true;
            AudioListener.pause = false;
            //soundoff.SetActive(false);
            PlayerPrefs.SetInt("soundset", 0);
        }

    }
}



