using UnityEngine;
using System.Collections;

public class FiguresMain : MonoBehaviour {

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;

    public GameObject owned2;
    public GameObject owned3;

	// Use this for initialization
	void Start () {
        int zestaw2 = PlayerPrefs.GetInt("figure2", 0);
        if (zestaw2 == 1)
        {
            owned2.SetActive(true);
        }

        int zestaw3 = PlayerPrefs.GetInt("figure3", 0);
        if (zestaw3 == 1)
        {
            owned3.SetActive(true);
        }


        // Figury 1
        int zestawustawiony1 = PlayerPrefs.GetInt("setfigure1", 1);
        if (zestawustawiony1 == 1)
        {
            set1.SetActive(true);
            PlayerPrefs.SetInt("setfigure1", 1);
            set2.SetActive(false);
            PlayerPrefs.SetInt("setfigure2", 0);
            set3.SetActive(false);
            PlayerPrefs.SetInt("setfigure3", 0);
        }

        // Figury 2
        int zestawustawiony2 = PlayerPrefs.GetInt("setfigure2", 0);
        if (zestawustawiony2 == 1)
        {
            set1.SetActive(false);
            PlayerPrefs.SetInt("setfigure1", 0);
            set2.SetActive(true);
            PlayerPrefs.SetInt("setfigure2", 1);
            set3.SetActive(false);
            PlayerPrefs.SetInt("setfigure3", 0);
        }

        // Figury 3
        int zestawustawiony3 = PlayerPrefs.GetInt("setfigure3", 0);
        if (zestawustawiony3 == 1)
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
