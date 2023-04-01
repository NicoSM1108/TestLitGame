using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMiraGuiada : MonoBehaviour
{

    private void Start()
    {
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            if (GetComponentInParent<BalaGuiadaBehaviour>().Target_Object == null)
            {
                GetComponentInParent<BalaGuiadaBehaviour>().Target_Object = other.gameObject;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Target")
        {
            GetComponentInParent<BalaGuiadaBehaviour>().Target_Object = null;
        }
    }

}
