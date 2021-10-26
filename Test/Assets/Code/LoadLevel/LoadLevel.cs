using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.LoadLevel
{
    public class LoadLevel : MonoBehaviour
    {
        public void Restart()
        {
            Time.timeScale = 1;
        }
    }
}