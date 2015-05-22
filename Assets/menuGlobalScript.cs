using UnityEngine;
using System.Collections;
using System.Net;

public class menuGlobalScript : MonoBehaviour {
    public int timeDayNow;
    public GiftController GC;
    public GameObject GiftGraphic;
    public GameObject playBtn;
    public GameObject soundBtn;
    public GameObject statsBtn;
    public GameObject shopBtn;
    // Use this for initialization
    void Start () {

        timeDayNow = System.DateTime.Now.Day;

        if (GC.giftWasntGiven == true)
        {
            GiftGraphic.SetActive(true);
            playBtn.SetActive(false);
            soundBtn.SetActive(false);
            statsBtn.SetActive(false);
            shopBtn.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
