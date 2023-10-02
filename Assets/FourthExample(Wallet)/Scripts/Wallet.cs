using System;

public class Wallet
{
    public event Action<int> Changed;

    public Wallet(int coins)
    {
        if (coins < 0)
            throw new ArgumentOutOfRangeException(nameof(coins));

        Coins = coins;
    }

    public int Coins { get; private set; }

    public void AddCoins(int coins)
    {
        if (coins < 0)
            throw new ArgumentOutOfRangeException(nameof(coins));

        Coins += coins;
        Changed?.Invoke(Coins);
    }

    public bool IsEnought(int coins)
    {
        if (coins < 0)
            throw new ArgumentOutOfRangeException(nameof(coins));

        return Coins >= coins;
    }

    public void Spend(int coins)
    {
        if (coins < 0)
            throw new ArgumentOutOfRangeException(nameof(coins));

        Coins -= coins;
        Changed?.Invoke(Coins);
    }
}
