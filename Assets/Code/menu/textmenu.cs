using UnityEngine;
using System.Collections;

public class textmenu : MonoBehaviour {
    public TextMesh tmpunktacja;
    // Use this for initialization
    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 10;
        tmpunktacja.text = PlayerPrefs.GetInt("punktacja").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
