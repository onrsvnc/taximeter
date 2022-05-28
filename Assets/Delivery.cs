using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   [SerializeField] Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
   [SerializeField] Color32 noPackageColor = new Color32 (1, 1, 1, 1);
   [SerializeField] float DestroyDelay = 0.5f ;
   SpriteRenderer spriteRenderer;
   void Start() 
   {
   spriteRenderer = GetComponent <SpriteRenderer>();   
   }
   bool hasPassenger; 
    
     void OnCollisionEnter2D(Collision2D other) {
     Debug.Log("Carefull Biotch!!!");
       
    }
       void OnTriggerEnter2D(Collider2D other) {
          
         if (other.tag == "Passenger" && !hasPassenger)
          {
          Debug.Log("Passenger Picked Up");
          hasPassenger = true;
          spriteRenderer.color = hasPackageColor;
          Destroy(other.gameObject, DestroyDelay);
          
          }
          if (other.tag == "Destination" && hasPassenger)
          {
             Debug.Log("Passenger Delivered");
             hasPassenger = false;
             spriteRenderer.color = noPackageColor;
             

          }
      }

}
