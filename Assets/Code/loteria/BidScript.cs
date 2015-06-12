/*using UnityEngine;
using System.Collections;

public class BidScript : MonoBehaviour
{
    public bool piec = false;
    public bool stobool = true;
    public bool dwie = false;

    public SlotMachineUpBid SLMachineUp;
    public SlotMachineDownBid SLMachineDown;

    public GameObject piecdziesiat;
    public GameObject sto;
    public GameObject dwiescie;

	// Use this for initialization
	void Start ()
	{
	    stobool = true;
	}
	
	// Update is called once per frame
    private void Update()
    {
        // 50
        if (piec == true)
        {

            if (SLMachineUp.UpBtn == true)
            {
                piec = false;
                piecdziesiat.SetActive(false);
                sto.SetActive(true);
                stobool = true;
                SLMachineUp.UpBtn = false;
            }

        }

        // 100
        if (stobool == true)
        {
            if (SLMachineUp.UpBtn == true)
            {
                stobool = false;
                sto.SetActive(false);
                dwiescie.SetActive(true);
                dwie = true;
                SLMachineUp.UpBtn = false;
            }
            else if (SLMachineDown.DownBtn == true)
            {
                stobool = false;
                sto.SetActive(false);
                piecdziesiat.SetActive(true);
                piec = true;
                SLMachineDown.DownBtn = false;
            }

        }

        // 200
        if (dwie == true)
        {
            if (SLMachineDown.DownBtn == true)
            {
                dwie = false;
                dwiescie.SetActive(false);
                sto.SetActive(true);
                stobool = true;
                SLMachineDown.DownBtn = false;
            }

        }

    }
}*/