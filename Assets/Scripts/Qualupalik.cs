using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Qualupalik : Entity
{

    Animator anim;
    AudioSource source;
    float counter;
    public override void starter()
    {
        base.starter();
        anim = GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }


    public override void Roar()
    {
        base.Roar();
        counter -= Time.deltaTime;
        if (counter <=0)
        {
            source.mute = false;
          
        }

    }
    public override void StopRoar()
    {
        base.StopRoar();
        source.mute = true;
    }
    public override void Attack()
    {
        base.Attack();
        SceneManager.LoadScene(0);
    }
    public override void Idle()
    {
        base.Idle();
        anim.SetBool("Idle", true);
        anim.SetBool("Chasing", false);
    }
    public override void Chasing()
    {
        base.Chasing();
        anim.SetBool("Chasing", true);
        anim.SetBool("Idle", false);
        agent.SetDestination(playercharacter.transform.position);
    }

}
