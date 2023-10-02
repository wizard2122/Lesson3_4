using Zenject;

public class FirstExampleInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<MovementHandler>().AsSingle().NonLazy();
    }
}
