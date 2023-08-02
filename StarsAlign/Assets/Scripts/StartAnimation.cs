using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class StartAnimation : MonoBehaviour
{
     public Image m_Image;
     public string sceneToLoad;

    public Sprite[] m_SpriteArray;
    public float m_Speed = .02f;

    private int m_IndexSprite = 0;
    Coroutine m_CorotineAnim;
    bool IsDone;
    void Start()
    {
        IsDone = false;
        StartCoroutine(Func_PlayAnimUI());
    }

    void Update() {

    }

    // public void Func_StopUIAnim()
    // {
    //     IsDone = true;
    //     StopCoroutine(Func_PlayAnimUI());
    //     SceneManager.LoadScene(sceneToLoad);
    // }
    IEnumerator Func_PlayAnimUI()
    {


        yield return new WaitForSeconds(m_Speed);
        if (m_IndexSprite >= m_SpriteArray.Length)
        {
          
            SceneManager.LoadScene(sceneToLoad);
            IsDone = true; 
            // m_IndexSprite = 0;
            m_Image.sprite = m_SpriteArray[m_IndexSprite];
            yield break;
        }
        
        m_Image.sprite = m_SpriteArray[m_IndexSprite];
        m_IndexSprite += 1;
        if (IsDone == false)
            m_CorotineAnim = StartCoroutine(Func_PlayAnimUI());


    }


}
