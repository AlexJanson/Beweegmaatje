using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Beweegmaatje.ChooseCharacter
{
    /* <summary>
        If you put this class on an object it wil not be destroyed when you load the next scene
    </summary>*/
    public class DoNotDestroy : MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
