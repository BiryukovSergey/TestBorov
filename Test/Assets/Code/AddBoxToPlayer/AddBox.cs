using System.Collections.Generic;
using Code.Player;
using UnityEngine;

namespace Code.AddBoxToPlayer
{
    public class AddBox
    {
        public List<GameObject> _box;
        private Transform _playerTransform;
        public AddBox(List<GameObject> box)
        {
            _box = box;
        }
        public void AddBoxToPlayer(PlayerView playerView)
        {
            var box = Resources.Load("Cube") as GameObject;
            var gameObject = GameObject.Instantiate(box);
            gameObject.transform.SetParent(playerView.transform);
            gameObject.transform.position = playerView.transform.position + Vector3.up;
            gameObject.transform.rotation = Quaternion.identity;
            //playerView.transform.localPosition = playerView.transform.position + Vector3.up;
            Debug.Log(_playerTransform);
            //_box.Add(prefab);
        }
    }
}