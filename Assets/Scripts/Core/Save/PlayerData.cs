using UnityEngine;

namespace Beweegmaatje.Core
{
    /// <summary>
    ///  Holds the current players save data.
    /// </summary>
    [CreateAssetMenu(fileName = "PlayerData", menuName = "Saving/Player")]
    public class PlayerData : ScriptableObject
    {
        public string username;
    }
}
