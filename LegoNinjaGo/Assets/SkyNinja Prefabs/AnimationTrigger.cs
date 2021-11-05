using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public GameObject kaiRunning;
    public GameObject kaiJumping;
    public GameObject kaiFalling;
    public Animator fade;

    public string sceneName;




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) ||
            Input.GetKeyDown(KeyCode.Space))
        {
            LoadScene();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Kai")
        {
            kaiRunning.SetActive(false);
            kaiJumping.SetActive(true);
            kaiFalling.SetActive(true);
          
          
            Debug.Log("playyer touch trigger");
            //Invoke("SetFade", 4f);
            //Invoke("LoadScene", 8f);
            StartCoroutine("SceneTransition");
            //fade.SetTrigger("end");
        }

    }
    void SetFade()
    {
        fade.SetTrigger("end");
       
    }

    void LoadScene()
    {

        SceneManager.LoadScene(sceneName);
    }
    IEnumerator SceneTransition()
    {
      

            yield return new WaitForSeconds(1f);
        fade.SetTrigger("end");

        kaiJumping.SetActive(false);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(sceneName);

    }

}
