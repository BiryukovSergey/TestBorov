using System;
using Code.AddBoxToPlayer;
using Code.Player;
using UnityEngine;

namespace Code.SubtractingCubes
{
    public class SubtractingCubesView : MonoBehaviour
    {
        [SerializeField] private GameObject _box;
        [SerializeField] private PlayerView _playerView;
        private AddBox _addBox;
        private bool _isCanRemove;

        private void Start()
        {
            _addBox = FindObjectOfType<Main>().AddBox;
            _isCanRemove = true;
        }

        private void OnCollisionEnter(Collision other)
        {
            if (_isCanRemove && other.gameObject.CompareTag("Player"))
            {
                _isCanRemove = false;
                _addBox.RemoveBoxes();
                gameObject.SetActive(false);
            }
        }
    }
}