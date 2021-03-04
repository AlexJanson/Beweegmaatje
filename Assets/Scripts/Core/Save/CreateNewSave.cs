using Beweegmaatje.Events;
using UnityEngine;
using TMPro;

namespace Beweegmaatje.Core
{
    public class CreateNewSave : MonoBehaviour
    {
        [SerializeField]
        TMP_Text _UsernameInputText;
        [SerializeField]
        PlayerData _PlayerData;
        [SerializeField]
        SavesData _SaveData;

        public void Create()
        {
            _PlayerData.username = _UsernameInputText.text;
            SaveSystem.SavePlayerData(Utilities.CurrentSaveFileName, _PlayerData);
            SaveSystem.SaveSlotsNames(_SaveData, _UsernameInputText.text);
        }

        void OnDisable()
        {
            _UsernameInputText.text = "";
        }
    }
}
