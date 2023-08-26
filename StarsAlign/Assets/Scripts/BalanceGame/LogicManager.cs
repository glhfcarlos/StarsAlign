using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public Balanced balance;
    public Text timerText; 
    public GameObject playerStars; 
    public GameObject loverStars; 
    private float currTime = 0; 
    private bool timerRunning = false; 
    private int level = 0; 
    private int maxLevel = 4; 
    private bool passed = false; 
    private bool won = false; 

    public string winScene; 
    public string lostScene; 
    // public SpawnStars spawnStars; 
    // bool isPlaying = false; 

  public SpawnStars loverSpawn; 
  public SpawnStarsP playerSpawn; 
  public PStarPop killPStars; 
  public PStarPop killLovStars; 

  void Awake() {
    playerSpawn = GameObject.FindGameObjectWithTag("pSpawn").GetComponent<SpawnStarsP>();
    loverSpawn = GameObject.FindGameObjectWithTag("loSpawn").GetComponent<SpawnStars>();
    killPStars = GameObject.FindGameObjectWithTag("pStar").GetComponent<PStarPop>(); 
    killLovStars = GameObject.FindGameObjectWithTag("loverStar").GetComponent<PStarPop>(); 
  }
  void Start() {
    level = 1; 
    currTime = 10; 
    StartCoroutine(spawnStars()); 

  }
      private void Update() {
        // if(isPlaying == false) {
        //     if(Input.GetKeyDown(KeyCode.Space)) {
                // isPlaying = true; 
                currTime -= Time.deltaTime; 
                timerText.text = currTime.ToString("0"); 
                if(currTime <= 0) {
                      timerRunning = false; 
                      currTime = 0; 
                      score(); 
                }
        //     }
        // }
    }

    IEnumerator spawnStars() { 
      // if(level <= 1) {
      Destroy(GameObject.FindGameObjectWithTag("loverStar")); 
      Destroy(GameObject.FindGameObjectWithTag("pStar")); 
      // }
      yield return new WaitForSeconds(.02f); 
       playerSpawn.spawnAmount(); 
       loverSpawn.spawnAmount(); 
     
    }

    void score() {

      if(balance.equalAmountStars() == true) {
        // Debug.Log("correct amount with in the time"); 
        passed = true;  
      } else {
        won = false; 
        passed = false; 
        // Debug.Log("You failed and lost"); 

        SceneManager.LoadScene(lostScene);
      }

      if(passed == true && level != maxLevel) {
        // Debug.Log("You passed level " + level);
        level ++;
        passed = false; 
        currTime = 10; 
        StartCoroutine(spawnStars());  
      }
      if(balance.isZero()) {
        level--;
      }

      if(passed == true && level == maxLevel) {
        won = true;
       Destroy(GameObject.FindGameObjectWithTag("loverStar")); 
       Destroy(GameObject.FindGameObjectWithTag("pStar")); 
        Debug.Log("You won the game"); 
      }
      if(level >= maxLevel) {
            Debug.Log("end");
            SceneManager.LoadScene(winScene);
      }
    }
}
