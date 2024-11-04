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
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Respawn()
    {
        SceneManager.LoadScene(1);
    }
}
