using UnityEngine;

namespace Game
{
    public sealed class Flashlight : MonoBehaviour
    {
        [SerializeField] private Light _light;

        private bool _enabled = false;

        private void Update()
        {
            if (Time.timeScale == 0f)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                _enabled = !_enabled;
                _light.enabled = _enabled;
            }
        }
    }
}