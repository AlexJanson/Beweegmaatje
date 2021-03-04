using UnityEditor;

namespace Beweegmaatje.Core
{
    [CustomEditor(typeof(SavesData))]
    public class SavesDataWarning : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            EditorGUILayout.HelpBox("Please don't change the size of the Save Names array from in the inspector!", MessageType.Warning);
        }
    }
}
