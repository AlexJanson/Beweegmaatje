using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Beweegmaatje.ChooseCharacter
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

        private Renderer _renderer;

        // Start is called before the first frame update
        void Start()
        {
            _renderer = _character.GetComponent<Renderer>();
        }

        public void NextCharacter()
        {
            _colorNumber++;
            if (_colorNumber >= characterColor.Length)
            {
                _colorNumber = 0;
                _renderer.material = characterColor[_colorNumber];

            }
            else
            {
                _renderer.material = characterColor[_colorNumber];
            }
        }

        public void PrevCharacter()
        {
            _colorNumber--;
            if (_colorNumber < 0)
            {
                _colorNumber = characterColor.Length - 1;
                _renderer.material = characterColor[_colorNumber];
            }
            else
            {
                _renderer.material = characterColor[_colorNumber];
            }
        }
    }
}
