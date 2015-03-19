using UnityEngine;
using System.Collections;

public class soundbtn : MonoBehaviour
{
    public GameObject soundoff;
    public GameObject sound;
    public bool dzwiekwlacz = false;

    // Use this for initialization
    void Start()
    {
        int cos = PlayerPrefs.GetInt("soundset", 0);
        sound.SetActive(true);

        if (cos == 0)
        {
            soundoff.SetActive(false);
        }
        else
        {
            soundoff.SetActive(true);
            AudioListener.pause = true;
        }
}

// Update is called once per frame
void Update ()
        {
    }

        void OnMouseDown ()
        {
            if (dzwiekwlacz == false)
            {
                dzwiekwlacz = true;
                soundoff.SetActive(true);
                AudioListener.pause = true;
                PlayerPrefs.SetInt("soundset", 1);

        }
            else
            {
                dzwiekwlacz = false;
                AudioListener.pause = false;
                soundoff.SetActive(false);
                PlayerPrefs.SetInt("soundset", 0);
        }
        }
    }
