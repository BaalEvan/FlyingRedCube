using UnityEngine;
using System.Collections;

public class loadingscript : MonoBehaviour {

    // Use this for initialization
    void Start () {
        //DontDestroyOnLoad(transform.parent.gameObject);
        //if (GameObject.Find("playbtn").GetComponent<playbtn    >().loading != null)
        //{ GameObject.Find("playbtn").GetComponent<playbtn>().loading =transform.parent.gameObject; }
        //else
        //{
        //    Destroy(transform.parent.gameObject);
        //}
        //GetComponent<Animator>().speed = 1;
        GetComponent<Animator>().Play(0);
        //Debug.Log("we");
    }


    // Update is called once per frame
    void Update ()
    {
    }
}
