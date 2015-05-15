using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class SlotMachineController : MonoBehaviour
{
    public int price = 100;

    public GameObject outfit2;
    public GameObject outfit3;
    public GameObject outfit4;
    public GameObject map;

    public GameObject tapstarttoslot;
    public GameObject slotmachinetext;

    public TextMesh tmSlotMachine;
    public GameObject EM;
    public GameObject selectButton;
    public GameObject gotowardrobeButton;

        // Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        int x = Random.Range(0, 100);
        int SadRandomMoney = Random.Range(0, 15);
        int RandomMoney = Random.Range(15, 250);
        int BonusRandomMoney = Random.Range(251, 500);
        int zero = 0;

        Debug.Log("SLOT!");

        slotmachinetext.SetActive(true);

        int punktacjaSM = PlayerPrefs.GetInt("punktacja", 0) - price;
        PlayerPrefs.SetInt("punktacja", punktacjaSM);

        if (PlayerPrefs.GetInt("punktacja") < price)
            {
                EM.SetActive(true);
            }

        // Losowanie
        else {
            // Szansa 45% - Pusty traf
            if (x <= 45) 
        {
            int stankonta = PlayerPrefs.GetInt("punktacja", 0) + SadRandomMoney;
            PlayerPrefs.SetInt("Stan", stankonta);
            tmSlotMachine.text = SadRandomMoney.ToString();
            Debug.Log("Pusty traf");
        }
        // Szansa 52% - Pieniążki
            if (x > 45 && x < 94)
        {

            int stankonta = PlayerPrefs.GetInt("punktacja", 0) + RandomMoney;
            PlayerPrefs.SetInt("Stan", stankonta);
            tmSlotMachine.text = RandomMoney.ToString();
        }
        // Szansa 3%
            if(x >= 94)
        {
            Debug.Log("Trafiony zatopiony!");
                if (x >= 94 && x <= 95)
            {
            int zestaw2 = PlayerPrefs.GetInt("outfit2", 0);
                if (zestaw2 == 0)
                {
                    PlayerPrefs.SetInt("outfit2", 1);
                    outfit2.SetActive(true);
                    gotowardrobeButton.SetActive(true);
                }
                else
                {
                    int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                    PlayerPrefs.SetInt("Stan", stankonta);
                    tmSlotMachine.text = BonusRandomMoney.ToString();
                }
            }
                if (x >= 96 && x <= 97)
                {
                    int zestaw3 = PlayerPrefs.GetInt("outfit3", 0);
                    if (zestaw3 == 0)
                    {
                        PlayerPrefs.SetInt("outfit3", 1);
                        outfit3.SetActive(true);
                        gotowardrobeButton.SetActive(true);
                    }
                    else
                    {
                        int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                        PlayerPrefs.SetInt("Stan", stankonta);
                        tmSlotMachine.text = BonusRandomMoney.ToString();
                    }
                }
                if (x >= 98 && x <= 99)
            {
                int zestaw3 = PlayerPrefs.GetInt("outfit4", 0);
                if (zestaw3 == 0)
                {
                        PlayerPrefs.SetInt("outfit4", 1);
                        outfit4.SetActive(true);
                        gotowardrobeButton.SetActive(true);
                }
                else
                {
                    int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                    PlayerPrefs.SetInt("Stan", stankonta);
                    tmSlotMachine.text = BonusRandomMoney.ToString();
                }
            }

                if (x == 100)
                {
                    map.SetActive(true);
                }
                else
                {
                    int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                    PlayerPrefs.SetInt("Stan", stankonta);
                    tmSlotMachine.text = BonusRandomMoney.ToString();
                }

        }
        tapstarttoslot.SetActive(false);
        selectButton.SetActive(true);
        gameObject.SetActive(false);
        }
    }
}
