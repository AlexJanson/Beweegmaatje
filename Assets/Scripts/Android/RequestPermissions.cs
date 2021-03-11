using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

namespace Beweegmaatje
{
    /// <summary>
    /// Requests "Physical Activity" permission to be able to use the stepcounter
    /// </summary>
    public class RequestPermissions : MonoBehaviour
    {
        // Will break if removed
        GameObject dialog = null;

        // Start is called before the first frame update
        void Start()
        {
#if PLATFORM_ANDROID
            // Check if the permission is already granted
            if (!Permission.HasUserAuthorizedPermission("android.permission.ACTIVITY_RECOGNITION"))
            {
                // Ask for permission
                Permission.RequestUserPermission("android.permission.ACTIVITY_RECOGNITION");
            }
#endif
        }
    }
}
