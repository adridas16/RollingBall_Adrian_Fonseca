using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboRotando : MonoBehaviour
{
    [SerializeField] float velocidad = 3;
    [SerializeField] float velocidadR = 3;
    [SerializeField] float timer = 0f;
    [SerializeField] Vector3 arriba;
    [SerializeField] Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        transform.Translate(arriba * velocidad * Time.deltaTime,Space.World);
        transform.Rotate(rot* velocidadR * Time.deltaTime,Space.World);
        
       
        if (timer >= 4)
        {
            velocidad = -velocidad;
            timer = 0;


        }
    }
}
