using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody myRigidbody;
    public BoxCollider myCapsuleCollider;
    public AudioSource mysound;
    public AudioSource mysound2;

    
    private bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {
mysound2.Play();
    }

    // Update is called once per frame
    void Update()
    {
        isgrounded=IsGrounded();
       
        if (Input.GetKeyDown(KeyCode.Space) == true && isgrounded==true)
        {
            AudioSource.PlayClipAtPoint(mysound.clip,transform.position);
            myRigidbody.velocity=Vector3.up*10;
            
        }

        if (myRigidbody.position.y < -20)
        {
            myRigidbody.rotation=Quaternion.Euler(0,0,0);

            myRigidbody.position = new Vector3(0, 20, 0);
        }

        if (Input.GetKey(KeyCode.W) == true) 
        {
myRigidbody.MovePosition(myRigidbody.position+transform.forward * (15 * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.S) == true) 
        {
            myRigidbody.MovePosition(myRigidbody.position+transform.forward * (-10 * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.Mouse1) == true && isgrounded==true) 
        {
            
        }
        
        if (Input.GetKey(KeyCode.D) == true)
        {
    


        }
        
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
    
            myRigidbody.MoveRotation(myRigidbody.rotation * Quaternion.Euler(0, -60 * Time.deltaTime, 0));


        }
        
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
    
            myRigidbody.MoveRotation(myRigidbody.rotation * Quaternion.Euler(0, 60 * Time.deltaTime, 0));


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