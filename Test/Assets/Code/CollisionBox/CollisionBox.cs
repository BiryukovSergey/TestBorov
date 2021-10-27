using Code.AddBoxToPlayer;
using Code.Player;
using UnityEngine;

namespace Code.CollisionBox
{
    public class CollisionBox
    {
        private AddBox _addBox;
        private PlayerView _playerView;
        private int i = 0;

        public CollisionBox(PlayerView playerView)
        {
            _playerView = playerView;
            _addBox = new AddBox(_playerView);
        }

        public void OnCollisionBox(GameObject player, GameObject cube)
        {
            if (player.CompareTag("Cube") || cube.CompareTag("Cube"))
            {
                _addBox.AddBoxToPlayer(player.gameObject);
            }
        }
    }
}