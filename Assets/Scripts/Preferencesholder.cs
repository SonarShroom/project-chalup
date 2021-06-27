using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Preferencesholder : MonoBehaviour
{
    #region Singleton
    public static Preferencesholder instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    public float MouseSensitivity;
    public bool isExplorationMode;

   
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    
}
