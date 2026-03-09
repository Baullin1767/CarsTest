using Zenject;

public class WinWindow : BaseWindow
{
    [Inject] private LevelManager LevelManager;
    protected override void Start()
    {
        base.Start();
        LevelManager.SubscribeWin(Show);
    }

    private void OnDestroy()
    {
        LevelManager.UnsubscribeWin(Show);
    }
}
