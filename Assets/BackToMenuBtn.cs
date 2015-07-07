using UnityEngine;
using System.Collections;

public class BackToMenuBtn : MonoBehaviour {

    void OnMouseDown()
    {
        Application.LoadLevel("Menu");
        Debug.Log("menu");
    }
}
