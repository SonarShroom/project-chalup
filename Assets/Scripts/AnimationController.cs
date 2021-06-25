using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    GameObject player;
    Animator anim;
    private void Start()
    {
        player = Manager.instance.Player;
        anim = player.GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            anim.SetBool("isAiming",true);

        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            anim.SetBool("isAiming", false);

        }
    }
}
