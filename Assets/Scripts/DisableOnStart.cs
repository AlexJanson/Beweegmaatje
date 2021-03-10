using UnityEngine;

namespace Beweegmaatje
{
    public class DisableOnStart : MonoBehaviour
    {
        void Start()
        {
            gameObject.SetActive(false);
        }
    }
}
