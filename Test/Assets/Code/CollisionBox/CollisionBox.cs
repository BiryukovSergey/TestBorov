using Code.AddBoxToPlayer;
using Code.Player;
using UnityEngine;

namespace Code.CollisionBox
{
    public class CollisionBox
    {
        private AddBox _addBox;
        private PlayerView _playerView;
        private Main _main;

        public CollisionBox(PlayerView playerView, Main main)
        {
            _main = main;
            _addBox = new AddBox(_main.BoxGameObject);
            _playerView = playerView;
        }

        public void OnCollisionBox(Collision collision)
        {
            if (collision.gameObject.GetComponent<Enemy>())
            {
                _addBox._box.Add(collision.gameObject);
                _addBox.AddBoxToPlayer(_playerView);
                //Object.Destroy(collision.gameObject);
                collision.gameObject.SetActive(false);
            }
        }
    }
}