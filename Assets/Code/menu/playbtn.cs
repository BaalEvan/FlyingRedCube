using UnityEngine;
using System.Collections;

public class playbtn : MenuButtonClass
{
    public GameObject loading;
    public GameObject dots;

    public override void OnMouseDown()
    {
        loading.SetActive(true);
        dots.SetActive(true);
        base.OnMouseDown();
        Application.LoadLevel("game");
    }
}
