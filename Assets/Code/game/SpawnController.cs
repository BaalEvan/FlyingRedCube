using UnityEngine;
using System.Collections.Generic;

public class SpawnController : MonoBehaviour {

	// Use this for initialization
    public List<GameObject> PrefabsList;
    public List<Transform> PositionList;

    public GameObject FigurkiPrefabGameObject;

    public float time = 0f;
    public float SpawnTime;
    public bool stop;

    public int x = 0;
    public int y = 1;
    public int z = 2;
    public int p = 3;


	void Start ()
	{
	    if (PlayerPrefs.GetInt("setfigure1") == 1)
	    {
	        x = 0;
	        y = 1;
	        z = 2;
	        p = 3;
	    }

        if (PlayerPrefs.GetInt("setfigure2") == 1)
        {
            x = 4;
            y = 5;
            z = 6;
            p = 7;
        }

	    if (PlayerPrefs.GetInt("setfigure3") == 1)
	    {
            x = 8;
	        y = 9;
            z = 10;
            p = 11;
	    }

	}

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {

            if (time > SpawnTime)

            {
                time = 0f;
                var money = Random.Range(x, p);
                GameObject parent = Instantiate(FigurkiPrefabGameObject, new Vector2(0f, 0f), new Quaternion(0, 0, 0, 0)) as GameObject;
                int[] generator = new int[12];
                generator[x] = Random.Range(x, p);
                generator[y] = Random.Range(x, p);
                generator[z] = Random.Range(x, p);
                generator[money] = p;
                GameObject a = Instantiate(PrefabsList[generator[x]], PositionList[0].localPosition, new Quaternion(0, 0, 0, 0)) as GameObject;
                GameObject b = Instantiate(PrefabsList[generator[y]], PositionList[1].localPosition, new Quaternion(0, 0, 0, 0)) as GameObject;
                GameObject c = Instantiate(PrefabsList[generator[z]], PositionList[2].localPosition, new Quaternion(0, 0, 0, 0)) as GameObject;

                a.transform.parent = parent.transform;
                b.transform.parent = parent.transform;
                c.transform.parent = parent.transform;
                parent.transform.position = new Vector3(15f, 0, 0);
            }
            time += Time.deltaTime;
        }
    }
}
