using UnityEngine;
using System.Collections;

public class figurki: MonoBehaviour {
    public bool stopmove;
    public flyredcubefly frcf;

	// Use this for initialization
	void Start () {
        frcf = GameObject.Find("flyredcube").GetComponent<flyredcubefly>();
	}
	
	// Update is called once per frame
	void Update () {
        stopmove = !frcf.dead;
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