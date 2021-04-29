using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    //public int inmunidad = 0;
    public float JumpForce = 2;
    public float Force = 8;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < 0.05f){
            Saltar();
        }
        if(transform.position.y <= -2){
            transform.position = new Vector3(0,1,0);
        }
    }
    private void FixedUpdate(){
        rb.AddForce(Input.GetAxis("Horizontal") * Force , 0 , Input.GetAxis("Vertical") * Force );  
    }
    void Saltar(){
        rb.AddForce(0 , JumpForce, 0 , ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Obstaculos") && GameObject.Find("Manager").GetComponent<LevelManager>().getInminudad() != 3){
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Moneda")){
            Destroy(other.gameObject);
            GameObject.Find("Manager").GetComponent<LevelManager>().inmunidad += 1;
        }
    }
    
}

