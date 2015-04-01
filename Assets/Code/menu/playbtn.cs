using UnityEngine;
using System.Collections;

public class playbtn : MenuButtonClass
{
    public GameObject loading;
    public GameObject BTN1;
    public GameObject BTN2;
    public GameObject BTN3;
    public GameObject BTN4;

    public playbtn pb;
    public bool playy = true;
    // Use this for initialization

    void Start()
    {
     //   DontDestroyOnLoad(loading);
    }

    public override void OnMouseDown()
    {
        loading.SetActive(true);
        StartCoroutine("czas");
        if (playy == true) {
            BTN1.SetActive(false);
            BTN2.SetActive(false);
            BTN3.SetActive(false);
            BTN4.SetActive(false);
        }
    }

    IEnumerator czas()
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel("game");
    }
}
