using UnityEngine;
using System.Collections;

public class infobtn : MenuButtonClass
{
    public GameObject info;
    public bool check = true;


    public override void OnMouseDown()
    {
        base.OnMouseDown();
        if (check == true)
        {
            info.SetActive(true);
            check = false;
        }
        else
        {
            check = true;
            info.SetActive(false);
        }
    }
}
