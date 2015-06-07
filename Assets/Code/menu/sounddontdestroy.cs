using UnityEngine;
using System.Collections;

public class sounddontdestroy : MonoBehaviour
{
    public sounddontdestroy sdd;
    public AudioSource soundMenuPlay;
    // Use this for initialization
    void Start()
    {
        soundMenuPlay.enabled = true;

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
        
    }
}