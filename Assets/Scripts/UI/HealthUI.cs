using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Beweegmaatje.Events;
using Beweegmaatje.Variables;
using UnityEngine.UI;

namespace Beweegmaatje.UI
{
    [RequireComponent(typeof(Text))]
    public class HealthUI : MonoBehaviour
    {
        public FloatVariable HP;

        private Text _text;

        void Awake()
        {
            _text = GetComponent<Text>();
        }

        public void GameOver()
        {
            _text.text = "GAME OVER!";
        }

        void Update()
        {
            if(HP.Value > 0.0f)
                _text.text = HP.Value.ToString();
        }
    }
}
