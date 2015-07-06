using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.UI;

public class SlotMachineController : MonoBehaviour
{
    
    public int price;
    public GameObject outfit2;
    public GameObject outfit3;
    public GameObject outfit4;

    public GameObject tapstarttoslot;
    public GameObject slotmachinetext;

    public TextMesh tmSlotMachine;
    public GameObject EM;
    public GameObject selectButton;
    public GameObject StartButton;
   public GameObject gotowardrobeButton;

     public BidScript bidbools;

    public bool slotsecond = false;
    public bool outfit = false;

    public bool mummyOutfit = false;
    public bool ramboOutfit = false;
    public bool pandaOutfit = false;

    //Zmienne
    public int srmlow;
    public int srmhigh;
    public int rmlow;
    public int rmhigh;
    public int brmlow;
    public int brmhigh;

    public IEnumerator SlotTimeMachine()
    {
        tapstarttoslot.SetActive(false);
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(2);
        if (outfit == false)
        {
            slotmachinetext.gameObject.SetActive(true);
        }
        if (pandaOutfit == true)
        {
            outfit2.SetActive(true);
        }
        if (mummyOutfit == true)
        {
            outfit3.SetActive(true);
        }
        if (ramboOutfit == true)
        {
            outfit4.SetActive(true);
        }
        selectButton.SetActive(true);
        //gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
      var SM = GameObject.Find("Slotmachine");
      var SMA = SM.GetComponent<Animator>();

         if (bidbools.piec == true)
        {
           
            price = 50;
            srmlow = 3;
            srmhigh = 35;
            rmlow = 36;
            rmhigh = 135;
            brmlow = 136;
            brmhigh = 210;
        }

         if (bidbools.stobool == true)
        {
           
            price = 100;
            srmlow = 3;
            srmhigh = 60;
            rmlow = 61;
            rmhigh = 260;
            brmlow = 261;
            brmhigh = 410;
        }

         if (bidbools.dwie == true)
        {
            
            price = 200;
            srmlow = 3;
            srmhigh = 110;
            rmlow = 111;
            rmhigh = 510;
            brmlow = 511;
            brmhigh = 810;
        }

        int x = Random.Range(0, 100);
        int SadRandomMoney = Random.Range(srmlow, srmhigh);
        int RandomMoney = Random.Range(rmlow, rmhigh);
        int BonusRandomMoney = Random.Range(brmlow, brmhigh);

        if (PlayerPrefs.GetInt("punktacja") < price)
        {
            slotmachinetext.SetActive(false);
            EM.SetActive(true);

        }

        // Losowanie
        else {

            Debug.Log(x);

            SMA.enabled = true;
            SMA.Rebind();
            StartCoroutine(SlotTimeMachine());

            int punktacjaSM = PlayerPrefs.GetInt("punktacja", 0) - price;
            PlayerPrefs.SetInt("punktacja", punktacjaSM);

            // Szansa 50% - Pusty traf
            if (x < 50)
            {
                int stankonta = PlayerPrefs.GetInt("punktacja", 0) + SadRandomMoney;
                PlayerPrefs.SetInt("Stan", stankonta);
                tmSlotMachine.text = SadRandomMoney.ToString();
                Debug.Log("Pusty traf");
            }
            // Szansa 40% - Pieniążki
            if (x >= 50 && x < 90)
            {

                int stankonta = PlayerPrefs.GetInt("punktacja", 0) + RandomMoney;
                PlayerPrefs.SetInt("Stan", stankonta);
                tmSlotMachine.text = RandomMoney.ToString();
            }

             if (bidbools.sto == true || bidbools.dwie == true)
            {
                // Szansa 10%
                if (x >= 90)
                {
                    Debug.Log("Trafiony zatopiony!");
                    if (x >= 90 && x <= 92)
                    {
                        int zestaw2 = PlayerPrefs.GetInt("outfit2", 0);
                        if (zestaw2 == 0)
                        {
                            PlayerPrefs.SetInt("outfit2", 1);
                            pandaOutfit = true;
                            gotowardrobeButton.SetActive(true);
                            outfit = true;
                            slotmachinetext.SetActive(false);
                        }
                        else
                        {
                            int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                            PlayerPrefs.SetInt("Stan", stankonta);
                            tmSlotMachine.text = BonusRandomMoney.ToString();
                        }
                    }
                    if (x > 93 && x <= 94)
                    {
                        int zestaw3 = PlayerPrefs.GetInt("outfit3", 0);
                        if (zestaw3 == 0)
                        {
                            PlayerPrefs.SetInt("outfit3", 1);
                            mummyOutfit = true;
                            gotowardrobeButton.SetActive(true);
                            outfit = true;
                            slotmachinetext.SetActive(false);
                        }
                        else
                        {
                            int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                            PlayerPrefs.SetInt("Stan", stankonta);
                            tmSlotMachine.text = BonusRandomMoney.ToString();
                        }
                    }
                    if (x > 95 && x <= 96)
                    {
                        int zestaw4 = PlayerPrefs.GetInt("outfit4", 0);
                        if (zestaw4 == 0)
                        {
                            PlayerPrefs.SetInt("outfit4", 1);
                            ramboOutfit = true;
                            gotowardrobeButton.SetActive(true);
                            outfit = true;
                            slotmachinetext.SetActive(false);
                        }
                        else
                        {
                            int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                            PlayerPrefs.SetInt("Stan", stankonta);
                            tmSlotMachine.text = BonusRandomMoney.ToString();
                        }
                    }

                    if (x > 97 && x <= 100)
                    {
                        int stankonta = PlayerPrefs.GetInt("punktacja", 0) + BonusRandomMoney;
                        PlayerPrefs.SetInt("Stan", stankonta);
                        tmSlotMachine.text = BonusRandomMoney.ToString();
                    }

                }
            }
        }
    }
}
