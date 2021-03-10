using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Beweegmaatje
{
    /* <summary>
     * In this class you can choose your character
    </summary>*/
    public class chooseCharacter : MonoBehaviour
    {

        public GameObject character;

        public Material[] characterColor;

        private int _characterNumber = 0;

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
            //character[_characterNumber].SetActive(false);
            _characterNumber++;
            if (_characterNumber >= characterColor.Length)
            {
                _characterNumber = 0;
                //character[_characterNumber].SetActive(true);
                character.GetComponent<Renderer>().material = characterColor[_characterNumber];

            }
            else
            {
                //character[_characterNumber].SetActive(true);
                character.GetComponent<Renderer>().material = characterColor[_characterNumber];
            }
        }

        public void PrevCharacter()
        {
            //character[_characterNumber].SetActive(false);
            _characterNumber--;
            if (_characterNumber < 0)
            {
                _characterNumber = characterColor.Length - 1;
                //character[_characterNumber].SetActive(true);
                character.GetComponent<Renderer>().material = characterColor[_characterNumber];
            }
            else
            {
                //character[_characterNumber].SetActive(true);
                character.GetComponent<Renderer>().material = characterColor[_characterNumber];
            }
        }

        public void ConfirmChacracter()
        {
            SceneManager.LoadScene("CharacterTestScene");
        }
    }
}
