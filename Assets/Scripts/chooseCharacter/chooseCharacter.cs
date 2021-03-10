using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Beweegmaatje
{
    /* <summary>
     * In this class you can choose your character
    </summary>*/
    public class ChooseCharacter : MonoBehaviour
    {

        [SerializeField]
        private GameObject _character;

        public Material[] characterColor;

        private int _colorNumber = 0;

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
            _colorNumber++;
            if (_colorNumber >= characterColor.Length)
            {
                _colorNumber = 0;
                _character.GetComponent<Renderer>().material = characterColor[_colorNumber];

            }
            else
            {
                _character.GetComponent<Renderer>().material = characterColor[_colorNumber];
            }
        }

        public void PrevCharacter()
        {
            _colorNumber--;
            if (_colorNumber < 0)
            {
                _colorNumber = characterColor.Length - 1;
                _character.GetComponent<Renderer>().material = characterColor[_colorNumber];
            }
            else
            {
                _character.GetComponent<Renderer>().material = characterColor[_colorNumber];
            }
        }
    }
}
