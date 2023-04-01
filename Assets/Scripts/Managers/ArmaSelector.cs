using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmaSelector : MonoBehaviour
{

    public GameObject ArmaInPlayer;

    public GameObject[] Other_Weapons;

    public int Tipo_Arma;

    public ManagerEscenario ManagerArmas;

    bool Interactable = false;

    public Text _Getxt;

    public GameObject lookUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Interactuar();
    }

    private void Interactuar()
    {
        if (Interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                ArmaInPlayer.SetActive(true);

                ManagerArmas.Armas = Tipo_Arma;

                if (Tipo_Arma == 2)
                {
                    lookUp.SetActive(true);
                }

                for(int i = 0; i < Other_Weapons.Length; i++)
                {
                    Other_Weapons[i].SetActive(false);
                }
                _Getxt.gameObject.SetActive(false);
                Destroy(this.gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Interactable = true;
            _Getxt.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Interactable = false;
            _Getxt.gameObject.SetActive(false);
        }
    }


}
