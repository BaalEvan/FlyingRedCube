using UnityEngine;
using System.Collections;

public class rekordybtn : MenuButtonClass
{
    public override void OnMouseDown()
    {
        base.OnMouseDown();
        Application.LoadLevel("rekordy");
        Time.timeScale = 1;
        Debug.Log("rekordyBTN");
    }
}
