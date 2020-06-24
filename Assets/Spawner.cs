using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject barrel;
    public GameObject Tire;
    public GameObject Walrus;
    public GameObject IceBlock;

    private int number;

    public float PositionSpawnX;

  

        
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnThePrefabs", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        


    }
    
    public void SpawnThePrefabs()
    {
        
            number = Random.Range(0, 5);
        PositionSpawnX = Random.Range(-2, 2);
        
            if (number == 1)
            {
                Instantiate(barrel, new Vector3(PositionSpawnX, transform.position.y,transform.position.z), transform.rotation);
            }

            else if (number == 2)
            {                
                Instantiate(Tire, new Vector3(PositionSpawnX, transform.position.y, transform.position.z), transform.rotation);
            }

            else if (number == 3)
            {               
                Instantiate(IceBlock, new Vector3(PositionSpawnX, transform.position.y, transform.position.z), transform.rotation);
            }
            else if (number == 4)
            {                
                Instantiate(Walrus, new Vector3(PositionSpawnX, transform.position.y, transform.position.z), transform.rotation);
            }
        
    }
        
    

    
}
