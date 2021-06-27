using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InteractionManager : MonoBehaviour
{
  #region Singleton
    public static InteractionManager instance;
    private void Awake()
    {
        
            instance = this;
         if(GameObject.FindObjectOfType<InteractionManager>() != this)
        {
            Debug.LogWarning("More than one InteractionManager in scene");
            
        }
    }
    #endregion


    

    //Interact text bubble parent
    public Image InteractionBubble;
    [HideInInspector]
    public Animator DisplayTextAnimator;
    [HideInInspector]
    public Text DialogueBox;
    //Object currently interacting with player
    [HideInInspector]   
    public GameObject currentinteraction;

    private void Start()
    {
       
        DisplayTextAnimator = InteractionBubble.GetComponent<Animator>();
        DialogueBox = InteractionBubble.GetComponentInChildren<Text>();
        DisplayTextAnimator.transform.gameObject.SetActive(false);
    }

  


    public void AddDisplayInteracttext(string Newtext)
    {
        //Makes the text slide up if its down or down if its up
        DisplayTextAnimator.SetBool("isUp", !DisplayTextAnimator.GetBool("isUp"));
        DisplayTextAnimator.transform.gameObject.SetActive( !DisplayTextAnimator.transform.gameObject.activeSelf );
        DialogueBox.text = Newtext;
    }

    public void ResizeTextBox(Vector2 newsize)
    {
        RectTransform Textbox;
        Textbox = InteractionBubble.GetComponent<RectTransform>();

        Textbox.sizeDelta = newsize;
    }
    
}
