using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaGuiadaBehaviour : MonoBehaviour
{
    public GameObject Bala;

    GameObject instance;

    public Camera Camara;

    public Transform Punto_Disparo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Disparo();

        if (instance == null)
        {
            Camara.enabled = true;
        }

    }

    public void Disparo()
    {
        if (instance == null)
        {
            if (Input.GetMouseButton(0))
            {
                instance = Instantiate(Bala, Punto_Disparo.position, Punto_Disparo.rotation);

                Camara.enabled = false;

            }
        }
    }


}
