using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform posicionBola;

    public Vector3 diferenciaCamara;

    [Range(0.01f,1.0f)]
    public float smoothRango = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        //diferenciaCamara = transform.position - posicionBola.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!posicionBola){
            transform.position = new Vector3(38.19f,7.50f,-9);
        }

        Vector3 nuevaPos = posicionBola.position + diferenciaCamara;
        transform.position = Vector3.Slerp(transform.position , nuevaPos , smoothRango);
    }
}
