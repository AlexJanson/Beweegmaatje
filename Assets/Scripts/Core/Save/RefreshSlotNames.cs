using Beweegmaatje.Events;
using UnityEngine;

namespace Beweegmaatje.Core
{
    public class RefreshSlotNames : MonoBehaviour
    {
        [SerializeField]
        VoidEvent _RefreshSlotNames;

        private void OnEnable()
        {
            _RefreshSlotNames.Raise();
        }
    }
}
