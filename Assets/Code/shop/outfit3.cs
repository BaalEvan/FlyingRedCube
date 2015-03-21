using UnityEngine;
using System.Collections;

public class outfit3 : MonoBehaviour
{

    public GameObject EM;
    public GameObject owned2;

    public bool of3 = false;

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
        int zestaw3 = PlayerPrefs.GetInt("outfit3", 0);
        if (zestaw3 == 1)
        {
            owned2.SetActive(true);
        }
        int zestawustawiony3 = PlayerPrefs.GetInt("setoutfit3", 0);
        if (zestawustawiony3 == 1)
        {
            set1.SetActive(false);
            PlayerPrefs.SetInt("setoutfit1", 0);
            set2.SetActive(false);
            PlayerPrefs.SetInt("setoutfit2", 0);
            set3.SetActive(true);
            PlayerPrefs.SetInt("setoutfit3", 1);
            set4.SetActive(false);
            PlayerPrefs.SetInt("setoutfit4", 0);
            set5.SetActive(false);
            PlayerPrefs.SetInt("setoutfit5", 0);
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
        int zestaw3 = PlayerPrefs.GetInt("outfit3", 0);
        if (zestaw3 == 0)
        {

            // Zakup
            if (PlayerPrefs.GetInt("punktacja") < 300)
            {
                EM.SetActive(true);
            }

            if (PlayerPrefs.GetInt("punktacja") >= 300)
            {
                int x = PlayerPrefs.GetInt("punktacja", 0) - 300;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("Stan konta -" + x + "punktów");

                // Po zakupie ustawienie outfitu
                Debug.Log("Outfit zakupiony!");
                PlayerPrefs.SetInt("outfit3", 1);
                owned2.SetActive(true);
            }
        }
        else
        {
            // Ustawienie zalozenia elemetu
            if (zestaw3 == 1)
            {
                set1.SetActive(false);
                PlayerPrefs.SetInt("setoutfit1", 0);
                set2.SetActive(false);
                PlayerPrefs.SetInt("setoutfit2", 0);
                set3.SetActive(true);
                PlayerPrefs.SetInt("setoutfit3", 1);
                set4.SetActive(false);
                PlayerPrefs.SetInt("setoutfit4", 0);
                set5.SetActive(false);
                PlayerPrefs.SetInt("setoutfit5", 0);
                set6.SetActive(false);
                PlayerPrefs.SetInt("setoutfit6", 0);
            }
        }
    }
}
