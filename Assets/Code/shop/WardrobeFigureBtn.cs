using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class WardrobeFigureBtn : MonoBehaviour
{
    public GameObject maps;
    public GameObject outfits;
    public GameObject figure;
    // Use this for initialization
    void OnMouseDown()
    {
        Debug.Log("FigureBtn");
        maps.SetActive(false);
        outfits.SetActive(false);
        figure.SetActive(true);
    }
}
