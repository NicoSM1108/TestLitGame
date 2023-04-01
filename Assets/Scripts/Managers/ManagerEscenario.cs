using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerEscenario : MonoBehaviour
{
    public GameObject[] Escenarios;

    [HideInInspector]
    public int Armas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Armas == 1)
        {
            Escenarios[0].SetActive(true);
            transform.gameObject.SetActive(false);
        }

        else if (Armas == 2)
        {
            Escenarios[1].SetActive(true);
            transform.gameObject.SetActive(false);
        }

        else if (Armas == 3)
        {
            int i = Random.Range(0, 4);

            if(i==0 || i == 1)
            {
                Escenarios[2].SetActive(true);
                transform.gameObject.SetActive(false);
            }
            else if(i==2 || i == 3)
            {
                Escenarios[3].SetActive(true);
                transform.gameObject.SetActive(false);
            }
        }


    }
}
