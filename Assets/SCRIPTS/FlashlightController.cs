using UnityEngine;

namespace KrishnamohanYagneswaran
{
    public class FlashlightController : MonoBehaviour
    {
        public Light flashlight;
        public KeyCode toggleKey = KeyCode.F;

        void Update()
        {
            if (Input.GetKeyDown(toggleKey))
            {
                flashlight.enabled = !flashlight.enabled;
            }
        }
    }
}
