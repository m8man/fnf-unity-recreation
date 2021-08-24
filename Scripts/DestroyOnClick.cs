using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{


   void Update() 
   {
      if(Input.anyKeyDown)
		 {
		 Destroy(gameObject);
		 }
	 
   }
}
