using UnityEngine;
using System.Collections;

public class soundstoponstart : MonoBehaviour {
    public GameObject MS;
    public flyredcubefly frcf;
    // Use this for initialization
    void Start () {
        MS = GameObject.FindWithTag("menusound");
    }
	
	// Update is called once per frame
	void Update () {
        if (frcf.glupota == false)
        {
            MS.SetActive(false);
        }

        if (frcf.dead == true)
        {
            MS.SetActive(true);
        }
    }
}
