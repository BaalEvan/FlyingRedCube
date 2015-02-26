using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
    public SpawnController contro;
    public postac pauza;
    public figurki zatrzymanieruchu;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (pauza.pausebool == false)
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameObject.SetActive(false);
                contro.stop = false;
                zatrzymanieruchu.stopmove = true;
                pauza.pausebool = true;
                Time.timeScale = 1;
                Debug.Log("Zamkniecie pauzy");
            }
    }
}
