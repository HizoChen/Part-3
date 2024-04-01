using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    static Timer Instance;
    public float delayTime = 30f;
    int second;
    public TMPro.TextMeshProUGUI timer;
    private void Start()
    {
        second = 30;
        Instance = this;
        Invoke("LoadNext", delayTime);
        StartCoroutine(CountDownTimer());
    }

    public void LoadNext()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = 2;
        SceneManager.LoadScene(nextSceneIndex);
    }
    private System.Collections.IEnumerator CountDownTimer()
    {
        while (second > 0)
        {
            yield return new WaitForSeconds(1f);
            second -= 1;
            Instance.timer.text = second.ToString();
        }
    }
}
