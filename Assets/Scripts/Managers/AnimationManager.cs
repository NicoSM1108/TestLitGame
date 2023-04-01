using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    public static int Tipo_Animacion;  // 1 , 2 , 3

    public Animator Player_Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeAnimation();

        print(Tipo_Animacion);

    }

    public void ChangeAnimation()
    {
        if (Tipo_Animacion == 1)
        {
            Player_Animator.SetTrigger("1");
        }

        else if (Tipo_Animacion == 2)
        {
            Player_Animator.SetTrigger("2");
        }
        else if (Tipo_Animacion == 3)
        {
            Player_Animator.SetTrigger("3");
        }

    }

    public void Button_Pressed(int Y)
    {
        Tipo_Animacion = Y;
    }

}
