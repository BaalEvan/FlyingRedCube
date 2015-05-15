using UnityEngine;
using System.Collections;

public class outfit2 : MonoBehaviour {

    public GameObject EM;
    public GameObject owned1;

    public bool of2 = false;

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
        int zestaw2 = PlayerPrefs.GetInt("outfit2", 0);
        if (zestaw2 == 1)
        {
            owned1.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnMouseDown()
    {
        int zestaw2 = PlayerPrefs.GetInt("outfit2", 0);
        if (zestaw2 == 0)
        {

            // Zakup
            if (PlayerPrefs.GetInt("punktacja") < 100)
            {
                EM.SetActive(true);
            }

            if (PlayerPrefs.GetInt("punktacja") >= 100)
            {
                int x = PlayerPrefs.GetInt("punktacja", 0) - 100;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("Stan konta -" + x + "punktów");

                // Po zakupie ustawienie outfitu
                Debug.Log("Outfit zakupiony!");
                PlayerPrefs.SetInt("outfit2", 1);
                owned1.SetActive(true);
            }
        }
    else
        {
        // Ustawienie zalozenia elemetu
            if (zestaw2 == 1)
            {
                set1.SetActive(false);
                PlayerPrefs.SetInt("setoutfit1", 0);
                set2.SetActive(true);
                PlayerPrefs.SetInt("setoutfit2", 1);
                set3.SetActive(false);
                PlayerPrefs.SetInt("setoutfit3", 0);
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
