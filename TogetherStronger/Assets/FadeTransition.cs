using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTransition : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim.Play("FadeOut");
    }

    public void changeScene(string name)
    {
        anim.Play("FadeIn");
        StartCoroutine(LoadScene(name));
    }

    IEnumerator LoadScene(string name)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(name);
    }
}
