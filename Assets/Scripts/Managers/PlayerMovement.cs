using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Dependencies")]
    public Rigidbody PlayerRB;

    [Header("Variables")]
    public float Speed;
    public float JumpForce;
    public float SensX;
    public float SensY;

    bool IsGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        SensY = SensY * -1;

        Cursor.lockState = CursorLockMode.Confined;

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        Jump();

        RotateY();

    }

    public void Movement()
    {
        float AxisX = Input.GetAxis("Horizontal");
        float AxisY = Input.GetAxis("Vertical");

        if(AxisX!=0 || AxisY != 0)
        {
            Vector3 motion = transform.forward * Speed * AxisY + transform.right * Speed * AxisX;

            PlayerRB.velocity = new Vector3(motion.x, PlayerRB.velocity.y, motion.z);

        }
        else
        {
            PlayerRB.velocity = new Vector3(0, PlayerRB.velocity.y, 0);
        }

    }

    public void Jump()
    {
        if (IsGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerRB.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);

                IsGrounded = false;

            }
        }
    }

    public void RotateY()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * SensX, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsGrounded = false;
        }
    }

}
