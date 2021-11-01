using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoTextScript : MonoBehaviour
{
   public Text text;
   public static int ammoAmount = 0;
   [Range(0, 24)]public int minAmmo;
   [Range(0, 24)]public int maxAmmo;
   private void Start()
   {
      text = GetComponent<Text>();
   }

   private void Update()
   {
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
