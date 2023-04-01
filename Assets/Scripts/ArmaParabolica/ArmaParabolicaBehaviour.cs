using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaParabolicaBehaviour : MonoBehaviour
{

    public GameObject Bala;

    public Transform LugarDisparo;

    float Timer;

    public float Delay;

    GameObject instance;

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
            instance.transform.rotation = LugarDisparo.rotation;
        }

    }

    public void Disparar()
    {
        if (Time.time > Timer)
        {
            if (Input.GetMouseButton(0))
            {

                instance = Instantiate(Bala, LugarDisparo.transform.position, Quaternion.identity);

                Timer = Time.time + Delay;


            }
        }
    }



}
