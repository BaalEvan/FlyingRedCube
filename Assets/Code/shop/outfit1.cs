using UnityEngine;
using System.Collections;

public class outfit1 : MonoBehaviour {

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;
    public GameObject set4;
    public GameObject set5;
    public GameObject set6;

    public bool of1 = false;

    // Use this for initialization
    private void Start()
    {
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
    }

    // Update is called once per frame
	void Update () {
	
	}
    private void OnMouseDown()
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
}
