using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class WardrobeMapsBtn : MonoBehaviour
{
    public GameObject outfit;
    public GameObject figure;
    public GameObject maps;
    // Use this for initialization
    void OnMouseDown()
    {
        Debug.Log("MapsBtn");
        outfit.SetActive(false);
        figure.SetActive(false);
        maps.SetActive(true);
    }
}
