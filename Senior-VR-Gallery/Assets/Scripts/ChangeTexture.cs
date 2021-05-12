using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{

    //public Material test;
    private Material orgTexture;

    // Start is called before the first frame update
    void Start()
    {
        orgTexture = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Changes Material while Hovering over Object
    public void HoverStart(Material newTexture)
    {
        GetComponent<Renderer>().material = newTexture;
    }

    public void HoverExit(Material original)
    {
        original = orgTexture;
        GetComponent<Renderer>().material = original;
    }
}
