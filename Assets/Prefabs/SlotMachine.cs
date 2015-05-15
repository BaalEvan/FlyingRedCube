using UnityEngine;
using System.Collections;

public class SlotMachine : MonoBehaviour
{

    public Animator slot;
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
}
