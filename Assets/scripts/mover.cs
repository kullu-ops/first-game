using UnityEngine;

public class mover : MonoBehaviour
{
  [SerializeField] int moveSpeed=33;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    //input wali statement se movement hoti h
    { 
     MovePlayer();

        
    }
  void PrintInstruction()
  {
    Debug.Log("welcome to  the game");
    Debug.Log("this is my first project");
  }
      void MovePlayer()
      {
      
            float xValue=Input.GetAxis("Horizontal") * Time.deltaTime*moveSpeed;
          float yValue=0f;
          float zValue=Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
          transform.Translate(xValue,yValue,zValue);
      }
}
