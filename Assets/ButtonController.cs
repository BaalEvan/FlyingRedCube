using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    //public GameObject SoundController;
    public GameObject soundoff;
    public bool soundoffbtn = true;

    void Start ()
    {
    }
	

	void Update ()
	{
	    
	    if(Input.GetKeyDown(KeyCode.Escape))
            Application.LoadLevel("koniec");
	}

    public void ChangeScene(string name)
    {
        Application.LoadLevel(name);
    }

    public void SoudOfButton()
    {
        soundoffbtn = !soundoffbtn;
        
    }


}

