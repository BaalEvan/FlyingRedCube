using UnityEngine;
using System.Collections;

public class wardrobebtn : MenuButtonClass
{

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        Application.LoadLevel("wardrobe");
    }
}
