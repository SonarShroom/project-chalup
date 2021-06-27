using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{

    #region Singleton
    public static Menu instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    //Arrow Counter
    public Text Arrowcounterdisplay;
    public int ArrowCounter;
    public int MaxArrowAmount;
    private void Update()
    {
        Arrowcounterdisplay.text = "";
        Arrowcounterdisplay.text = ArrowCounter.ToString() + "/" + MaxArrowAmount.ToString();


    }







    //Methods to ad and remove arrows
    public void AddArrow(int numbertoadd)
    {
       if(ArrowCounter != MaxArrowAmount)
        {
            ArrowCounter += numbertoadd;
        }
        if (ArrowCounter > MaxArrowAmount)
            ArrowCounter = MaxArrowAmount;
    }
    public void RemoveArrow()
    {
        if(ArrowCounter != 0)
        ArrowCounter -= 1;
        if (ArrowCounter < 0)
            ArrowCounter = 0;
    }
}
