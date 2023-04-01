using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMagnetica : MonoBehaviour
{
    public Rigidbody BalaRB;

    public float Speed;

    public float TiempoDesaparecer;

    GameObject _camera;

    Vector3 _cameraUp;

    Vector3 forwardPos;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, TiempoDesaparecer);

        _camera = GameObject.FindGameObjectWithTag("MainCamera");

        _cameraUp = _camera.transform.up;
        forwardPos = transform.forward;

        BalaRB.velocity = forwardPos * Speed + _cameraUp * 1;

    }

    private void Update()
    {
        BalaRB.velocity = forwardPos * Speed + _cameraUp * 1;
    }

}
