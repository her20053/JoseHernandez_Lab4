using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPrincipalScript : MonoBehaviour
{
    public Camera camara;
    public Slider sl; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sl.value <= 0.2f){
            camara.backgroundColor = Color.Lerp(Color.white,Color.red,0.1f);
        }
        else if(sl.value <= 0.4f){
            camara.backgroundColor = Color.Lerp(Color.blue,Color.green,0.1f);
        }
        else if(sl.value <= 0.6f){
            camara.backgroundColor = Color.Lerp(Color.blue,Color.red,0.1f);
        }
        else if(sl.value <= 0.8f){
            camara.backgroundColor = Color.Lerp(Color.blue,Color.white,0.1f);
        }
        else if(sl.value <= 1.0f){
            camara.backgroundColor = Color.Lerp(Color.green,Color.white,0.1f);
        }

        
    }

    public void StartGame(){

        SceneManager.LoadScene("SampleScene");

    }
}
