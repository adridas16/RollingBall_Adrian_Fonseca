using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorNiveles : MonoBehaviour
{
    [SerializeField] public static ControladorNiveles instancia;
    [SerializeField]Button[] botonesNiveles;
    [SerializeField] int desbloquearNiveles;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (botonesNiveles.Length > 0)
        {
            for (int i = 0; i < botonesNiveles.Length; i++)
            {
                botonesNiveles[i].interactable = false;
            }
            for (int i = 0; i < PlayerPrefs.GetInt("nivelesDesbloqueados", 1); i++)
            {
                botonesNiveles[i].interactable=true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AumentarNiveles()
    {
        if(desbloquearNiveles> PlayerPrefs.GetInt("nivelesDesbloqueados", 1))
        {
            PlayerPrefs.SetInt("nivelesDesbloqueados", desbloquearNiveles);
        }
    }
}
