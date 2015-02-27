using UnityEngine;
using System.Collections;

public class figurki: MonoBehaviour {
    public bool stopmove;
    public bool stopmovee;
    public flyredcubefly frcf;
    public pause pauzaa;

	// Use this for initialization
	void Start () {
        frcf = GameObject.Find("flyredcube").GetComponent<flyredcubefly>();
        pauzaa = GameObject.Find("pauza").GetComponent<pause>();
    }
	
	// Update is called once per frame
	void Update () {

        stopmove = !frcf.dead;
       // stopmovee = !pauza.pausebool;

        if (stopmove)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - 0.08f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
        if (!stopmove)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }

        if (transform.position.x < -12f)
            {
                Destroy(this.gameObject);
            }
            
            }

   }