using UnityEngine;
using System.Collections;

public class rekordybtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnMouseDown ()
	{
		Application.LoadLevel ("rekordy");
		Time.timeScale = 1;
		Debug.Log ("rekordyBTN");
	}
}
