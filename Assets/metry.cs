using UnityEngine;
using System.Collections;
using System;

public class metry : MonoBehaviour
{

    public TextMesh tk;
    public float metryy;
    public bool metrybool = false;
    public kwadratprzesuniecie kp;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (metrybool == true)
        {

            float czas = Time.deltaTime * 0.25f;
            metryy += czas;
            Debug.Log(Convert.ToInt32(metryy));
            tk.text = Convert.ToInt32(metryy).ToString();
        }
    }
}