using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Beweegmaatje
{
    public class doNotDestroy : MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
