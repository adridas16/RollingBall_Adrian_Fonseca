using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFX;
    
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    public void ReproducirSonido(AudioClip ColeccionableS)
    {
       SFX.PlayOneShot(ColeccionableS);
    }
}
