using System;
using Zenject;
using UnityEngine.SceneManagement;

public class ZenjectSceneLoaderWrapper
{
    private readonly ZenjectSceneLoader _zenjectSceneLoader;

    public ZenjectSceneLoaderWrapper(ZenjectSceneLoader zenjectSceneLoader)
    {
        _zenjectSceneLoader = zenjectSceneLoader;
    }

    public void Load(Action<DiContainer> action, int sceneID)
        => _zenjectSceneLoader.LoadScene(sceneID, LoadSceneMode.Single, container => action?.Invoke(container));
}
