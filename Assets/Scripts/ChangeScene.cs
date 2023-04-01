using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    public RectTransform panel;
    public void OnClick()
    {
        Debug.Log("hello");
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        panel.gameObject.SetActive(true);
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }

}
