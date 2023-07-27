using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopStar : MonoBehaviour
{
    // public float amp;
    // public float freq;
    // Vector3 initPos;
    // private void Start()
    // {
    //     initPos = transform.position;
    // }
    private void Update()
    {
        // transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y, 0);
        StartCoroutine(destroyAnimation());
    }

     IEnumerator destroyAnimation() {
      Debug.Log("destroy animation"); 
      yield return new WaitForSeconds(.50f); 
      Destroy(gameObject); 
    }
}
