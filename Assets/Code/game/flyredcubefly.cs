using UnityEngine;
using System.Collections;

public class flyredcubefly : MonoBehaviour {
	public GameObject postac;
	//public postac pScript;
	public bool clicked;
	public bool dead;
	public bool click = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(!dead)
		if(!clicked)
		postac.transform.position = new Vector3(postac.transform.position.x, postac.transform.position.y-0.17f, postac.transform.position.z);
		else
		postac.transform.position = new Vector3(postac.transform.position.x, postac.transform.position.y+0.17f, postac.transform.position.z);
	}

	void OnMouseDown (){
						clicked = true;
	}
	void OnMouseUp(){
		clicked = false;}
}
