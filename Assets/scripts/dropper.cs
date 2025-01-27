using UnityEngine;

public class dropper : MonoBehaviour
{[SerializeField] float timeg=2f;
   MeshRenderer meshRenderer;
   Rigidbody rigidBody;
    void Start()
    { 
        meshRenderer=GetComponent<MeshRenderer>();
         rigidBody=GetComponent<Rigidbody>();
        meshRenderer.enabled=false;
         rigidBody.useGravity=false;
    }

  
    void Update()
    {
        if(Time.time >timeg)
        {
             meshRenderer.enabled=true;
         rigidBody.useGravity=true;
        }
    }
}
