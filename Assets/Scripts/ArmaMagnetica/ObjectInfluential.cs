using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInfluential : MonoBehaviour
{

    GameObject ObjectAtraccion;

    float DiffZ;

    public float SpeedForIr;

    float SpeedAround;

    bool Influenciado = false;

    public Rigidbody ObjectRB;

    // Start is called before the first frame update
    void Start()
    {
        SpeedAround = Random.Range(10,25);

        Destroy(this.gameObject, 35f);

    }

    // Update is called once per frame
    void Update()
    {
        if(ObjectAtraccion==null && Influenciado == false)
        {
            ObjectRB.velocity = Vector3.down;

            ObjectRB.constraints = RigidbodyConstraints.None;

        }

        if (ObjectAtraccion == null)
        {
            Influenciado = false;
        }

        Atraccion();

    }

    public void Atraccion()
    {
        if(ObjectAtraccion!=null && Influenciado == true)
        {
            DiffZ = (ObjectAtraccion.transform.position.z - transform.position.z);


            if (DiffZ < 0)
            {
                DiffZ = DiffZ * -1;
            }

            if (DiffZ >= 3.3f)
            {
                transform.LookAt(ObjectAtraccion.transform);

                ObjectRB.velocity = transform.forward * SpeedForIr;

            }

            else if (DiffZ <= 3.2f)
            {
                transform.LookAt(ObjectAtraccion.transform);

                ObjectRB.velocity = transform.right * SpeedAround;

                ObjectRB.constraints = RigidbodyConstraints.FreezePositionY;

            }


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Magnetico")
        {
            ObjectAtraccion = other.gameObject;

            Influenciado = true;

        }

        if (other.gameObject.tag == "Ground")
        {
            Destroy(this.gameObject);
        }

    }

}
