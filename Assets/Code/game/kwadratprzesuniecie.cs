﻿using UnityEngine;
using System.Collections;

public class kwadratprzesuniecie : MonoBehaviour
{
    public bool rozpoczecie = false;
    public GameObject pausebtn;

    // Use this for initialization
    void Start()
    {

    }

    IEnumerator pause()
    {
        yield return new WaitForSeconds(1.6f);
        pausebtn.SetActive(true);
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
            Destroy(this.gameObject);
        }
    }
}
