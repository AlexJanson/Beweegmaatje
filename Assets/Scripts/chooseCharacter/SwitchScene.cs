using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Beweegmaatje
{
    public class SwitchScene : MonoBehaviour
    {

        [SerializeField]
        private string _nextScene;

        [SerializeField]
        private string _prevScene;

        public void ConfirmChacracter()
        {
            SceneManager.LoadScene(_nextScene);
        }

        public void PreviousScene()
        {
            SceneManager.LoadScene(_prevScene);
        }
    }
}
