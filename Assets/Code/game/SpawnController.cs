using UnityEngine;
using System.Collections.Generic;

public class SpawnController : MonoBehaviour {

	// Use this for initialization
    public List<GameObject> PrefabsList;
    public List<Transform> PositionList;
    public float time = 0f;
    public GameObject FigurkiPrefabGameObject;
    public float SpawnTime;
    public bool stop;
	void Start ()
	{
	    time = 0f; // zapytac Bartka
	}

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {

            if (time > SpawnTime)

            {
                time = 0f;
                var money = Random.Range(0, 3);
                GameObject parent = Instantiate(FigurkiPrefabGameObject, new Vector2(0f, 0f), new Quaternion(0, 0, 0, 0)) as GameObject;
                int[] generator = new int[3];
                generator[0] = Random.Range(0, 3);
                generator[1] = Random.Range(0, 3);
                generator[2] = Random.Range(0, 3);
                generator[money] = 3;
                GameObject a = Instantiate(PrefabsList[generator[0]], PositionList[0].localPosition, new Quaternion(0, 0, 0, 0)) as GameObject;
                GameObject b = Instantiate(PrefabsList[generator[1]], PositionList[1].localPosition, new Quaternion(0, 0, 0, 0)) as GameObject;
                GameObject c = Instantiate(PrefabsList[generator[2]], PositionList[2].localPosition, new Quaternion(0, 0, 0, 0)) as GameObject;

                a.transform.parent = parent.transform;
                b.transform.parent = parent.transform;
                c.transform.parent = parent.transform;
                parent.transform.position = new Vector3(15f, 0, 0);
            }
            time += Time.deltaTime;
        }
    }
}
