using UnityEngine;

public class LevelSelectionPanel : MonoBehaviour
{
    [SerializeField] private LevelSelectionButton[] _levelSelectionButtons;

    private void OnEnable()
    {
        foreach (var levelSelectionButton in _levelSelectionButtons)
            levelSelectionButton.Click += OnLevelSelected;
    }

    private void OnDisable()
    {
        foreach (var levelSelectionButton in _levelSelectionButtons)
            levelSelectionButton.Click -= OnLevelSelected;
    }

    private void OnLevelSelected(int level)
    {
        //загрузить уровень
    }
}
