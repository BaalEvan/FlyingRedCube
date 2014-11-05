using UnityEngine;
using System.Collections;

public class figurki: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			transform.position = new Vector3 (transform.position.x-0.08f, transform.position.y, transform.position.z);
			
		if (transform.position.x < -55) {
			transform.position = new Vector2(-19.395f,transform.position.y);
			}
	}
}