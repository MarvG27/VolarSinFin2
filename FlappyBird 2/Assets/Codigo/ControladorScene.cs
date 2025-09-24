using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControladorScene : MonoBehaviour
{

    public GameObject canvasPerdiste;
    void Start()
    {
        Time.timeScale = 1;
    }


    void Update()
    {

    }

    public void Perdiste()
    {
        canvasPerdiste.SetActive(true);
        Time.timeScale = 0;
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        Debug.Log("Saliste Yupiii");
        Application.Quit();
    }
}
