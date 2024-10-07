using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Vector3 direccion;
    float velocidad=1;
    Rigidbody rb;
    private float h, v;
    [SerializeField] int vidas = 100;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h= Input.GetAxisRaw("Horizontal");
        v= Input.GetAxisRaw("Vertical");
        direccion.x=h;
        direccion.z= v;
        salto();




        //transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);




    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v).normalized * 0.1f, ForceMode.Impulse);

        //transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);


        rb.AddForce(new Vector3(h, 0, v).normalized * 0.1f, ForceMode.Acceleration);    
    }
    void salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(new Vector3(0, 1, 0).normalized * 2f, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("Rodillo"))
        {
            vidas -= 10;
            if (vidas <= 0)
            {
                Destroy(gameObject);

            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
