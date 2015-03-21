using UnityEngine;
using System.Collections;

public class loadingscript : MonoBehaviour {
    IEnumerator loading()
    {
        yield return new WaitForSeconds(5f);

    }
    // Use this for initialization
    void Start () {
        StartCoroutine(loading());
        Application.LoadLevel("game");
    }


    // Update is called once per frame
    void Update ()
    {
    }
}
