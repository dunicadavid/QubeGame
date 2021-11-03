using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public Rigidbody rb;

    public float ForwardForce = 2000f;

    public float SideForce = 500f;

    bool right = false;

    bool left = false;
    
    void Start () {
        rb.AddRelativeForce(Vector3.right * ForwardForce - rb.velocity);
    }
	
	
	void FixedUpdate () {
        // rb.AddForce(ForwardForce *Time.deltaTime, 0, 0);

        rb.AddRelativeForce(Vector3.right * ForwardForce - rb.velocity);
        // rb.velocity = transform.forward * Time.deltaTime * ForwardForce;
        if (left == true)
        {
            rb.AddForce(0, 0, SideForce * Time.deltaTime);
        }

        if (right == true)
        {
            rb.AddForce(0, 0, -SideForce * Time.deltaTime);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                        left = true;

                    if (touch.position.x > Screen.width / 2)
                        right = true;
                    break;

                case TouchPhase.Moved:
                    if (touch.position.x < Screen.width / 2)
                    {
                        right = false;
                        left = true;
                    }
                    if (touch.position.x > Screen.width / 2)
                    {
                        right = true;
                        left = false;
                    }
                    break;

                case TouchPhase.Ended:
                    left = false;
                    right = false;
                    break;

            }
        }

        if (rb.position.y < -1) 
        {
            
            FindObjectOfType<GameManager>().EndGame();
            ///NewPosition();
            
        }
    }

    public void NewPosition()
    {
        rb.position = new Vector3(rb.position.x, 1, 1);
        rb.rotation = Quaternion.Euler(0, 0, 0);
        rb.velocity = Vector3.zero;
       /// Timer.SetActive(false);
    }
}
