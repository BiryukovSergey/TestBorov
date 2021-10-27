using UnityEngine;

namespace Code.Player
{
    public class PlayerController
    {
        private PlayerData _playerData;
        private Vector3 _move;
        private Rigidbody _playerRigidbody;

        public PlayerController(PlayerView playerView, PlayerSO playerSo)
        {
            _playerData = new PlayerData(playerSo);
            _playerRigidbody = playerView.PlayerRigidbody;
        }

        public void Move(float speed, Rigidbody rigidbody)
        {
            _move += new Vector3((Input.GetAxis(PlayerMoveAxes.Horizontal)) * speed, 0, (Vector3.forward.z * speed));
            _move = Vector3.ClampMagnitude(_move, speed);
            rigidbody.velocity = _move;
        }
    }
}