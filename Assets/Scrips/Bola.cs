using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Vector3 direccion;
    float velocidad=1;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       float h= Input.GetAxisRaw("Horizontal");
       float v= Input.GetAxisRaw("Vertical");
        direccion.x=h;
        direccion.z = v;
        
        
        
            rb.AddForce(direccion * 0.1f, ForceMode.Impulse);
        
        //transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
        
        
            rb.AddForce(direccion * 0.1f, ForceMode.Acceleration);
        
    }
}
