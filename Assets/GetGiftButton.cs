using UnityEngine;
using System.Collections;

public class GetGiftButton : MonoBehaviour
{
    public GameObject playBtn;
    public GameObject soundBtn;
    public GameObject statsBtn;
    public GameObject shopBtn;
    public GameObject gift;
    public GiftController GC;
    void OnMosueDown()
    {

        if (GC.giveGift == true)
        {
            int price = PlayerPrefs.GetInt("punktacja", 0) + GC.giftValue;
            PlayerPrefs.SetInt("punktacja", price);
            GC.giftWasntGiven = false;
        }
        if (GC.giveGiftMax == true)
        {
            int price = PlayerPrefs.GetInt("punktacja", 0) + 200;
            PlayerPrefs.SetInt("punktacja", price);
            GC.giftWasntGiven = false;
        }
        if (GC.giveGiftFirstDay == true)
        {
            if (GC.lastDayWithGift + 2 >= GC.timeDayNow)
            {
                PlayerPrefs.SetInt("GiftValue", 25);
                int price = PlayerPrefs.GetInt("punktacja", 0) + 25;
                PlayerPrefs.SetInt("punktacja", price);
                GC.giftWasntGiven = false;
            }

        }
        PlayerPrefs.SetInt("GiftValue", GC.giftValue);
        playBtn.SetActive(true);
        soundBtn.SetActive(true);
        statsBtn.SetActive(true);
        //shopBtn.SetActive(true);
        Debug.Log("Bonus wypłacony!");
        gift.SetActive(false);
    }
}