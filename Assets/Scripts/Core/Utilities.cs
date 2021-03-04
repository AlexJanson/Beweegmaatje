namespace Beweegmaatje.Core
{
    /// <summary>
    ///  Used to store data that multiple classes need to access.
    /// </summary>
    public static class Utilities
    {
        public readonly static int SaveSlots = 3;
        public readonly static string[] SaveNames = new string[3]
        {
            "SaveOne.json",
            "SaveTwo.json",
            "SaveThree.json"
        };
        public static string CurrentSaveFileName;
    }
}
