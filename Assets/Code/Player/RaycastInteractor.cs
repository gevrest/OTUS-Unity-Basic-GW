using UnityEngine;

namespace Game
{
    public sealed class RaycastInteractor : MonoBehaviour
    {
        [SerializeField] private Transform _rayPoint;

        private InteractionIndicator _interactionIndicator;

        private void Start()
        {
            _interactionIndicator = FindAnyObjectByType<InteractionIndicator>();
        }

        private void Update()
        {
            if (Physics.Raycast(_rayPoint.position, _rayPoint.forward, out var hitInfo))
            {
                if (hitInfo.collider.TryGetComponent(out InteractableObject interactableObject))
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
}