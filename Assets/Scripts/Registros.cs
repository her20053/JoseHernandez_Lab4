using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registros : MonoBehaviour
{
    public Text scoreText;
    public int score;

    public ParticleSystem gunShot;

    public Camera camara;
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Ray camRay = camara.ScreenToViewportPoint();
        //Ray camRay = camara.ScreenPointToRay();
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            RaycastHit hitinfo;
            gunShot.Play();
            if(Physics.Raycast(camara.transform.position, camara.transform.forward, out hitinfo, 100.0f)){
                Debug.DrawRay(camara.transform.position, camara.transform.forward * 100.0f, Color.yellow); 
                Debug.Log(hitinfo.transform.name);
                TargetScript ts = hitinfo.transform.GetComponent<TargetScript>();
                FisicasDeCaja fc = hitinfo.transform.GetComponent<FisicasDeCaja>();
                if(ts != null){
                    ts.destruirObjetivo();
                    score++;
                }
                if(fc != null){
                    fc.InteraccionConPistola(hitinfo);
                }
            }
            
        }
        scoreText.text = score.ToString();

    }
}
