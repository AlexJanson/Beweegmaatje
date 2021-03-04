using System;
using System.IO;
using UnityEngine;

namespace Beweegmaatje.Core
{
    /// <summary>
    ///  Static class used for loading and saving into a PlayerData SO.
    /// </summary>
    public static class SaveSystem
    {
        private static string _SavePath = Application.persistentDataPath + "/";
        private static string _SaveSlotsFilePath = _SavePath + "Slots.json";

        /// <summary>
        ///  Saves the given data to disk.
        /// </summary>
        /// <param name="filename">Name of the file.</param>
        /// <param name="playerData">Object to save.</param>
        public static void SavePlayerData(string filename, PlayerData playerData)
        {
            string jsonData = JsonUtility.ToJson(playerData);
            File.WriteAllText(_SavePath + filename, jsonData);
        }

        /// <summary>
        ///  Loads the PlayerData from file and returns a new PlayerData instance.
        /// </summary>
        /// <param name="filename">Name of the file.</param>
        /// <returns>PlayerData containing the data at the given file.</returns>
        public static PlayerData LoadPlayerData(string filename)
        {
            var playerData = ScriptableObject.CreateInstance<PlayerData>();
            string jsonData = File.ReadAllText(_SavePath + filename);
            JsonUtility.FromJsonOverwrite(jsonData, playerData);

            return playerData;
        }

        /// <summary>
        ///  Loads the PlayerData from file and puts the data in the given PlayerData instance.
        /// </summary>
        /// <param name="filename">Name of the file.</param>
        /// <param name="playerData">Object to load the data into.</param>
        public static void LoadPlayerData(string filename, PlayerData playerData)
        {
            string jsonData = File.ReadAllText(_SavePath + filename);
            JsonUtility.FromJsonOverwrite(jsonData, playerData);
        }

        public static void LoadSlotsNames(SavesData data)
        {
            if (!File.Exists(_SaveSlotsFilePath))
            {
                SavesData saveData = ScriptableObject.CreateInstance<SavesData>();
                string emptyJsonData = JsonUtility.ToJson(saveData);
                JsonUtility.FromJsonOverwrite(emptyJsonData, data);
                return;
            }

            string jsonData = File.ReadAllText(_SaveSlotsFilePath);
            JsonUtility.FromJsonOverwrite(jsonData, data);
        }

        public static void SaveSlotsNames(SavesData data)
        {
            if (data.saveNames.Length > Utilities.SaveSlots)
            {
                Debug.LogError($"The given array is not of length { Utilities.SaveSlots }!");
                return;
            }

            string jsonData = JsonUtility.ToJson(data);
            File.WriteAllText(_SaveSlotsFilePath, jsonData);
        }

        public static void SaveSlotsNames(SavesData data, string username)
        {
            int index = Array.IndexOf(Utilities.SaveNames, Utilities.CurrentSaveFileName);
            data.saveNames[index] = username;
            SaveSlotsNames(data);
        }

        public static bool SavesExist()
        {
            foreach (string name in Utilities.SaveNames)
            {
                if (!File.Exists(_SavePath + name))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
