using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {
    
    public Move movement;


    public GameObject timer;

   // public GameObject[] Gem;

    Renderer rend;

    public Material[] material;

    public float RestartTime =10f;

    bool PowerCheck = false;

    int timeLeft = 10;

    public Text countDownText;

    bool ok = true;

   
    
    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
       
           
        
        
    }

    private void FixedUpdate()
   {
        
        if(PowerCheck==true)
        {
            
            countDownText.text = (timeLeft.ToString());
            if(ok)
            {
                ok = false;
                StartCoroutine("LeftTime");
                
            }
            
        }
   }

    IEnumerator LeftTime()
    {
        while(!ok)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
          //  Debug.Log("sec");
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") 
              {
          
            
            movement.enabled = false;
              FindObjectOfType<GameManager>().EndGame();
             
            
        }
        

        
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="CubeBlue")
        {
            //Debug.Log("atins");
            Destroy(other.gameObject);

            //schimb culoare cub
            rend.sharedMaterial = material[1];

            //schimb viteza cub
            movement.ForwardForce = 50;

            timeLeft = 10;

            timer.SetActive(true);

            PowerCheck = true;

            Invoke("StandardSpeed", RestartTime);
            


        }
        
        if (other.gameObject.tag == "CubeRed")
        {
            //Debug.Log("atins");
            Destroy(other.gameObject);

            //schimb culoare cub
            rend.sharedMaterial = material[2];

            //schimb viteza cub
            movement.ForwardForce = 200;
            movement.SideForce = 5500;

            timeLeft = 10;

            timer.SetActive(true);

            PowerCheck = true;

            Invoke("StandardSpeed", RestartTime);

        }
        if (other.gameObject.tag == "CubeGold")
        {


            Destroy(other.gameObject);

            //schimb culoare cub
            rend.sharedMaterial = material[3];



            //schimb viteza cub
            RenderSettings.fog = false;

            movement.ForwardForce = 400;
            movement.SideForce = 4500;

            timeLeft = 10;

            timer.SetActive(true);

            PowerCheck = true;

            Invoke("StandardSpeed", RestartTime);

        }
     
    }

    void StandardSpeed()
    {
        if (timeLeft <= 1)
        {
            movement.ForwardForce = 100;
            movement.SideForce = 4000;
            rend.sharedMaterial = material[0];
            timer.SetActive(false);
            timeLeft = 11;
            PowerCheck = false;
            ok = true;
            RenderSettings.fog = true;
        }
       
      
    }

}
