using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonLauncher : MonoBehaviour
{
    [SerializeField] GameObject prefCannonball;
    [SerializeField] GameObject Bola;
    [SerializeField] GameObject Spawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SeguirJugador();
        DispararBala();
    }
    void SeguirJugador()
    {
        transform.eulerAngles = new Vector3 (0, -Bola.transform.position.z,0);
    }
    void DispararBala()
    {
        GameObject clon = Instantiate(prefCannonball);
        clon.transform.position = Spawn.transform.position;
        clon.transform.eulerAngles=Bola.transform.eulerAngles;
    }

}
