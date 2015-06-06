using UnityEngine;
using System.Collections;

public class GlobalController : MonoBehaviour {

    public GlobalController GC;
    public sounddontdestroy SDD;
    // Use this for initialization

    public static FadeController fadeController;


    void Awake () {
        GC = GameObject.Find("GlobalController").GetComponent<GlobalController>();

        DontDestroyOnLoad(this);

        DontDestroyOnLoad(transform.gameObject);
        if (GC == null)
            GC = this;
        else
        {
            Destroy(gameObject);
        }

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
