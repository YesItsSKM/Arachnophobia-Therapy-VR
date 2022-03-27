using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationManager : MonoBehaviour
{

    [SerializeField] InputActionAsset inputActionAsset;
    [SerializeField] TeleportationProvider teleportationProvider;
    [SerializeField] XRRayInteractor rayInteractor;

    InputAction activateTeleportation;
    InputAction cancelTeleportation;
    InputAction thumbstick;

    bool isTeleportationActive;

    void Start()
    {
        rayInteractor.enabled = false;
        isTeleportationActive = false;

        activateTeleportation = inputActionAsset.FindActionMap("XRI LeftHand").FindAction("Teleport Mode Activate");
        activateTeleportation.Enable();
        activateTeleportation.performed += OnTeleportActivate;

        cancelTeleportation = inputActionAsset.FindActionMap("XRI LeftHand").FindAction("Teleport Mode Cancel");
        cancelTeleportation.Enable();
        cancelTeleportation.performed += OnTeleportCancel;

        thumbstick = inputActionAsset.FindActionMap("XRI LeftHand").FindAction("Move");
        thumbstick.Enable();
    }


    void Update()
    {
        if (!isTeleportationActive)
            return;

        if (thumbstick.triggered)
            return;


        if (!rayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit hit))
        {
            rayInteractor.enabled = false;
            isTeleportationActive = false;
            return;
        }

        TeleportRequest teleportRequest = new TeleportRequest()
        {
            destinationPosition = hit.point,
            destinationRotation = this.transform.rotation
        };

        teleportationProvider.QueueTeleportRequest(teleportRequest);

        rayInteractor.enabled = false;
        isTeleportationActive = false;
    }

    void OnTeleportActivate(InputAction.CallbackContext context)
    {
        rayInteractor.enabled = true;
        isTeleportationActive = true;
    }

    void OnTeleportCancel(InputAction.CallbackContext context)
    {
        rayInteractor.enabled = false;
        isTeleportationActive = false;
    }
}