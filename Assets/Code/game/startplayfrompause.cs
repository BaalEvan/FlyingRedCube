using UnityEngine;
using System.Collections;

public class startplayfrompause : MonoBehaviour {
	public GameObject gameover;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			gameover.SetActive(false);
		}
	}
	void OneMouseDown () {
		gameover.SetActive(false);
	}
}
