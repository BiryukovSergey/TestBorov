using System;
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
        [SerializeField] private GameObject _cubeCollision;
        [SerializeField] private GameObject _boxObj;
        [SerializeField] private GameObject _tempCube;

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
            _collisionBox = new CollisionBox.CollisionBox(_playerView, _boxObj);
            _addBox = new AddBox(_playerView); 
        }

        private void FixedUpdate()
        {
            _playerController.Move(_playerData.Speed, _playerView.PlayerRigidbody);
        }

        public void OnCollisionEnter(Collision collision)
        { 
            if (collision.gameObject.TryGetComponent(out Enemy enemy) && _tempCube != collision.gameObject)
            {
                _tempCube = collision.gameObject;
                _collisionBox.OnCollisionBox(enemy.gameObject,_cubeCollision);
            }
        }
    }
}