using UnityEngine;
using System.Collections;

public class FadeController : MonoBehaviour
{
    public static Animator animator;
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        animator = GetComponent<Animator>();
        GlobalController.fadeController = this;
        animator.Play("SceneFadeIn");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnLevelWasLoaded(int level)
    {
        animator.Play("SceneFadeIn");
    }

    public void LoadLevel(int level)
    {
        StartCoroutine(LoadLevelWithFade(level));
    }

    public void LoadLevel(string levelName)
    {
        StartCoroutine(LoadLevelWithFade(levelName));
    }


    public static IEnumerator LoadLevelWithFade(int level)
    {
        animator.Play("SceneFadeOut");
        yield return new WaitForSeconds(1f);
        Application.LoadLevel(level);
    }

    public static IEnumerator LoadLevelWithFade(string levelName)
    {
        animator.Play("SceneFadeOut");
        yield return new WaitForSeconds(1f);
        Application.LoadLevel(levelName);
    }
}
