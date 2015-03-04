using UnityEngine;
using System.Collections;

public class endGamebtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Escape)){
            Application.LoadLevel("Menu");
            Debug.Log("Powrot od menu");
        }
	}


	void OnMouseDown (){
		Application.Quit();
		Debug.Log("ZamkniecieProgramu");
	}
}
