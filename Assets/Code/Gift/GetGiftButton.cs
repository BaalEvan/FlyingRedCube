/*using UnityEngine;
using System.Collections;

public class GetGiftButton : MonoBehaviour
{
    public GameObject playBtn;
    public GameObject soundBtn;
    public GameObject statsBtn;
    public GameObject shopBtn;
    public GameObject gift;
    public GiftController GC;

    public bool giveGift = false;

    void OnMouseDown()
    {

        if (GC.giftValue < 200)
        {
            GC.giftValue += 25;
            int price = PlayerPrefs.GetInt("punktacja", 0) + GC.giftValue;
            PlayerPrefs.SetInt("punktacja", price);
            PlayerPrefs.SetInt("GiftValue", GC.giftValue);

        }
        else
        {
            int price = PlayerPrefs.GetInt("punktacja", 0) + 200;
            PlayerPrefs.SetInt("punktacja", price);
        }

       // PlayerPrefs.SetInt("LastDayWithGift", GC.timeNow.Day);

       // GC.lastDateWithGift = GC.timeNow.Day;
        GC.giftWasntGiven = false;
        GC.giftWasGiven = true;

        playBtn.SetActive(true);
        soundBtn.SetActive(true);
        statsBtn.SetActive(true);
        shopBtn.SetActive(true);
        //shopBtn.SetActive(true);
        Debug.Log("Bonus wypłacony!");
        gift.SetActive(false);
    }
}*/
