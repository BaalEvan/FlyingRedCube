using UnityEngine;
using System.Collections;

public class outfit1 : MonoBehaviour {
        public GameObject EM;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("punktacja") < 100)
        {
            EM.SetActive(true);
        }

        if (PlayerPrefs.GetInt("punktacja") >= 100)
        {
            int x = PlayerPrefs.GetInt("punktacja", 0) - 100;
            PlayerPrefs.SetInt("punktacja", x);
            Debug.Log("Stan konta -" + x + "punktów");

            int y = PlayerPrefs.GetInt("outfit1", 0);
            PlayerPrefs.SetInt("outfit1", 1);
            Debug.Log("Outfit zakupiony!");
        }



    }
}
