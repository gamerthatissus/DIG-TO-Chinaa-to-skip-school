using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody myRigidbody;
     public CapsuleCollider myCapsuleCollider;

     private bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       isgrounded=IsGrounded();
       
        if (Input.GetKeyDown(KeyCode.Space) == true && isgrounded==true) 
        {
myRigidbody.velocity=Vector3.up*10;
        }
       
       
       
       
        if (Input.GetKeyDown(KeyCode.W) == true) 
        {

        }


 if (Input.GetKeyDown(KeyCode.A) == true) 
 {

 }
 
 if (Input.GetKeyDown(KeyCode.S) == true) 
 {


 }

 if (Input.GetKeyDown(KeyCode.D) == true)
 {


 }
 

    }

    private bool IsGrounded()
{

RaycastHit hit;
float dis=0.1f; 


if (Physics.Raycast(myCapsuleCollider.bounds.center, Vector3.down, out hit, myCapsuleCollider.bounds.extents.y + dis))
{

return true;

}else{

return false;
    
}

}

}

