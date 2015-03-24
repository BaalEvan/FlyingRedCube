using UnityEngine;
using System.Collections;

public class gameoverpoints : MonoBehaviour
{
    public TextMesh tmpunktacja;
    public postac frcf;


    void Start()
    {
        GetComponent<Renderer>().sortingOrder = 10;

        tmpunktacja.text = frcf.Pkt.ToString();
        StartCoroutine(odczekanie());

    }

    void Update()
    {

    }

    IEnumerator odczekanie()
    {
        Debug.Log("waiting");
        yield return new WaitForSeconds(5);
        for (int i = 1; i >= frcf.Pkt; i++)
        {
            StartCoroutine("zwiekszaniepunktowczas");
            int y = PlayerPrefs.GetInt("punktacja", 0) + 1;
            PlayerPrefs.SetInt("punktacja", y);
            tmpunktacja.text = PlayerPrefs.GetInt("punktacja").ToString();
        }
        Debug.Log("wait end");

    }

    IEnumerator zwiekszaniepunktowczas()
    {
        yield return new WaitForSeconds(0.2f);
    }

}