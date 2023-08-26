using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStars : MonoBehaviour
{
    public GameObject stars; 
    public float heightLoc = 1; 
    public int numStars = 4;
    
    // void Start() {

    // float leftPoint = transform.position.x - heightLoc; 
    // float rightPoint = transform.position.x + heightLoc; 

    // for(int i = 0; i <= numStars; i++ )
    //     Instantiate(stars, new Vector3(Random.Range(leftPoint, rightPoint), transform.position.y,0), transform.rotation); 
    // }

    public void spawnAmount() {
        // Debug.Log("spawning"); 

    float leftPoint = transform.position.x - heightLoc; 
    float rightPoint = transform.position.x + heightLoc; 

    numStars = Random.Range(4, 8); 

    for(int i = 0; i <= numStars; i++ )
        Instantiate(stars, new Vector3(Random.Range(leftPoint, rightPoint), transform.position.y,0), transform.rotation); 
   }
}
