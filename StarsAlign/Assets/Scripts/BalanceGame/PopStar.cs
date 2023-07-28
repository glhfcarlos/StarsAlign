using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopStar : MonoBehaviour
{

    void Update()
    {
       StartCoroutine(destroyPopStar());  
    }
    
    IEnumerator destroyPopStar() {
        yield return new WaitForSeconds(.50f); 
        Destroy(gameObject); 
    }
}
