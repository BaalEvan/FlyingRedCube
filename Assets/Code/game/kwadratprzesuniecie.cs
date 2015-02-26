using UnityEngine;
using System.Collections;

public class kwadratprzesuniecie : MonoBehaviour {
    public bool rozpoczecie = false;

	// Use this for initialization
	void Start () { 

	}

    // Update is called once per frame
    void Update()
    {
        if (!rozpoczecie)
        {
            transform.position = new Vector3(transform.position.x - 0.07f, transform.position.y, transform.position.z);
			Time.timeScale = 1;
        }

        if (transform.position.x < -12f)
        {
            Destroy(this.gameObject);
        }
    }

}
