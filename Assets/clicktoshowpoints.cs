using UnityEngine;
using System.Collections;

public class clicktoshowpoints : MonoBehaviour
{
    public TextMesh tmpunktacja;
    public text2 tekst;
    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void OnMouseDown()
    {
        if(tekst.punktyposmierci == true)
        tmpunktacja.text = PlayerPrefs.GetInt("punktacja").ToString();
        Debug.Log("punktacja");
        //tekst.punktyposmierci = false;

    }
}