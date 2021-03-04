using UnityEngine;

namespace Beweegmaatje.Core
{
    /// <summary>
    ///  Loading and saving the data.
    /// </summary>
    public class SaveManager : MonoBehaviour
    {
        [SerializeField]
        private PlayerData _PlayerData;
        [SerializeField]
        private SavesData _SavesData;

        private void Awake()
        {
            SaveSystem.LoadSlotsNames(_SavesData);
        }

        public void Save(string filename)
        {
            SaveSystem.LoadPlayerData(filename, _PlayerData);
        }

        public void LoadSave(string filename)
        {
            SaveSystem.LoadPlayerData(filename, _PlayerData);
        }
    }
}
