using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    [SerializeField] float TemporizadorDown = 1.5f;
    [SerializeField] bool TM = false;
    [SerializeField] float TemporizadorUp = 1.5f;
    MeshCollider MC;
    MeshRenderer MR;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BajarPinchos();
        SubirPinchos();
        MC = GetComponent<MeshCollider>();
        MR = GetComponent<MeshRenderer>();
    }
    void BajarPinchos()
    {

        if (!TM)
        {
            TemporizadorDown -= Time.deltaTime;
            if (TemporizadorDown <= 0)
            {
                MR.enabled = false;
                MC.enabled = false;
                TM = true;
                TemporizadorDown = 1.5f;

            }
        }
           
        
    }
    void SubirPinchos()
    {
        if (TM)
        {
            TemporizadorUp -= Time.deltaTime;
            if(TemporizadorUp <= 0)
            {
                MR.enabled = true;
                MC.enabled = true;
                TM =false;
                TemporizadorUp = 1.5f;
            }
        }
    }
    
}
