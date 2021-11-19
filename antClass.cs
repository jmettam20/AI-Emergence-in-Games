using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antClass : MonoBehaviour
{
  private bool isMoving; 
    private Vector3 origionalPos,targetPos; 
    public float timeToMove = 0.2f; 
    private int nextPosID; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectMovePoint(); 
    }

//ANT MOVEMENT
      public void selectMovePoint(){
        nextPosID = Random.Range(0,4); 

        if(nextPosID == 0 && !isMoving){
           StartCoroutine (MoveAnt(Vector3.up));
             
        }

        if(nextPosID == 1 && !isMoving){
           StartCoroutine(MoveAnt(Vector3.left));
           
        }

        if(nextPosID == 2 && !isMoving){
           StartCoroutine(MoveAnt(Vector3.down));
           
        }

        if(nextPosID == 3 && !isMoving){
           StartCoroutine(MoveAnt(Vector3.right));
            
        }


    }
    private IEnumerator MoveAnt(Vector3 direction){
        isMoving = true; 

        float elapsedTime = 0; 

        origionalPos = transform.position; 
        targetPos = origionalPos+direction; 

        while(elapsedTime < timeToMove){
            transform.position = Vector3.Lerp(origionalPos,targetPos,(elapsedTime/timeToMove));
            elapsedTime += Time.deltaTime; 
            yield return null; 
        }

        transform.position = targetPos; 

        isMoving = false; 
    }

    //TRIGGERS

     private void OnTriggerEnter2D(Collider2D other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Bounds")
        {
            Destroy(gameObject);
           // Debug.Log("Trigger");  
        }
    }
}
