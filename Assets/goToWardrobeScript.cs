using UnityEngine;
using System.Collections;

public class goToWardrobeScript : MonoBehaviour
{
    void OnMouseDown()
    {
        Application.LoadLevel("wardrobe");
    }
}
