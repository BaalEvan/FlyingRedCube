using UnityEngine;
using System.Collections;

public class clicktoshowpoints : MonoBehaviour
{
    public TextMesh tmpunktacja;
    public GameObject gop;
    public bool presspointbutton = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (presspointbutton == false)
	    {
            tmpunktacja.text = PlayerPrefs.GetInt("punktacja").ToString();
        }
	}

    void OnMouseDown()
    {
        if(presspointbutton == true) {
        tmpunktacja.text = PlayerPrefs.GetInt("punktacja").ToString();
        presspointbutton = false;
        }
    }
}
