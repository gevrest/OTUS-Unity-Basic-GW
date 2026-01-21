using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class NoteContent : MonoBehaviour
    {
        [SerializeField] private Button _closeButton;

        private void OnEnable()
        {
            _closeButton.onClick.AddListener(Close);
        }

        private void OnDisable()
        {
            _closeButton.onClick.RemoveListener(Close);
        }

        public void Open()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            gameObject.SetActive(true);
        }

        public void Close()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            gameObject.SetActive(false);
        }
    }
}