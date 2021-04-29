using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefabPelota;
    public Camera camaraDeEscena;

    public GameObject menuPausa;

    bool isPaused = false;
    public Text scoreText;
    public int inmunidad = 0;

    GameObject jugador;
    void Start()
    {
        if(prefabPelota){
            jugador = Instantiate(prefabPelota, new Vector3(38.19f,2.50f,-9), Quaternion.identity);
            camaraDeEscena.GetComponent<SeguimientoCamara>().posicionBola = jugador.transform;
            camaraDeEscena.GetComponent<SeguimientoCamara>().smoothRango = 0.01f;
            camaraDeEscena.GetComponent<SeguimientoCamara>().diferenciaCamara = camaraDeEscena.transform.position - jugador.transform.position;
            camaraDeEscena.transform.position = new Vector3(38.19f,5.50f,-9);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(inmunidad == 3){
            scoreText.color = Color.green;
        }
        scoreText.text = "Score: " + inmunidad;
        if(prefabPelota && !jugador &&  Input.GetKeyDown(KeyCode.Return)){
            jugador = Instantiate(prefabPelota, new Vector3(38.19f,2.50f,-9), Quaternion.identity);
            camaraDeEscena.GetComponent<SeguimientoCamara>().posicionBola = jugador.transform;
            camaraDeEscena.GetComponent<SeguimientoCamara>().smoothRango = 0.01f;
            camaraDeEscena.GetComponent<SeguimientoCamara>().diferenciaCamara = camaraDeEscena.transform.position - jugador.transform.position;
            camaraDeEscena.transform.position = new Vector3(38.19f,5.50f,-9);
        }
        if(Input.GetKeyDown(KeyCode.Escape)){

            TogglePause();

        }
    }
    public int getInminudad(){
        return this.inmunidad;
    }

    public void ejemploBoton(){
        print("Presionado");
    }

    public void TogglePause(){

        isPaused = !isPaused;

        menuPausa.SetActive(isPaused);

        Time.timeScale = isPaused ? 0.0f : 1.0f;

    }

    public void RestartScene(){

        SceneManager.LoadScene("Escena");

    }

    public void menuPrincipal(){

        SceneManager.LoadScene("MenuPrincipalScene");
        Time.timeScale = 1.0f;

    }
}
