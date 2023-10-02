using System;
public class SceneLoader : ISimpleSceneLoader, ILevelLoader
{
    private ZenjectSceneLoaderWrapper _zenjectSceneLoader;

    public SceneLoader(ZenjectSceneLoaderWrapper zenjectSceneLoader)
        => _zenjectSceneLoader = zenjectSceneLoader;

    public void Load(LevelLoadingData levelLoadingData)
    {
        _zenjectSceneLoader.Load(container =>
        {
            container.BindInstance(levelLoadingData).WhenInjectedInto<GameplaySceneIsntaller>();
        }, (int)SceneID.GameplayeLevel);
    }

    public void Load(SceneID sceneID)
    {
        if (sceneID == SceneID.GameplayeLevel)
            throw new ArgumentException($"{SceneID.GameplayeLevel} cannot be started without configuration");

        _zenjectSceneLoader.Load(null, (int)sceneID);
    }
}
