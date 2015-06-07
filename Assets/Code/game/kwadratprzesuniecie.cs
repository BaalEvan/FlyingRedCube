using UnityEngine;
using System.Collections;

public class kwadratprzesuniecie : MonoBehaviour
{
    public bool rozpoczecie = false;
    public GameObject pausebtn;
    public GameObject lifeAll;
    public flyredcubefly frcf;

    // Use this for initialization
    void Start()
    {

        Time.timeScale = 0;

    }

    IEnumerator pause()
    {
        yield return new WaitForSeconds(1.5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (!rozpoczecie)
        {
            transform.position = new Vector3(transform.position.x - 0.07f, transform.position.y, transform.position.z);
            Time.timeScale = 1;
            StartCoroutine(pause());

        }


        if (transform.position.x < -12f)
        {
            lifeAll.SetActive(true);
            if(!frcf.dead) {
            pausebtn.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
}
