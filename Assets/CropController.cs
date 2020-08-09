using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropController : MonoBehaviour
{
    public string cropName = "";
    public int timeToGrow;
    public bool selectedCrop = false;
    // Start is called before the first frame update
    void Start()
    {
        cropName = gameObject.transform.name;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cropName);
    }
}
