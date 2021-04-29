using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicasDeCaja : MonoBehaviour
{

    Rigidbody rb;
    public int force = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown(){
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit hitInfo;

        Physics.Raycast(camRay, out hitInfo);

        if(rb){
            rb.AddForceAtPosition(-hitInfo.normal * force * 4, hitInfo.point , ForceMode.Impulse);
        }
    }
    public void InteraccionConPistola(RaycastHit hitInfo){
        rb.AddForceAtPosition(-hitInfo.normal * force, hitInfo.point , ForceMode.Impulse);
    }
}
