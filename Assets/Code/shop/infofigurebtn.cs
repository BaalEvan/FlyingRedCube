using UnityEngine;
using System.Collections;

public class infofigurebtn : MonoBehaviour
{
    public bool clicked = false;
    public GameObject FigureInfoGraphic;

    void Update()
    {
        if (clicked == false)
        {
            FigureInfoGraphic.SetActive(false);
        }
    }

    void OnMouseDown()
    {
            clicked = true;
            FigureInfoGraphic.SetActive(true);
    }

    void OnMouseUp()
    {
        clicked = false;
    }
}
