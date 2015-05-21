using UnityEngine;
using System.Collections;

public class SlotMachineUpBid : MonoBehaviour {

    public bool UpBtn = false;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        UpBtn = true;
    }
}
