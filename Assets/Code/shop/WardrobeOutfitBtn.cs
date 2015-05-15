using UnityEngine;
using System.Collections;
using JetBrains.Annotations;

public class WardrobeOutfitBtn : MonoBehaviour
{
    public GameObject maps;
    public GameObject figure;
    public GameObject outfit;
	// Use this for initialization
    void OnMouseDown()
    {
        Debug.Log("OutfitBtn");
        maps.SetActive(false);
        figure.SetActive(false);
        outfit.SetActive(true);
    }
}
