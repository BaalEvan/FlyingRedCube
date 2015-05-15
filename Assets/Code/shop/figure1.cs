using UnityEngine;
using System.Collections;

public class figure1 : MonoBehaviour
{

    public GameObject set1;
    public GameObject set2;
    public GameObject set3;

    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        set1.SetActive(true);
        PlayerPrefs.SetInt("setfigure1", 1);
        set2.SetActive(false);
        PlayerPrefs.SetInt("setfigure2", 0);
        set3.SetActive(false);
        PlayerPrefs.SetInt("setfigure3", 0);
    }
}
