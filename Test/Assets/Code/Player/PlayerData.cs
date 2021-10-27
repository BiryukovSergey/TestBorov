using System;
using Code.Player;

[Serializable]
public class PlayerData
{
    private float _speed;
    public float Speed => _speed;

    public PlayerData(PlayerSO playerSo)
    {
        _speed = playerSo.Speed;
    }
}
