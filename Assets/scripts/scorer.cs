using UnityEngine;

public class scorer : MonoBehaviour
{ int hits=0;
    private void OnCollisionEnter(Collision other) 
   { if(other.gameObject.tag!="Hit")
      {hits++;
    Debug.Log("the current score is:  "+ hits);
    }
      
    
   }
}
