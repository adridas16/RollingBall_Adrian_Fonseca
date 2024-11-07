using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanManager : MonoBehaviour
{
   
    private void Start()
    {
        
    }
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
    public void botonSelectLevel()
    {
        SceneManager.LoadScene(2);
    }
    //public void SelectLevel(string nombreNivel1)
    //{

    //    SceneManager.LoadScene(nombreNivel1);
    //}
    //public void SelectLeve(int numeroNivel1)
    //{
    //    SceneManager.LoadScene(numeroNivel1);
    //}
    public void RespawnLeve2()
    {
        SceneManager.LoadScene(2);
    }
}
