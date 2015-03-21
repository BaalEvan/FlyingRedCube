using UnityEngine;
using System.Collections;

public class textmenu : MonoBehaviour
{
    public TextMesh tmpunktacja;

    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 10;
        tmpunktacja.text = PlayerPrefs.GetInt("punktacja").ToString();
    }

}
