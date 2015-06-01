using UnityEngine;
using System.Collections;
using System.Net;

public class menuGlobalScript : MonoBehaviour
{
    //public GiftController GC;
    public GameObject GiftGraphic;
    public GameObject playBtn;
    public GameObject soundBtn;
    public GameObject statsBtn;
    public GameObject shopBtn;
    // Use this for initialization

    IEnumerator GiftTime()
    {
        yield return new WaitForSeconds(1.5f);

        /*if (GC.giftWasntGiven == true)
        {
            GiftGraphic.SetActive(true);
            playBtn.SetActive(false);
            soundBtn.SetActive(false);
            statsBtn.SetActive(false);
            shopBtn.SetActive(false);
        }*/
    }

    void Start()
    {
        StartCoroutine(GiftTime());

    }
}
