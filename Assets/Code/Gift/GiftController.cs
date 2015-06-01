/*using UnityEngine;
using System.Collections;
using System.Net;
using System;

public class GiftController : MonoBehaviour
{
    public int lastDateWithGift;
    public int giftValue = 25;
    public GetGiftButton getGiftBtn;

    public bool giftWasntGiven = false;
    public bool giftWasGiven = false;
    public bool giveValue = false;

    void Start()
    {
              DateTime timeNow = System.DateTime.Now;
              lastDateWithGift = PlayerPrefs.GetInt("LastDateWithGift", 0);
              giftValue = PlayerPrefs.GetInt("GiftValue", 0);

              //Dzień
              if (lastDateWithGift < timeNow.Day)
              {
                  giftWasntGiven = true;
              }

              if (getGiftBtn.giveGift == true)
              {
                  if (giftWasntGiven == true)
                  {
                      if (lastDateWithGift == 0)
                      {
                    lastDateWithGift = timeNow.Day;
                          giftWasntGiven = false;
                      }

                      if (lastDateWithGift + 1 == timeNow.Day)
                      {
                          giveValue = true;
                          giftWasntGiven = false;
                      }

                      if (lastDateWithGift < timeNow.Day && lastDateWithGift != 0)
                      {
                          PlayerPrefs.SetInt("GiftValue", 0);
                          lastDateWithGift = timeNow.Day;
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

<<<<<<< HEAD
          }
      
    }
=======
}*/
