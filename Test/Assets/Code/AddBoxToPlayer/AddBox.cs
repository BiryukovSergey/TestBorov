using System.Collections.Generic;
using Code.Player;
using UnityEngine;

namespace Code.AddBoxToPlayer
{
    public class AddBox
    {
        public List<GameObject> _boxListObj;
        private GameObject _boxes;
        private PlayerView _playerView;
        private Vector3 _upVector3;
        private int _count;

        public AddBox(PlayerView playerView)
        {
            _playerView = playerView;
            _boxListObj = new List<GameObject>();
            _boxes = Resources.Load("Cube") as GameObject;
            _upVector3 = Vector3.up;
            _count = 0;
        }

        public void AddBoxToPlayer(GameObject box)
        {
            _boxListObj.Add(box);
            _boxListObj[_count].transform.SetParent(_playerView.transform);
            if (_count == 0)
            {
                _boxListObj[_count].transform.position = _playerView.transform.position + Vector3.down;
                _playerView.transform.position = _boxListObj[_count].transform.position + _upVector3 * 2;
            }
            else
            {
                _boxListObj[_count].transform.position = _boxListObj[_count - 1].transform.position + Vector3.down;
                _playerView.transform.position += _upVector3;
            }

            _count++;
        }

        public void RemoveBoxes()
        {
            var box = _playerView.transform.GetChild(_playerView.transform.childCount - 1).gameObject;
            _boxListObj.Remove(box);
            _playerView.transform.position -= Vector3.up;
        }
    }
}