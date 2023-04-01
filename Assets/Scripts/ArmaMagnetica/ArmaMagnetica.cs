using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaMagnetica : MonoBehaviour
{

    public GameObject Bala;

    public Transform Punto_Disparo;

    GameObject instance;

    float Timer;

    public float Delay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Disparar();

        if (instance != null)
        {
            instance.transform.rotation = Punto_Disparo.rotation;
        }

    }

    public void Disparar()
    {
        if (Time.time > Timer)
        {
            if (Input.GetMouseButton(0))
            {
                instance = Instantiate(Bala, Punto_Disparo.position, Quaternion.identity);

                Timer = Time.time + Delay;

            }
        }
    }

}
