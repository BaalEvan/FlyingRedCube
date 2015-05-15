using UnityEngine;
using System.Collections;

public class figure3 : MonoBehaviour
{

    public GameObject EM;
    public GameObject owned3;

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
        int zestaw3 = PlayerPrefs.GetInt("figure3", 0);
        if (zestaw3 == 0)
        {

            // Zakup
            if (PlayerPrefs.GetInt("punktacja") < 1500)
            {
                EM.SetActive(true);
            }

            if (PlayerPrefs.GetInt("punktacja") >= 1500)
            {
                int x = PlayerPrefs.GetInt("punktacja", 0) - 1500;
                PlayerPrefs.SetInt("punktacja", x);
                Debug.Log("Stan konta -" + x + "punktów");

                // Po zakupie ustawienie outfitu
                Debug.Log("Outfit zakupiony!");
                PlayerPrefs.SetInt("figure3", 1);
                owned3.SetActive(true);
            }
        }
        else
        {
            // Ustawienie zalozenia elemetu
            if (zestaw3 == 1)
            {
                set1.SetActive(false);
                PlayerPrefs.SetInt("setfigure1", 0);
                set2.SetActive(false);
                PlayerPrefs.SetInt("setfigure2", 0);
                set3.SetActive(true);
                PlayerPrefs.SetInt("setfigure3", 1);
            }
        }
    }
}