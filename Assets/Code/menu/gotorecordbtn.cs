using UnityEngine;
using System.Collections;

public class gotorecordbtn : MenuButtonClass
{


    // Use this for initialization


	public override void OnMouseDown ()
	{
        base.OnMouseDown();
      //  GetComponent<AudioSource>().Play();
        Application.LoadLevel ("rekordy");
    //    Time.timeScale = 0;

    }
}
