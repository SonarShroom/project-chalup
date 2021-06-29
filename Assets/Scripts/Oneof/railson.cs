using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class railson : MonoBehaviour
{
    Preferencesholder hold;

    private void Start()
    {
        hold = Preferencesholder.instance;
    }
    private void Update()
    {
        gameObject.SetActive(!hold.isExplorationMode);
    }
}
