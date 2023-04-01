using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLoOK : MonoBehaviour
{

    public void Desactive()
    {
        gameObject.SetActive(false);
    }

    public void OnEnable()
    {
        Invoke("Desactive", 1.2f);
    }
}
