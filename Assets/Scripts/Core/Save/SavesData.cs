using System;
using UnityEngine;

namespace Beweegmaatje.Core
{
    /// <summary>
    ///  Holds the names of the save slots.
    /// </summary>
    [CreateAssetMenu(fileName = "SavesData", menuName = "Saving/Saves")]
    public class SavesData : ScriptableObject
    {
        public string[] saveNames = new string[Utilities.SaveSlots];

        private void OnValidate()
        {
            if (saveNames.Length != Utilities.SaveSlots)
            {
                Debug.LogError("Don't change the 'Save Names' field's array size!");
                Array.Resize(ref saveNames, Utilities.SaveSlots);
            }
        }
    }
}
