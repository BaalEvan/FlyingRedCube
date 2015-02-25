using UnityEngine;
using System.Collections;

public class startplayfrompause : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}


	void OneMouseDown () {

        Application.LoadLevel("game");
        Debug.Log("OneMoreTimeBtn");
    }
}
