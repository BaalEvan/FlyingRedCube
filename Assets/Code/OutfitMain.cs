using UnityEngine;
using System.Collections;

public class OutfitMain : MonoBehaviour {

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;
    public GameObject set5;
    public GameObject set6;

    public GameObject owned1;
    public GameObject owned2;
    public GameObject owned3;
    public GameObject owned4;
    public GameObject owned5;
	// Use this for initialization
	void Start ()
	{
	    int wyglad1 = PlayerPrefs.GetInt("outfit2", 0);
        if (wyglad1 == 1) {
            owned1.SetActive(true);
        }

        int wyglad2 = PlayerPrefs.GetInt("outfit3", 0);
        if (wyglad2 == 1)
        {
            owned1.SetActive(true);
        }

        int wyglad3 = PlayerPrefs.GetInt("outfit4", 0);
        if (wyglad3 == 1)
        {
            owned3.SetActive(true);
        }

        int wyglad4 = PlayerPrefs.GetInt("outfit5", 0);
        if (wyglad4 == 1)
        {
            owned4.SetActive(true);
        }

        int wyglad5 = PlayerPrefs.GetInt("outfit6", 0);
        if (wyglad5 == 1)
        {
            owned5.SetActive(true);
        }
       



        int zestawustawiony1 = PlayerPrefs.GetInt("setoutfit1", 1);
	    if (zestawustawiony1 == 1)
        {
            set1.SetActive(true);
            PlayerPrefs.SetInt("setoutfit1", 1);
            set2.SetActive(false);
            PlayerPrefs.SetInt("setoutfit2", 0);
            set3.SetActive(false);
            PlayerPrefs.SetInt("setoutfit3", 0);
            set4.SetActive(false);
            PlayerPrefs.SetInt("setoutfit4", 0);
            set5.SetActive(false);
            PlayerPrefs.SetInt("setoutfit5", 0);
            set6.SetActive(false);
            PlayerPrefs.SetInt("setoutfit6", 0);
        }

        int zestawustawiony2 = PlayerPrefs.GetInt("setoutfit2", 0);
        if (zestawustawiony2 == 1)
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

        int zestawustawiony4 = PlayerPrefs.GetInt("setoutfit4", 0);
        if (zestawustawiony4 == 1)
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

        int zestawustawiony6 = PlayerPrefs.GetInt("setoutfit6", 0);
        if (zestawustawiony6 == 1)
        {
            set1.SetActive(false);
            PlayerPrefs.SetInt("setoutfit1", 0);
            set2.SetActive(false);
            PlayerPrefs.SetInt("setoutfit2", 0);
            set3.SetActive(false);
            PlayerPrefs.SetInt("setoutfit3", 0);
            set4.SetActive(false);
            PlayerPrefs.SetInt("setoutfit4", 0);
            set5.SetActive(false);
            PlayerPrefs.SetInt("setoutfit5", 0);
            set6.SetActive(true);
            PlayerPrefs.SetInt("setoutfit6", 1);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
