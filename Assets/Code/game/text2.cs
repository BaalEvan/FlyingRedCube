using UnityEngine;
using System.Collections;

public class text2 : MonoBehaviour {
    public postac frcf;
    public TextMesh tm;
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().sortingOrder = 10;
	}
	
	// Update is called once per frame
	void Update () {
        tm.text = frcf.Pkt.ToString();
	}
}
