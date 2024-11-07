using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class plataformaMovimiento : MonoBehaviour
{
    [SerializeField]   float velocidad=3;
    [SerializeField] float timer = 0.5f;
    [SerializeField] Vector3 Direccion=new Vector3 (3,0,0);
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direccion * velocidad * Time.deltaTime);
        timer += 1 * Time.deltaTime;
        if (timer >= 0.5)
        {
            velocidad= -velocidad;
            timer = 0;

            
        }
        
    }
     
   
    
}
