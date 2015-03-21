using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class MenuButtonClass : MonoBehaviour
{


    // Use this for initialization
    public virtual void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
    
    }
}
