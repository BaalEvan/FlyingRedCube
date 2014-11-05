using UnityEngine;
using System.Collections;

public class endGamebtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Escape)){
			Application.Quit();
		}
	}


	void OnMouseDown (){
		Application.Quit();
		Debug.Log("aaaaaa");
	}
}
