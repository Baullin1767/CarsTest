using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YG;

public abstract class BaseWindow : MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private GameObject panel;

    protected virtual void Start()
    {
        Debug.Log("BaseWindow Start");
        restartButton.onClick.AddListener(Restart);
    }

    private void Restart()
    {
        var sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }

    protected void Show()
    {
        panel.SetActive(true);
        YG2.InterstitialAdvShow();
    }
}
