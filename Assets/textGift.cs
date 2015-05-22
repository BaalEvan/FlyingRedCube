using UnityEngine;
using System.Collections;

public class textGift : MonoBehaviour {

	// Use this for initialization
    public TextMesh tmBonus;

    void Update()
    {
        tmBonus.text = PlayerPrefs.GetInt("GiftValue").ToString();
    }
}
