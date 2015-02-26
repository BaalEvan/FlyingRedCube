using UnityEngine;
using System.Collections;

public class textcode : MonoBehaviour
{
    public string SortingLayerName = "Gui";
    public int SortingOrder = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        gameObject.GetComponent<MeshRenderer>().sortingLayerName = SortingLayerName;
        gameObject.GetComponent<MeshRenderer>().sortingOrder = SortingOrder;
    }
}
