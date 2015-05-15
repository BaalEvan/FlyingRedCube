using UnityEngine;
using System.Collections;

public class figure2 : MonoBehaviour
{

    public GameObject EM;
    public GameObject owned2;

    //set
    public GameObject set1;
    public GameObject set2;
    public GameObject set3;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        int zestaw2 = PlayerPrefs.GetInt("figure2", 0);
        if (zestaw2 == 0)
        {

            // Zakup
            if (PlayerPrefs.GetInt("punktacja") < 750)
            {
                EM.SetActive(true);
            }

            if (PlayerPrefs.GetInt("punktacja") >= 750)
            {
                int x = PlayerPrefs.GetInt("punktacja", 0) - 750;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("Stan konta -" + x + "punktów");

                // Po zakupie ustawienie outfitu
                Debug.Log("Outfit zakupiony!");
                PlayerPrefs.SetInt("figure2", 1);
                owned2.SetActive(true);
            }
        }
        else
        {
            // Ustawienie zalozenia elemetu
            if (zestaw2 == 1)
            {
                set1.SetActive(false);
                PlayerPrefs.SetInt("setfigure1", 0);
                set2.SetActive(true);
                PlayerPrefs.SetInt("setfigure2", 1);
                set3.SetActive(false);
                PlayerPrefs.SetInt("setfigure3", 0);
            }
        }
    }
}