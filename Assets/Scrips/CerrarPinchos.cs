using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarPinchos : MonoBehaviour
{
    [SerializeField] float velocidad = 3;
    [SerializeField] float timer = 1f;
    [SerializeField] Vector3 Direccion = new Vector3(3, 0, 0);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
       
        
        
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Parar")
        {
            transform.Translate(Direccion * -velocidad * Time.deltaTime);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Parar"))
        {
            transform.Translate(Direccion * -velocidad * Time.deltaTime);
        }
    }
}
