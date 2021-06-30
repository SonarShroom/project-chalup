using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArrowPickUp : Interactable
{

    
    public override void OnInteract()
    {
        
       
        base.OnInteract();

        Menu.instance.AddArrow(1);
        OnInteractionDistanceExit();
        Destroy(gameObject);
    }
}
