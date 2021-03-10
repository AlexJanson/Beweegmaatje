using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

namespace Beweegmaatje
{
    public class RequestPermissions : MonoBehaviour
    {

        GameObject dialog = null;
        // Start is called before the first frame update
        void Start()
        {
#if PLATFORM_ANDROID
            if (!Permission.HasUserAuthorizedPermission("android.permission.ACTIVITY_RECOGNITION"))
            {
                Permission.RequestUserPermission("android.permission.ACTIVITY_RECOGNITION");
            }
#endif
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
