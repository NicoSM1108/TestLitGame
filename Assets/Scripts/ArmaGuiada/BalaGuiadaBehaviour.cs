using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaGuiadaBehaviour : MonoBehaviour
{
    [HideInInspector]
    public GameObject Target_Object;

    public Rigidbody RB;

    public float Speed_Normal;

    public float Speed_Attack;

    public float Time_Desaparecer;


    GameObject _camera;

    Vector3 _cameraUp;

    Vector3 forwardPos;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, Time_Desaparecer);

        _camera = GameObject.FindGameObjectWithTag("MainCamera");

        _cameraUp = _camera.transform.up;
        forwardPos = transform.forward;

        RB.velocity = forwardPos * Speed_Normal + _cameraUp * 1;

    }

    // Update is called once per frame
    void Update()
    {
        Normal_Movement();

        Target_Movement();

    }

    public void Normal_Movement()
    {
        if (Target_Object == null)
        {
            RB.velocity = forwardPos * Speed_Normal + _cameraUp * 1;
            //  RB.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }

    public void Target_Movement()
    {
        if (Target_Object != null)
        {
            RB.constraints = RigidbodyConstraints.None;

            transform.LookAt(Target_Object.transform);

            RB.velocity = transform.forward * Speed_Attack;

        }

    }


}
