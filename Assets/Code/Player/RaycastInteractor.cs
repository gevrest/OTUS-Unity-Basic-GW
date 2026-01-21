using UnityEngine;

namespace Game
{
    public sealed class RaycastInteractor : MonoBehaviour
    {
        [SerializeField] private Transform _rayPoint;
        [SerializeField] private float _maxDistance = 2f;

        private InteractionIndicator _interactionIndicator;

        private void Start()
        {
            _interactionIndicator = FindAnyObjectByType<InteractionIndicator>();
            _interactionIndicator.Deactivate();
        }

        private void Update()
        {
            if (Physics.Raycast(_rayPoint.position, _rayPoint.forward, out var hitInfo, _maxDistance) && hitInfo.collider.TryGetComponent(out InteractableObject interactableObject))
            {
                _interactionIndicator.Activate();

                if (Input.GetKeyDown(KeyCode.E))
                    interactableObject.Interact();
            }
            else
            {
                _interactionIndicator.Deactivate();
            }
        }
    }
}