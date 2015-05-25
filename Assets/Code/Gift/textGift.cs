using UnityEngine;
using System.Collections;

public class textGift : MonoBehaviour {

	// Use this for initialization
    public TextMesh tmBonus;

    void Update()
    {
        int giftValue = PlayerPrefs.GetInt("GiftValue", 0) + 25;
        tmBonus.text = giftValue.ToString();
    }
}
