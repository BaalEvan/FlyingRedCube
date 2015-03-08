using UnityEngine;
using System.Collections;

public class pieniazki : MonoBehaviour
{
    public postac frcf;

    public int Pieniadze = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Pieniadze += frcf.Pkt;
        DontDestroyOnLoad(transform.gameObject);
    }


}
