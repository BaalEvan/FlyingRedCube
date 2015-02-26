using UnityEngine;
using System.Collections;

public class playagainbtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown ()
	{
		Application.LoadLevel ("game");
		Time.timeScale = 1;
		Debug.Log ("againBTN");
	}
}
