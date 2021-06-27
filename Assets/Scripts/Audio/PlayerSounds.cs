using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerSounds : MonoBehaviour
{
    CharacterAudio Audi;
    Menu playmenu;
    float waiter = .5f;
    private void Start()
    {
        Audi = GetComponent<CharacterAudio>();
        playmenu = Menu.instance;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {

            Sound s = Array.Find(Audi.sounds, Sound => Sound.name == "Footsteps");
            s.pitch = UnityEngine.Random.Range(1f,3f);

            if(waiter <= 0)
            {
                Audi.SpawnAudio("Footsteps", transform.position);
                waiter = .5f;
            }
            waiter -= Time.deltaTime;
             
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
