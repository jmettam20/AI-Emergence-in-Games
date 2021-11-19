using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antDetector : MonoBehaviour
{

    


    public float WorkertimeLeft = 2; 
    public float HuntertimeLeft = 2; 

    public int workerCounter;

    public int hunterCounter; 

    public GameObject Hunter; 
    public GameObject Worker; 

   



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Workertimer();
      antCheck();
    }

    public void antCheck(){

        Debug.Log(gameObject.tag);
        if(gameObject.tag == "Worker" ){

            Debug.Log("I am worker");
        }

        if(gameObject.tag == "Hunter"){
            Debug.Log("I am hunter");
        }
    }

     public void Workertimer(){
         if (WorkertimeLeft > 0)
        {
            WorkertimeLeft -= Time.deltaTime;
            
        }
        if(WorkertimeLeft <= 0){
            
             

            if(workerCounter < 10){
                Debug.Log("Not seen ant for a while!");
                Instantiate(Hunter,transform.position,transform.rotation);
                Destroy(gameObject);
            }

            WorkertimeLeft = 2; 
           

        }
    }

       public void Huntertimer(){
         if (HuntertimeLeft > 0)
        {
            HuntertimeLeft -= Time.deltaTime;
            
        }
        if(HuntertimeLeft <= 0){
            
             

            if(hunterCounter < 10){
                Debug.Log("Not seen ant for a while!");
                Instantiate(Hunter,transform.position,transform.rotation);
                Destroy(gameObject);
            }

            HuntertimeLeft = 2; 
           

        }
    }



      private void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Worker")
        {       
                WorkertimeLeft = 2; 
                workerCounter ++; 
              
        }

        if(other.tag == "Hunter"){
            HuntertimeLeft = 2; 
            hunterCounter ++;
        }
    } 
}
