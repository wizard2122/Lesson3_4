using Zenject;

public class SceneLoadMediator : ISceneLoadMediator
{
    private ISimpleSceneLoader _simpleSceneLoader;
    private ILevelLoader _levelLoader;

    [Inject]
    private void Construct(ISimpleSceneLoader simpleSceneLoader, ILevelLoader levelLoader)
    {
        _simpleSceneLoader = simpleSceneLoader;
        _levelLoader = levelLoader;
    }

    public void GoToGameplayLevel(LevelLoadingData levelLoadingData)
        => _levelLoader.Load(levelLoadingData);

    public void GoToLevelSelectionMenu()
        => _simpleSceneLoader.Load(SceneID.LevelSelection);

    public void GoToMainMenu()
        => _simpleSceneLoader.Load(SceneID.MainMenu);
}
