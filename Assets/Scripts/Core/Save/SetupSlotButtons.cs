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
        private SavesData _SavesData;
        [SerializeField]
        private List<Button> _Buttons = new List<Button>();

        private void Start()
        {
            for (int i = 0; i < _SavesData.saveNames.Length; i++)
            {
                _Buttons[i].GetComponentInChildren<TextMeshProUGUI>().text = string.IsNullOrEmpty(_SavesData.saveNames[i]) ? "Leeg" : _SavesData.saveNames[i];
            }
        }
    }
}
