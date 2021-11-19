using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class antSpawn : MonoBehaviour
{
    public GameObject Worker; 
    public GameObject Hunter; 

    public int noOfWorkers; 
    public int noOfHunters; 

    // Start is called before the first frame update
    void Start()
    {

        for(int i = 0; i < noOfWorkers; ++i)
        {
             Instantiate(Worker);
             
        }

        for(int i = 0; i < noOfHunters; ++i)
        {
             Instantiate(Hunter);
             
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
