using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    Rigidbody rb;
    
    [SerializeField] Vector3 direccionR;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        //rb.AddTorque(new Vector3(0, 200, 0).normalized * 200f, ForceMode.Impulse);
        rb.AddTorque(direccionR * 100, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    
    private void FixedUpdate()
    {

       
        
        
        //transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);



    }
}
