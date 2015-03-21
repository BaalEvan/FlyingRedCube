using UnityEngine;
using System.Collections;

public class sounddontdestroy : MonoBehaviour
{
    public sounddontdestroy sdd;
    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().Play();

        sdd = GameObject.Find("GlobalController").GetComponent<GlobalController>().SDD;
        if (sdd != null && sdd != this)
        {
            DestroyImmediate(gameObject);
            return;

        }
    }

    // Update is called once per frame
    void Update()
    {
        // DontDestroyOnLoad(this);
    }
}