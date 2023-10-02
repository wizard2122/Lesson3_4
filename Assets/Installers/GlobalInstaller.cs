using System;
using UnityEngine;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        BindInput();
        BindLoader();
        BindResources();
    }

    private void BindResources()
    {
        Container.BindInstance(new Wallet(1000)).AsSingle();
    }

    private void BindLoader()
    {
        Container.Bind<ZenjectSceneLoaderWrapper>().AsSingle();
        Container.BindInterfacesAndSelfTo<SceneLoader>().AsSingle();
        Container.BindInterfacesAndSelfTo<SceneLoadMediator>().AsSingle();
    }

    private void BindInput()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
            Container.BindInterfacesAndSelfTo<MobileInput>().AsSingle();
        else
            Container.BindInterfacesAndSelfTo<DesktopInput>().AsSingle();
    }
}