using System;

public class LevelManager
{
    private Action _onWinAction;
    private Action _onLoseAction;

    public void SubscribeWin(Action onWin)
    {
        _onWinAction += onWin;
    }
    public void SubscribeLose(Action onLose)
    {
        _onLoseAction += onLose;
    }
    public void UnsubscribeWin(Action onWin)
    {
        _onWinAction -= onWin;
    }
    public void UnsubscribeLose(Action onLose)
    {
        _onLoseAction -= onLose;
    }

    public void OnWin()
    {
        _onWinAction?.Invoke();
    }

    public void OnLose()
    {
        _onLoseAction?.Invoke();
    }
}
