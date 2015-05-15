using UnityEngine;
using System.Collections;

public class SelectButton : MonoBehaviour {
    public GameObject startBtn;
    public GameObject tapstarttoslot;
    public GameObject slotmachinetext;
    
    public TextMesh tmpunktacja;
    public TextMesh tmmachine;


    void OnMouseDown()
    {
        startBtn.SetActive(true);
        gameObject.SetActive(false);
        tapstarttoslot.SetActive(true);
        slotmachinetext.SetActive(false);
        int stan = PlayerPrefs.GetInt("Stan", 0);
        PlayerPrefs.SetInt("punktacja", stan);
    }
}
