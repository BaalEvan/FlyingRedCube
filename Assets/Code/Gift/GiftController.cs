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

		// Use this for initialization
		private void Start ()
		{
				timeHour = System.DateTime.Now.Hour;
				timeDayNow = System.DateTime.Now.Day;
				lastDayWithGift = PlayerPrefs.GetInt ("LastDayWithGift", 0);
				giftValue = PlayerPrefs.GetInt ("GiftValue", 0);
		
				if (lastDayWithGift < timeDayNow) {
						giftWasntGiven = true;		
				}
				if (giftWasntGiven) {
						if (lastDayWithGift == 0) {
								isFirstDay = true;		
						}

						if (isFirstDay == true) {
								PlayerPrefs.SetInt ("LastDayWithGift", timeDayNow);
								lastDayWithGift = timeDayNow;
						}

						if (lastDayWithGift + 1 == timeDayNow || isFirstDay) {
								PlayerPrefs.SetInt ("LastDayWithGift", timeDayNow);
								if (giftValue <= 200) {
										giftValue += 25;
										PlayerPrefs.SetInt ("GiftValue", giftValue);
										int price = PlayerPrefs.GetInt ("punktacja", 0) + giftValue;
										PlayerPrefs.SetInt ("punktacja", price);
										giftWasntGiven = false;
								} else {
										int price = PlayerPrefs.GetInt ("punktacja", 0) + 200;
					
										PlayerPrefs.SetInt ("punktacja", price);
										giftWasntGiven = false;
								}
						} else {
								if (lastDayWithGift + 2 >= timeDayNow) {
										PlayerPrefs.SetInt ("GiftValue", 25);
										int price = PlayerPrefs.GetInt ("punktacja", 0) + 25;
										PlayerPrefs.SetInt ("punktacja", price);
										giftWasntGiven = false;
								}
						}
				}
		}
}