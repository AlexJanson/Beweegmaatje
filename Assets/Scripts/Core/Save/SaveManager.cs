using Beweegmaatje.Events;
using Beweegmaatje.ChooseCharacter;
using UnityEngine;

namespace Beweegmaatje.Core
{
    /// <summary>
    ///  Loading and saving the data.
    /// </summary>
    public class SaveManager : MonoBehaviour
    {
        [SerializeField]
        PlayerData _PlayerData;
        [SerializeField]
        SavesData _SavesData;

        [SerializeField]
        VoidEvent _SlotSelected;
        [SerializeField]
        VoidEvent _RefreshSlotNames;

        [SerializeField]
        SwitchScene _SwitchScene;

        private void Awake()
        {
            SaveSystem.LoadSlotsNames(_SavesData);

            if (!SaveSystem.SavesExist())
            {
                PlayerData playerData = ScriptableObject.CreateInstance<PlayerData>();
                foreach (string name in Utilities.SaveNames)
                {
                    SaveSystem.SavePlayerData(name, playerData);
                }
            }
        }

        public void Save(string filename)
        {
            SaveSystem.LoadPlayerData(filename, _PlayerData);
            Utilities.CurrentSaveFileName = filename;
            if (string.IsNullOrEmpty(_PlayerData.username))
                _SlotSelected.Raise();
            else
                _SwitchScene.ConfirmChacracter();
        }

        public void LoadSave(string filename)
        {
            SaveSystem.LoadPlayerData(filename, _PlayerData);
        }

        public void ResetCurrentSaveFileName()
        {
            Utilities.CurrentSaveFileName = "";
        }

        public void DeleteSave(string filename)
        {
            var newPlayerData = ScriptableObject.CreateInstance<PlayerData>();
            SaveSystem.SavePlayerData(filename, newPlayerData);

            Utilities.CurrentSaveFileName = filename;
            SaveSystem.SaveSlotsNames(_SavesData, "");
            _RefreshSlotNames.Raise();
        }
    }
}