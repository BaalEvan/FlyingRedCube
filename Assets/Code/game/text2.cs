using UnityEngine;
using System.Collections;

public class text2 : MonoBehaviour {
    public postac frcf;
    public TextMesh tmpunktacja;
    public bool punktyposmierci = false;
    // Use this for initialization
    void Start () {
        tmpunktacja.text = frcf.Pkt.ToString();

    }
	
	// Update is called once per frame
	void Update () {
        punktyposmierci = true;
    }
}
