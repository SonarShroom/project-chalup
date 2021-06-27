using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    #region Singleton
    public static EventManager instance;
    private void Awake()
    {
        instance = this;
        PlayerCharacter = GameObject.FindObjectOfType<Player>().gameObject;
    }
    #endregion


    public GameObject PlayerCharacter;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        if(PlayerCharacter == null)
        {
            PlayerCharacter = GameObject.FindObjectOfType<Player>().gameObject;
        }
    }

}
