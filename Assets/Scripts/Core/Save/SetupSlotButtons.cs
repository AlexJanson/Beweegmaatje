using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Beweegmaatje.Core
{
    /// <summary>
    ///  Sets the text of the save slot buttons.
    /// </summary>
    public class SetupSlotButtons : MonoBehaviour
    {
        [SerializeField]
        SavesData _SavesData;
        [SerializeField]
        List<Button> _Buttons = new List<Button>();

        void Start()
        {
            ResfreshSlotNames();
        }

        public void ResfreshSlotNames()
        {
            for (int i = 0; i < _SavesData.saveNames.Length; i++)
            {
                _Buttons[i].GetComponentInChildren<TMP_Text>().text = string.IsNullOrEmpty(_SavesData.saveNames[i]) ? "Leeg" : _SavesData.saveNames[i];
            }
        }
    }
}
