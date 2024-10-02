using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Vector3 direccion;
    float velocidad=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float h= Input.GetAxisRaw("Horizontal");
       float v= Input.GetAxisRaw("Vertical");
        direccion.x=h;
        direccion.z = v;
        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }
}
