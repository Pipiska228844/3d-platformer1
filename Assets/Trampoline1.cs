using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline1 : MonoBehaviour
{
    public float jumpStrenght = 5.0f;

    void OnTriggerEnter(Collider other)
   {
       other.GetComponent<Jump>().jumpStrength *= jumpStrenght;
   }     

    void OnTriggerExit(Collider other)
    {
       other.GetComponent<Jump>().jumpStrength /= jumpStrenght;
    }
}
