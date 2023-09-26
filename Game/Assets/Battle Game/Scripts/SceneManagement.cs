using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] GameObject screen;
    [SerializeField] Image progressUI;
    
    public void NextScene()
    {
        StartCoroutine(LoadScene("War"));
    }
    private IEnumerator LoadScene(string name)
    {

        screen.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(name);
        progressUI.fillAmount = 0;

        //allowSceneActivation : 씬 이동을 제어하는 변수
        //true -> 씬 이동
        //false -> 안 함
        operation.allowSceneActivation = false;
        float progress = 0;

        //isDone : 씬 로딩이 다 끝났는 지 확인
        //true 로딩 끝남
        //false 로딩 중
        while(!operation.isDone)
        {
            progress = Mathf.MoveTowards(progress,operation.progress,Time.deltaTime);
            progressUI.fillAmount = progress;
            //0.9f에서 씬 로딩 끝
            if (progress >= 0.9f)
            {
                progressUI.fillAmount = 1f;
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }

}
