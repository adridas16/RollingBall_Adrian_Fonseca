using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanManager : MonoBehaviour
{
    [SerializeField] GameObject CanvasParar;
    private void Start()
    {
        
    }
    public void EmpezarPartida()
    {
       
        SceneManager.LoadScene(2);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Salir");
    }
    public void Menu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }
    public void Respawn()
    {
        
        SceneManager.LoadScene(2);
    }
    public void botonSelectLevel()
    {
        
        SceneManager.LoadScene(1);
      
    }
    
  
    public void RespawnLeve2()
    {
        Time.timeScale = 1.0f;
        ControladorNiveles.instancia.AumentarNiveles();
        SceneManager.LoadScene(3);
        
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        CanvasParar.SetActive(false);
    }
}
