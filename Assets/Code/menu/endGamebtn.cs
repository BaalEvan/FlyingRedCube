using UnityEngine;
using System.Collections;

public class endGamebtn : MenuButtonClass
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
        Debug.Log("ZamkniecieProgramu");
        Application.Quit();
    }
}
