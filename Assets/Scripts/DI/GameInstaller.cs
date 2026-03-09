using Core.Interfaces;
using Core.Player;
using Core.Player.Interfaces;
using Zenject;

namespace DI
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindPlayerDependencies();
            BindLevelManagerDependencies();
        }
    
        private void BindPlayerDependencies()
        {
            Container.Bind<IPlayerInput>()
                .To<PlayerInput>()
                .AsSingle();

            Container.Bind<IMovement>()
                .To<PlayerMove>()
                .AsTransient();
        }
    
        private void BindLevelManagerDependencies()
        {
            Container.Bind<LevelManager>().AsSingle();
        }
    }
}