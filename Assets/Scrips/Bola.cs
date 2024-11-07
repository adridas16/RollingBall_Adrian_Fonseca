using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Properties;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    
    [SerializeField]AudioClip ColeccionableS;
    [SerializeField]AudioManager managerS;
    [SerializeField] float DeteccionSuelo = 0.17f;
    Vector3 direccion;
    Rigidbody rb;
    private float h, v;
    [SerializeField] int vidas = 100;
    private int puntuacion;
    [SerializeField] TMP_Text textoPuntuacion;
    [SerializeField] GameObject virtualCamArriba;
    [SerializeField] GameObject virtualCamdetras;
    [SerializeField] LayerMask queEsSuelo;
    [SerializeField] private float FuerzaSalto=15f ;
    private int SaltoPared=1;
    [SerializeField] GameObject CanvasMuerte;
    [SerializeField] GameObject AudioM;
    [SerializeField] int DesbloquearNivel;
    [SerializeField] GameObject CanvasFinLevel;
    [SerializeField] float timer = 120f;
    [SerializeField] TMP_Text textoTimer;
    int timerI;
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
        Muerte();
        Timer();
        //transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);

    }
    bool DetectarSuelo()
    {
        bool Detector = Physics.Raycast(transform.position, new Vector3(0, -1, 0), DeteccionSuelo, queEsSuelo);
        return Detector;
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v).normalized * 0.1f, ForceMode.Impulse);

        //transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);


        rb.AddForce(new Vector3(h, 0, v).normalized * 0.1f, ForceMode.Force);    
    }
    void salto()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& DetectarSuelo() == true)
        {
            
            rb.AddForce(new Vector3(0, 1, 0).normalized * FuerzaSalto, ForceMode.Impulse);  
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coleccionable"))
        {
            managerS.ReproducirSonido(ColeccionableS);
            puntuacion++;
            textoPuntuacion.SetText("Score: "+ puntuacion);
            Destroy(other.gameObject);
            
        }
        if(other.gameObject.CompareTag("Cambiocam"))
        {
            virtualCamArriba.SetActive(true);
            virtualCamdetras.SetActive(false);
        }
        if (other.gameObject.CompareTag("FinLevel"))
        {
            CanvasFinLevel.SetActive(true);
            AudioM.SetActive(false);
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cambiocam"))
        {
            virtualCamArriba.SetActive(false);
            virtualCamdetras.SetActive(true);
        }
        if (other.gameObject.CompareTag("Muerte"))
        {
            vidas = 0;

        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pinchos")
        {
            vidas = 0;
        }
        if (collision.gameObject.tag == "SaltoPared")
        {
            SaltoPared = 1;
            if (SaltoPared == 1)
            {
                FuerzaSalto = 10f;
                rb.AddForce(new Vector3(0, 1, 0).normalized * FuerzaSalto, ForceMode.Impulse);               
                FuerzaSalto = 4.5f;

            }
           
        }

    }
    
    
    void Muerte()
    {
        if(vidas <= 0)
        {
            AudioM.SetActive(false);
            CanvasMuerte.SetActive(true);
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
    void Timer()
    {
        textoTimer.SetText("Timer: " + timer);
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            vidas = 0;
        }
    }
}
