using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Beweegmaatje
{
    public class buttonTimer : MonoBehaviour
    {

        [SerializeField]
        private Button _continueButton;

        [SerializeField]
        private Text _timeText;

        [SerializeField]
        private float _timer;

        private float _savedTime;

        // Start is called before the first frame update
        void Start()
        {
            _savedTime = _timer;
        }

        private void OnEnable()
        {
            _continueButton.interactable = false;
            _timeText.enabled = true;
            StartCoroutine(CountDownToStart());
        }

        // Update is called once per frame
        void Update()
        {

            if(_timer <= 0)
            {
                _continueButton.interactable = true;
                _timeText.enabled = false;
            }
        }

        public void continueButtonPressed()
        {
            _timer = _savedTime;
            gameObject.SetActive(false);
        }

        IEnumerator CountDownToStart()
        {
            while(_timer > 0)
            {
                _timeText.text = _timer.ToString();

                yield return new WaitForSeconds(1f);

                _timer--;
            }
        }
    }
}
