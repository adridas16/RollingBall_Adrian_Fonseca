using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MuroRompible : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rbs;
    private float timer = 1f;
    private bool iniciarTimer = false;
    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponentsInChildren<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (iniciarTimer==true)
        {
            
            timer += 1 * Time.unscaledDeltaTime;
            if (timer >= 2f)
            {
                
                Time.timeScale = 1f;
                for (int i = 0; i < 35; i++) 
                {
                    rbs[i].useGravity = true;
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            iniciarTimer = true;
            Time.timeScale = 0.25f;
           

        }
    }
}
    
