using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class MainMenuHUD : MonoBehaviour
{
    [SerializeField] private Button _levelSelectionMenuButton;

    private ISceneLoadMediator _sceneLoader;

    [Inject]
    private void Construct(ISceneLoadMediator sceneLoadMediator)
        => _sceneLoader = sceneLoadMediator;

    private void OnEnable()
        => _levelSelectionMenuButton.onClick.AddListener(OnLevelSelectionMenuClick);

    private void OnDisable()
        => _levelSelectionMenuButton.onClick.RemoveListener(OnLevelSelectionMenuClick);

    private void OnLevelSelectionMenuClick() => _sceneLoader.GoToLevelSelectionMenu();
}
