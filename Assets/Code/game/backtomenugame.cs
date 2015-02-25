using UnityEngine;
using System.Collections;

public class backtomenugame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
        Application.LoadLevel("Menu");
        Time.timeScale = 0;
        Debug.Log ("BackToMenuBTN");
	}
}