using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    [SerializeField] float velocidad = 1;
    [SerializeField] float velocidadR = 3;
    [SerializeField] float timer = 0f;
    [SerializeField] Vector3 arriba;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(arriba * velocidad * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Muerte"))
        {
            Destroy(gameObject);
        }
    }

}
