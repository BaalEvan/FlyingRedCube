using UnityEngine;
using System.Collections;

public class outfit4 : MonoBehaviour
{

    public GameObject EM;
    public GameObject owned3;

    public bool of4 = false;

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
        int zestaw4 = PlayerPrefs.GetInt("outfit4", 0);
        if (zestaw4 == 1)
        {
            owned3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        int zestaw4 = PlayerPrefs.GetInt("outfit4", 0);
        if (zestaw4 == 0)
        {

            // Zakup
            if (PlayerPrefs.GetInt("punktacja") < 800)
            {
                EM.SetActive(true);
            }

            if (PlayerPrefs.GetInt("punktacja") >= 800)
            {
                int x = PlayerPrefs.GetInt("punktacja", 0) - 800;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("Stan konta -" + x + "punktów");

                // Po zakupie ustawienie outfitu
                Debug.Log("Outfit zakupiony!");
                PlayerPrefs.SetInt("outfit4", 1);
                owned3.SetActive(true);
            }
        }
        else
        {
            // Ustawienie zalozenia elemetu
            if (zestaw4 == 1)
            {
                set1.SetActive(false);
                PlayerPrefs.SetInt("setoutfit1", 0);
                set2.SetActive(false);
                PlayerPrefs.SetInt("setoutfit2", 0);
                set3.SetActive(false);
                PlayerPrefs.SetInt("setoutfit3", 0);
                set4.SetActive(true);
                PlayerPrefs.SetInt("setoutfit4", 1);
                set5.SetActive(false);
                PlayerPrefs.SetInt("setoutfit5", 0);
                set6.SetActive(false);
                PlayerPrefs.SetInt("setoutfit6", 0);
            }
        }
    }
}
