using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{

    public Rigidbody EnemyRB;

    public float Speed;

    float Timer;

    public float DelayRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        EnemyRB.velocity = transform.forward * Speed;

        Rotacion();

    }

    public void Rotacion()
    {
        if (Time.time > Timer)
        {
            transform.Rotate(0, Random.Range(0, 361), 0);

            Timer = Time.time + DelayRotation;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            transform.Rotate(0, 180, 0);
        }
    }

}
