using UnityEngine;
using System.Collections;

public class playbtn : MenuButtonClass
{
    public GameObject loading;
    public GameObject dots;

    IEnumerator czas()
    {
        yield return new WaitForSeconds(300f);
    }
    public override void OnMouseDown()
    {
        dots.SetActive(true);
        loading.SetActive(true);
        base.OnMouseDown();
        StartCoroutine(czas());
        Application.LoadLevel("game");
    }
}
