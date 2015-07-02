using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    //public GameObject SoundController;
    public GameObject soundoff;
    public bool soundoffbtn;
    public Slider GraficSlider;
    public GameObject pauza;
    public SpawnController contro;
    public bool duzaglupota = true;
    public pausebool pauzabool;
    public GameObject flyredcube;
    public flyredcubefly frcf;

    public GameObject postacSkrzydla;
    public GameObject postacZeSkrzydlami;

    public GameObject exitImage;
    public GameObject settingsImage;
    public GameObject playBtn;
    public GameObject statsBtn;
    public GameObject loteryBtn;
    public GameObject shopBtn;
    public GameObject soundbtntrue;
    public GameObject soundbtnfalse;

    public GameObject loadingGraphic;


    public void loading()
    {
        loadingGraphic.SetActive(true);
        DontDestroyOnLoad(loadingGraphic);
        Application.LoadLevel("game");
    }

    // SOUND

    public void playSoundPlay()
    {
        soundoffbtn = false;
        soundbtnfalse.SetActive(true);
        soundbtntrue.SetActive(false);

        AudioListener.pause = true;
        PlayerPrefs.SetInt("soundset", 1);
    }

    public void stopSoundPlay()
    {
        soundoffbtn = true;
        soundbtnfalse.SetActive(false);
        soundbtntrue.SetActive(true);

        AudioListener.pause = false;
        PlayerPrefs.SetInt("soundset", 0);
    }

    // Animation EXIT & SETTINGS

    public void stopAnimatorMenuExitBtn()
    {
        postacZeSkrzydlami.GetComponent<Animator>().applyRootMotion = true;
        postacSkrzydla.GetComponent<Animator>().enabled = false;
        exitImage.GetComponent<Button>().enabled = false;
        settingsImage.GetComponent<Button>().enabled = false;
        playBtn.SetActive(false);
        statsBtn.SetActive(false);
        loteryBtn.SetActive(false);
        shopBtn.SetActive(false);
    }

    public void playAnimatorMenuExitBtn()
    {
        postacZeSkrzydlami.GetComponent<Animator>().applyRootMotion = false;
        postacSkrzydla.GetComponent<Animator>().enabled = true;
        exitImage.GetComponent<Button>().enabled = true;
        settingsImage.GetComponent<Button>().enabled = true;
        playBtn.SetActive(true);
        statsBtn.SetActive(true);
        loteryBtn.SetActive(true);
        shopBtn.SetActive(true);
    }

    public void ChangeScene(string name)
    {
        Application.LoadLevel(name);
        Debug.Log("click");
    }

    public void OnLevelWasLoaded(int level)
    {
        if (level == 1)
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

    public void PlayAgain()
    {
        Application.LoadLevel("game");
        Time.timeScale = 1;
        Debug.Log("againBTN");
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

    public void ValueChangeCheck()
    {
        Debug.Log(GraficSlider.value);
    }

    void OnMouseDown()
    {
        Debug.Log("click!!!");
    }

}

