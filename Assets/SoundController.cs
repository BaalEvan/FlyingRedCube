using UnityEngine;
using System.Collections;

public class SoundController : MenuButtonClass
{

    public GameObject soundoff;
    public GameObject sound;
    public bool dzwiekwlacz;
    public ButtonController BC;
    public GameObject soundBtnPlay;
    public GameObject soundBtnStop;


    // Use this for initialization
    void Start()
    {
        int cos = PlayerPrefs.GetInt("soundset", 0);

        if (cos == 0)
        {
            soundBtnPlay.SetActive(true);
            BC.soundoffbtn = true;
            Debug.Log("soundoff false");
        }
        else
        {
            BC.soundoffbtn = false;
            soundBtnStop.SetActive(true);
            Debug.Log("soundoff true");
        }
    }
}