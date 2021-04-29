using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private bool mouseOver = false;
    public ParticleSystem explosion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 
        // if(Input.GetKeyDown(KeyCode.Mouse0) && mouseOver){
            
        // }
    }

    private void OnMouseEnter(){

        //GetComponent<MeshRenderer>().material.color = Color.red;
        mouseOver = !mouseOver;

    }
    private void OnMouseExit(){

        //GetComponent<MeshRenderer>().material.color = Color.white;
        mouseOver = !mouseOver;
    }
    private void OnMouseOver(){

    }
    public void destruirObjetivo(){
        explosion.Play();
        Destroy(gameObject);
    }
}
