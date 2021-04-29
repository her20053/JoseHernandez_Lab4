using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoCilindro : MonoBehaviour
{
    // Start is called before the first frame update
    private bool mouseOver = false;
    Vector3 posicionInicial;
    void Start()
    {
        this.posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseOver){
            transform.position = posicionInicial + new Vector3(0,0.2f * Mathf.Sin(Time.time * 3.0f), 0);
        }
    }
    private void OnMouseEnter(){

        GetComponent<MeshRenderer>().material.color = Color.red;
        mouseOver = !mouseOver;

    }
    private void OnMouseExit(){

        GetComponent<MeshRenderer>().material.color = Color.white;
        mouseOver = !mouseOver;
    }
}
