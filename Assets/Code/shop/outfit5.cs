using UnityEngine;
using System.Collections;

public class outfit5 : MonoBehaviour
{

    public GameObject EM;
    public GameObject owned4;

    public bool of5 = false;

    //set
    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;
    public GameObject set5;
    public GameObject set6;


    // Use this for initialization
    void Start()
    {
        int zestaw5 = PlayerPrefs.GetInt("outfit5", 0);
        if (zestaw5 == 1)
        {
            owned4.SetActive(true);
        }
        int zestawustawiony5 = PlayerPrefs.GetInt("setoutfit5", 0);
        if (zestawustawiony5 == 1)
        {
            set1.SetActive(false);
            PlayerPrefs.SetInt("setoutfit1", 0);
            set2.SetActive(false);
            PlayerPrefs.SetInt("setoutfit2", 0);
            set3.SetActive(false);
            PlayerPrefs.SetInt("setoutfit3", 0);
            set4.SetActive(false);
            PlayerPrefs.SetInt("setoutfit4", 0);
            set5.SetActive(true);
            PlayerPrefs.SetInt("setoutfit5", 1);
            set6.SetActive(false);
            PlayerPrefs.SetInt("setoutfit6", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        int zestaw5 = PlayerPrefs.GetInt("outfit5", 0);
        if (zestaw5 == 0)
        {

            // Zakup
            if (PlayerPrefs.GetInt("punktacja") < 1800)
            {
                EM.SetActive(true);
            }

            if (PlayerPrefs.GetInt("punktacja") >= 1800)
            {
                int x = PlayerPrefs.GetInt("punktacja", 0) - 1800;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("Stan konta -" + x + "punktów");

                // Po zakupie ustawienie outfitu
                Debug.Log("Outfit zakupiony!");
                PlayerPrefs.SetInt("outfit5", 1);
                owned4.SetActive(true);
            }
        }
        else
        {
            // Ustawienie zalozenia elemetu
            if (zestaw5 == 1)
            {
                set1.SetActive(false);
                PlayerPrefs.SetInt("setoutfit1", 0);
                set2.SetActive(false);
                PlayerPrefs.SetInt("setoutfit2", 0);
                set3.SetActive(false);
                PlayerPrefs.SetInt("setoutfit3", 0);
                set4.SetActive(false);
                PlayerPrefs.SetInt("setoutfit4", 0);
                set5.SetActive(true);
                PlayerPrefs.SetInt("setoutfit5", 1);
                set6.SetActive(false);
                PlayerPrefs.SetInt("setoutfit6", 0);
            }
        }
    }
}