using UnityEngine;
using System.Collections;

public class pausepausebtn : MenuButtonClass
{
    public GameObject pauza;
    public SpawnController contro;
    public figurki zatrzymanieruchu;
    public pausebtn pauzaa;
    public GameObject flyredcube;
    public pausebtn pauzaaaa;
    public pausebool pauzabool;

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        Debug.Log("Wcisniecie przycisku Pause");
        flyredcube.SetActive(true);
        pauza.SetActive(false);
        Debug.Log("Zamkniecie pauzy");
        Time.timeScale = 1;
        contro.stop = false;
        pauzabool.pauzazatrzymanie = true;
        pauzaaaa.duzaglupota = true;

    }
}