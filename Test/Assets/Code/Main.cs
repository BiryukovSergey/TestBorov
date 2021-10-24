using System.Collections.Generic;
using Code.AddBoxToPlayer;
using Code.Player;
using UnityEngine;

namespace Code
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private PlayerSO _playerSo;
        [SerializeField] private List<GameObject> _boxGameObject;
        public List<GameObject> BoxGameObject => _boxGameObject;

        private CollisionBox.CollisionBox _collisionBox;
        private PlayerData _playerData;
        private PlayerView _playerView;
        private PlayerController _playerController;
        private AddBox _addBox;


        private void Start()
        {
            _playerData = new PlayerData(_playerSo);
            _playerView = FindObjectOfType<PlayerView>();
            _playerController = new PlayerController(_playerView, _playerSo);
            _collisionBox = new CollisionBox.CollisionBox(_playerView, this);
            _addBox = new AddBox(_boxGameObject);
        }

        private void FixedUpdate()
        {
            _playerController.Move(_playerData.Speed, _playerView.PlayerRigidbody);
        }

        public void OnCollisionEnter(Collision other)
        {
            _collisionBox.OnCollisionBox(other);
        }
    }
}