using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerSounds : MonoBehaviour
{
    CharacterAudio Audi;
    Menu playmenu;
    float waiter = .5f;
    Player mainchar;
    public float drawn;
    private void Start()
    {
        Audi = GetComponent<CharacterAudio>();
        playmenu = Menu.instance;
        mainchar = EventManager.instance.PlayerCharacter.GetComponent<Player>();
    }
  
  





    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && mainchar.groundcheck)
        {
            Audi.SpawnAudio("Jump", transform.position);
        }

        bool hadground;

        if (hadground = false && mainchar.groundcheck == true)
        {
            Audi.SpawnAudio("Land", transform.position);
        }

        hadground = mainchar.groundcheck;

       if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {
            if (hadground == true)
            {
                Sound s = Array.Find(Audi.sounds, Sound => Sound.name == "Footsteps");
                s.pitch = UnityEngine.Random.Range(1f, 2f);

                if (waiter <= 0)
                {
                    Audi.Play("Footsteps");
                  //  Audi.SpawnAudio("Footsteps", transform.position);
                    waiter = .5f;
                }
                waiter -= Time.deltaTime;
            }
        }
       if(playmenu.ArrowCounter > 0)
        {
           
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Audi.SpawnAudio("DrawBow", transform.position);
            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {

                Audi.SpawnAudio("ShootArrow", transform.position);
            }
        }
    }
}
