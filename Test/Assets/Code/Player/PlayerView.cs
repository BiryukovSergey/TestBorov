using UnityEngine;

namespace Code.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Rigidbody _playerRigitbody;
        public Rigidbody PlayerRigidbody => _playerRigitbody;
    }
}