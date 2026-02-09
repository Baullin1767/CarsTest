using Core.Interfaces;
using Core.Player;
using Core.Player.Interfaces;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private WheelJoint2D playerWheelJoint;
    
    public override void InstallBindings()
    {
        BindPlayerDependencies();
    }
    
    private void BindPlayerDependencies()
    {
        Container.Bind<IPlayerInput>()
            .To<PlayerInput>()
            .AsSingle();

        Container.Bind<IMovement>()
            .To<PlayerMove>()
            .AsSingle()
            .WithArguments(playerWheelJoint);
    }
}