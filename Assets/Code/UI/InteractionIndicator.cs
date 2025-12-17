using TMPro;
using UnityEngine;

namespace Game
{
    public sealed class InteractionIndicator : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private TMP_Text _indicator;
        [Header("Values")]
        [SerializeField] private string _defaultText = "[ ]";
        [SerializeField] private string _pointedText = "[E]";

        public void Activate()
        {
            _indicator.text = _pointedText;
        }

        public void Deactivate()
        {
            _indicator.text = _defaultText;
        }
    }
}