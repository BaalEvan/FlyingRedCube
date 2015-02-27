using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
    public SpawnController contro;
    public postac pauza;
    public figurki zatrzymanieruchu;
    public pause pauzaa;
    public bool pausebool = true;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

            if (pausebool == true)
        {
                pausebool = false;
                contro.stop = true; 
                zatrzymanieruchu.stopmovee = false;
                Debug.Log("Otworzenie pauzy");
                Time.timeScale = 0;
            }
        else
        {
            pausebool = true;
            contro.stop = false;
            zatrzymanieruchu.stopmovee = true;
            Time.timeScale = 1;
            Debug.Log("Zamkniecie pauzy");
            }
    }
}
