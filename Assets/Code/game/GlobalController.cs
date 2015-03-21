using UnityEngine;
using System.Collections;

public class GlobalController : MonoBehaviour {

    public GlobalController GC;
    public sounddontdestroy SDD;
    // Use this for initialization


    void Awake () {
        GC = GameObject.Find("GlobalController").GetComponent<GlobalController>();

        DontDestroyOnLoad(this);

        if (GC != null && GC != this)
        {
            DestroyImmediate(gameObject);
            return;

        }

        GC = this;
        SDD = GameObject.Find("menusound").GetComponent<sounddontdestroy>();
        DontDestroyOnLoad(SDD.gameObject);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
