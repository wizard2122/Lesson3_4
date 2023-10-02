public interface ISceneLoadMediator
{
    void GoToMainMenu();
    void GoToLevelSelectionMenu();
    void GoToGameplayLevel(LevelLoadingData levelLoadingData);
}
