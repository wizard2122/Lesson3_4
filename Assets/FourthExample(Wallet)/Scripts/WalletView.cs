using TMPro;
using UnityEngine;
using Zenject;

public class WalletView : MonoBehaviour
{
    [SerializeField] private TMP_Text _coins;

    private Wallet _wallet;

    [Inject]
    private void Construct(Wallet wallet) => _wallet = wallet;

    private void OnEnable()
    {
        _wallet.Changed += UpdateValue;

        UpdateValue(_wallet.Coins);
    }

    private void OnDisable()
    {
        _wallet.Changed -= UpdateValue;
    }

    public void Show() => gameObject.SetActive(true);
    public void Hide() => gameObject.SetActive(false);

    private void UpdateValue(int coins) => _coins.text = coins.ToString();
}
