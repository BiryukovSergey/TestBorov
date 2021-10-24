using UnityEngine;

namespace Code.Player
{
    [CreateAssetMenu (menuName = "PlayerConfig", fileName = "PlayerSO", order = 1)]
    public class PlayerSO : ScriptableObject
    {
        public float Speed;
    }
}