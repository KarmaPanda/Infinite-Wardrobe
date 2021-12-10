using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothesChanger : MonoBehaviour
{
    private Material material;

    public void ChangeMaterial(Material material)
    {
        GetComponent<Renderer>().material = material;
    }

    // Start is called before the first frame update
    void Start()
    {
        //material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
