using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{

    public Rigidbody myRigidbody;
    public BoxCollider myCapsuleCollider;
    public AudioSource mysound;
    public AudioSource mysound2;
    public float speed = 0;

    
    private bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {

        
mysound2.Play();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.MovePosition(myRigidbody.position + transform.forward * (speed * Time.deltaTime));

        
        isgrounded=IsGrounded();
       
        if (Input.GetKeyDown(KeyCode.Space) == true && isgrounded==true)
        {
            AudioSource.PlayClipAtPoint(mysound.clip,transform.position);
            myRigidbody.velocity=Vector3.up*10;
            
        }

        if (myRigidbody.position.y < -8)
        {
            myRigidbody.rotation=Quaternion.Euler(0,0,0); 
            myRigidbody.position = new Vector3(0, 5, 0);
        }

        if (Input.GetKey(KeyCode.W) == true)
        {
            if (speed < 5)
            {
                speed =  speed + (0.5f * Time.deltaTime) ;

            }
            else
            {
                if (speed < 15)
                {
                    speed =  speed + (1f * Time.deltaTime) ;
                }
                else
                {
                    if (speed < 25)
                    {
                        speed =  speed + (2f * Time.deltaTime) ;

                    }
                    else
                    {
                        if (speed < 50)
                        {
                            speed =  speed + (3f * Time.deltaTime) ;

                        }
                        else
                        {
                            speed = 50;

                        }

                    }
                }
                
                
            }
            
        }
        else
        {
            if (speed > 0.2)
            {
                speed = speed*(0.5f*Time.deltaTime);

            }
            else
            {
                speed = 0;
            }

        }
        
        if (Input.GetKey(KeyCode.S) == true) 
        {
            myRigidbody.MovePosition(myRigidbody.position + transform.forward * ((speed*-2) * Time.deltaTime));
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