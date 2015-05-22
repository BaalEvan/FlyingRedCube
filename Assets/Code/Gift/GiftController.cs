using UnityEngine;
using System.Collections;
using System.Net;

public class GiftController : MonoBehaviour
{
    public int timeDayNow;
    public int timeHour;
    public int lastDayWithGift;
    public int giftValue = 0;
    public bool giftWasntGiven = false;
    public bool isFirstDay = false;

    public bool giveGift = false;
    public bool giveGiftMax = false;
    public bool giveGiftFirstDay = false;

    void Start()
    {
        timeDayNow = System.DateTime.Now.Day;
        lastDayWithGift = PlayerPrefs.GetInt("LastDayWithGift", 0);
        giftValue = PlayerPrefs.GetInt("GiftValue", 0);


        if (lastDayWithGift < timeDayNow)
        {
            giftWasntGiven = true;
        }

        if (giftWasntGiven)
        {
            if (lastDayWithGift == 0)
            {
                isFirstDay = true;
            }

                if (isFirstDay == true)
             {
                    PlayerPrefs.SetInt("LastDayWithGift", timeDayNow);
                    lastDayWithGift = timeDayNow;
             }


            // Otrzymywanie pieniazków
            if (lastDayWithGift + 1 == timeDayNow || isFirstDay)
            {
                PlayerPrefs.SetInt("LastDayWithGift", timeDayNow);
                if (giftValue <= 200)
                {
                    giveGift = true;
                }
            }
            else
            {
                giveGiftMax = true;
            }
        }
        else
        {
            giveGiftFirstDay = true;
        }

    }
}