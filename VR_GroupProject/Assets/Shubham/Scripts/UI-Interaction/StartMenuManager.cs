using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class StartMenuManager : MonoBehaviour
{
    public Animator animator;
    public GameObject fadingPanel;

    public Canvas mainPanel, loadingPanel;

    public TextMeshProUGUI loadingPercentage;
    public Slider loadingBar;


    [SerializeField] int sceneIndex = 1;

    private void Start()
    {
        mainPanel.enabled = true;
        loadingPanel.enabled = false;
    }

    public void StartGame()
    {
        StartCoroutine(LoadAsync(sceneIndex));        
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        float loading;

        mainPanel.enabled = false;
        loadingPanel.enabled = true;

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            //Debug.Log(operation.progress);

            loading = Mathf.Clamp01(operation.progress / 0.9f);

            loadingBar.value = loading;

            loading *= 100;

            loadingPercentage.text = "Loading... " + loading.ToString() + "% done";

            yield return null;
        }
    }
}
