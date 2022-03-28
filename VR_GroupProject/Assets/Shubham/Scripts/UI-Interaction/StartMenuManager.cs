using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using TMPro;
using UnityEngine.UI;

public class StartMenuManager : MonoBehaviour
{
    public Animator animator;
    public GameObject fadingPanel;

    public Canvas mainPanel, instructionsPanel, loadingPanel;

    public TextMeshProUGUI loadingPercentage;
    public Slider loadingBar;


    [SerializeField] int sceneIndex = 1;

    bool instructionsShown;

    private void Start()
    {
        mainPanel.enabled = true;
        loadingPanel.enabled = false;
        instructionsPanel.enabled = false;

        instructionsShown = false;
    }

    public void StartGame()
    {
        StartCoroutine(LoadAsync(sceneIndex));        
    }

    public void ShowInstructions()
    {
        if (!instructionsShown)
        {
            instructionsShown = true;

            mainPanel.enabled = false;
            loadingPanel.enabled = false;

            instructionsPanel.enabled = true;
        }

        else
        {
            instructionsShown = false;

            mainPanel.enabled = true;
            loadingPanel.enabled = false;

            instructionsPanel.enabled = false;
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        float loading;

        mainPanel.enabled = false;
        loadingPanel.enabled = true;

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            loading = Mathf.Clamp01(operation.progress / 0.9f);

            loadingBar.value = loading;

            loading *= 100;

            loadingPercentage.text = "Loading... " + loading.ToString() + "% done";

            yield return null;
        }
    }
}
