using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformfallanimation : MonoBehaviour
{
   [SerializeField] private Animator myanimationcontroller;
   private void OnTriggerEnter(Collider other)
   {
    if(other.CompareTag("Player"))
    {
        myanimationcontroller.SetBool("platformfall",true);
    }
   }
    private void OnTriggerExit(Collider other)
   {
    if(other.CompareTag("Player"))
    {
        myanimationcontroller.SetBool("platformfall",false);
    }
   }
   
}
