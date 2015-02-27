using UnityEngine;
using System.Collections;

public class pausestart : MonoBehaviour
{
    public GameObject pauza;
    public pause pauzaa;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauza.SetActive(true);
            pauzaa.pausebool = true;
        }

        else
        {
            pauza.SetActive(false);
            pauzaa.pausebool = false;
        }

    }
}