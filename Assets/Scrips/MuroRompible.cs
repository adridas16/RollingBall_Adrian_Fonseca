using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MuroRompible : MonoBehaviour
{
    Rigidbody rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          
            
                //Time.timeScale = 0.25f;
                
            
          
        }
    }
    private void OnTriggerExtit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {


            //Time.timeScale = 1;
            


        }
    }
}
