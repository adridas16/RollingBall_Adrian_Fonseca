using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanManager : MonoBehaviour
{
    public void EmpezarPartida()
    {
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
}
