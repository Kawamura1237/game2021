using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private float speed;
    public Rigidbody rb;
    public  bool isFloor;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();  // rigidbody���擾  

    }

    void OnCollisionStay(Collision collision)
    {  //"Floor"�^�O���t���Ă���I�u�W�F�N�g

        isFloor = true;
      
    }

    void OnCollisionExit(Collision collision)
    {  //"Floor"�^�O���t���Ă���I�u�W�F�N�g

        isFloor = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFloor)
        {
            
            //float x = Input.GetAxis("Horizontal");
            
            if (Input.GetKey(KeyCode.D))
            {
                speed = 5;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                speed = -5;
            }
            else
            {
                speed = 0.0f;
            }
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);

        }
    }

}