using Code.AddBoxToPlayer;
using Code.Player;
using UnityEngine;

namespace Code.CollisionBox
{
    public class CollisionBox
    {
        private AddBox _addBox;
        private PlayerView _playerView;
        private GameObject _boxObj;
        private int i = 0;

        public CollisionBox(PlayerView playerView,GameObject gameObject)
        {
            _playerView = playerView;
            _boxObj = gameObject;
            _addBox = new AddBox(_playerView);
        }

        public void OnCollisionBox(GameObject player,GameObject cube)
        {
            if (player.CompareTag("Cube") || cube.CompareTag("Cube"))
            {
                //GameObject.Destroy(enemy.gameObject);
                _addBox.AddBoxToPlayer(player.gameObject);
            }
        }
    }
}