using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PickBrother : Interactable
{
    public override void OnInteract()
    {
        base.OnInteract();
        SceneManager.LoadScene(2);
    }
}
