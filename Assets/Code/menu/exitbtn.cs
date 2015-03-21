using UnityEngine;
using System.Collections;

public class exitbtn : MenuButtonClass
{
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        Application.LoadLevel("koniec");
    }
}
