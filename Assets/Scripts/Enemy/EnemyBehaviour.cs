using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bala")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
