using UnityEngine;
using System.Collections;

public class floorscript : MonoBehaviour
{
    public bool floor = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    private void Update()
    {
        if (floor == false)
        {
            transform.position = new Vector3(transform.position.x - 0.08f, transform.position.y, transform.position.z);

            if (transform.position.x < -19.3f)
            {
                transform.position = new Vector2(19.5f, transform.position.y);
            }
        }
    }
}
