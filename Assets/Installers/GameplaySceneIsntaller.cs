using UnityEngine;
using Zenject;

public class GameplaySceneIsntaller : MonoInstaller
{
    private LevelLoadingData _levelLoadingData;

    public override void InstallBindings()
    {
        Container.Bind<LevelLoadingData>().FromInstance(_levelLoadingData);
    }

    [Inject]
    private void Cosntruct(LevelLoadingData levelLoadingData)
    {
        _levelLoadingData = levelLoadingData;
        Debug.Log(levelLoadingData.Level);
    }
}
