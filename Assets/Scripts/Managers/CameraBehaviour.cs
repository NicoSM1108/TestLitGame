using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        angle = (transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * GetComponentInParent<PlayerMovement>().SensY + 360) % 360;
        

        if (angle > 180)
        {
            angle = angle - 360;
        }

        angle = Mathf.Clamp(angle, -60, 72);

        transform.localEulerAngles = Vector3.right * angle;
    }
}
