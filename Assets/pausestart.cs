using UnityEngine;
using System.Collections;

public class pausestart : MonoBehaviour
{
    public GameObject kurwa;
    public pause zadzialaj;
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

            kurwa.SetActive(true);
            zadzialaj.pausebool = true;
        }

        else
        {
            kurwa.SetActive(false);
            zadzialaj.pausebool = false;
        }

    }
}