using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
public class CharacterAudio : MonoBehaviour
{

    public Sound[] sounds;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }












    //plays the sound by name
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);


        if (s == null)
        {
            Debug.Log("\"" + name + "\"" + " could not be found");
            return;
        }
        s.source.Play();
    }
    //plays the sound at point overlapping with any current sound
    public void SpawnAudio(string name, Vector3 point)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);


        if (s == null)
        {
            Debug.Log("\"" + name + "\"" + " could not be found");
            return;
        }
        AudioSource.PlayClipAtPoint(s.source.clip, point);
    }
}
