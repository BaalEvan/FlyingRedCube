using UnityEngine;
using System.Collections;

public class nobtn : MenuButtonClass
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Menu");
            Debug.Log("Powrot od menu");

        }
    }

    public override void OnMouseDown()
    {
        base.OnMouseDown();
        Application.LoadLevel("Menu");
    }
}
