
using UnityEngine;
using System.Collections;

public class SlotMachine : MonoBehaviour
{

    public Animator slot;
    public GameObject Text;
    IEnumerator StopAnimation()
    {
        yield return new WaitForSeconds(5);
        slot.StopPlayback();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AnimateText()
    {
     //   Text.SetActive(true);
    }
}

