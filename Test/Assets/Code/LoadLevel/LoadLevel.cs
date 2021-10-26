using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.LoadLevel
{
    public class LoadLevel : MonoBehaviour
    {
        private void OnGUI()
        {
            if (GUI.RepeatButton(new Rect(25, 25, 100, 30), "Start")) Application.LoadLevel(0);
        }
    }
}