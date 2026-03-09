using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Zenject;

public class LoseWindow : BaseWindow
{
    [Inject] private LevelManager LevelManager;
    protected override void Start()
    {
        base.Start();
        LevelManager.SubscribeLose(Show);
    }

    private void OnDestroy()
    {
        LevelManager.UnsubscribeLose(Show);
    }
}
