using UnityEngine;
using UnityEngine.UI;

public class MainMenuHUD : MonoBehaviour
{
    [SerializeField] private Button _levelSelectionMenuButton;

    private void OnEnable()
        => _levelSelectionMenuButton.onClick.AddListener(OnLevelSelectionMenuClick);

    private void OnDisable()
        => _levelSelectionMenuButton.onClick.RemoveListener(OnLevelSelectionMenuClick);

    private void OnLevelSelectionMenuClick()
    {
        //загрузить сцену выбора уровня
    }
}
