using UnityEngine;
using System.Collections;
using System.Net;

public class GiftController : MonoBehaviour
{
    public int timeDayNow;
    public int timeHour;
    public int lastDayWithGift;
    public int giftValue = 25;
    public GetGiftButton getGiftBtn;

    public bool giftWasntGiven = false;
    public bool giftWasGiven = false;
    public bool giveValue = false;

    void Start()
    {
        timeDayNow = System.DateTime.Now.Day;
        lastDayWithGift = PlayerPrefs.GetInt("LastDayWithGift", 0);
        giftValue = PlayerPrefs.GetInt("GiftValue", 0);


        if (lastDayWithGift < timeDayNow)
        {
            giftWasntGiven = true;
        }

        if (getGiftBtn.giveGift == true)
        {
            if (giftWasntGiven == true)
            {
                if (lastDayWithGift == 0)
                {
                    lastDayWithGift = timeDayNow;
                    giftWasntGiven = false;
                }

                if (lastDayWithGift + 1 == timeDayNow)
                {
                    giveValue = true;
                    giftWasntGiven = false;
                }

                if (lastDayWithGift <= timeDayNow && lastDayWithGift != 0)
                {
                    PlayerPrefs.SetInt("GiftValue", 0);
                    lastDayWithGift = timeDayNow;
                    giftWasntGiven = false;
                }
            }
            else
            {
                giftWasGiven = true;
            }
        }

    }


    void Update()
    {

    }

}