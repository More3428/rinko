using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotController : MonoBehaviour
{
    public int slotNumber;
    public int pointValue;
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other){
        Debug.Log($"Entered {slotNumber} worth {pointValue} points");
        
    }
}
