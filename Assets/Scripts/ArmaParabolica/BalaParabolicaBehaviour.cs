using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaParabolicaBehaviour : MonoBehaviour
{

    public float speedZ;

    public float SpeedY;

    public float TimeDesaparecer;

    public Rigidbody BalaRB;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, TimeDesaparecer);

        BalaRB.velocity = transform.forward * speedZ + transform.up*SpeedY;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }
    }

}
