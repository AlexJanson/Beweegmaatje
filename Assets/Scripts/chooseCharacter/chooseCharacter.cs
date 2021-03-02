using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Beweegmaatje
{
    /* <summary>
     * In this class you can choose your character
    </summary>*/
    public class chooseCharacter : MonoBehaviour
    {

        public GameObject[] character;

        private int _characterNumber = 0;

        private int _characterAmount = 0;

        // Start is called before the first frame update
        void Start()
        {
          
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void NextCharacter()
        {
            character[_characterNumber].SetActive(false);
            _characterNumber++;
            if (_characterNumber >= character.Length)
            {
                _characterNumber = 0;
                character[_characterNumber].SetActive(true);
            }
            else
            {
                character[_characterNumber].SetActive(true);
            }
        }

        public void PrevCharacter()
        {
            character[_characterNumber].SetActive(false);
            _characterNumber--;
            if (_characterNumber < 0)
            {
                _characterNumber = 2;
                character[_characterNumber].SetActive(true);
            }
            else
            {
                character[_characterNumber].SetActive(true);
            }
        }

        public void ConfirmChacracter()
        {

        }
    }
}
