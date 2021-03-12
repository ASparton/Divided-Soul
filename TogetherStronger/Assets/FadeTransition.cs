using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeTransition : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        anim.Play("FadeOut");
    }

    public void changeScene(string name)
    {
        anim.Play("FadeIn");
        StartCoroutine(LoadScene(name));
    }

    // Wait two seconds then load the next scene.
    private IEnumerator LoadScene(string name)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(name);
    }
}
