using UnityEngine;
using System.Collections;

public class SelectButton : MonoBehaviour
{

    public SlotMachineController SmcController;

    public GameObject startBtn;
    public GameObject tapstarttoslot;
    public GameObject slotmachinetext;
    public GameObject gotowardrobeBtn;
    public GameObject SMController;

    public GameObject mummy;
    public GameObject rambo;
    public GameObject panda;
    public GameObject map;
    
    public TextMesh tmpunktacja;
    public TextMesh tmmachine;

    void OnMouseDown()
    {
        if (SmcController.outfit == true)
        {
            mummy.SetActive(false);
            rambo.SetActive(false);
            panda.SetActive(false);
            map.SetActive(false);
            gotowardrobeBtn.SetActive(false);
        }

        startBtn.SetActive(true);
        gameObject.SetActive(false);
        tapstarttoslot.SetActive(true);
        slotmachinetext.SetActive(false);
        int stan = PlayerPrefs.GetInt("Stan", 0);
        PlayerPrefs.SetInt("punktacja", stan);

        SMController.GetComponent<SpriteRenderer>().enabled = true;
        SMController.GetComponent<BoxCollider2D>().enabled = true;
    }
}
