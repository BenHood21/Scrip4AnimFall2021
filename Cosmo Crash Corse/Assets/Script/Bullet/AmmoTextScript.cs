using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoTextScript : MonoBehaviour
{
   public Text text;
   public static int ammoAmount = 0;
   public int ammoMax;
   private void Start()
   {
      text = GetComponent<Text>();

      while (ammoMax < 24)
      {
          if (ammoAmount > 0)
               {
                  text.text = "" + ammoAmount;
               }
         
               else
               {
                  text.text = "0";
               }
      }
   }
}
