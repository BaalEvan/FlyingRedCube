using UnityEngine;
using System.Collections;

public class postac : MonoBehaviour {
	public GameObject gameover;
	// Use this for initialization;
	public flyredcubefly frcf;
	public GameObject Timer;
	public int Pkt=0;
//	public bool onGround=false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel("Menu");
		
		}
	}

	void OnCollisionEnter2D(Collision2D Niemozebyc){
		if (Niemozebyc.gameObject.tag == "WallUp") {

		Debug.Log ("kolizja z gora");		
		}

		if (Niemozebyc.gameObject.tag == "WallDown") {
			frcf.dead = true;
			gameover.SetActive(true);

			Debug.Log ("kolizja z dolem");
		}
		if (Niemozebyc.gameObject.tag == "ENEMY") {
			frcf.dead = true;
			gameover.SetActive(true);
		}
	}

			void OnTriggerEnter2D(Collider2D other) {
				if(other.gameObject.tag == "coin") {
				Pkt++;
				Timer.GetComponent<TextMesh>().text=Pkt.ToString();
				Destroy(other.gameObject);
}


	}
}