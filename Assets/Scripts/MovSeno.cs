using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovSeno : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float velocidad = 3f;
    Vector3 posicionInicial;
    void Start()
    {
        this.posicionInicial = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
        transform.position = posicionInicial + new Vector3(0,0.2f * Mathf.Sin(Time.time * velocidad), 0);
    }
}
