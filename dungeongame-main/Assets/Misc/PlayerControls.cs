//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Misc/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player Movement"",
            ""id"": ""1b90b33d-fcfe-46e1-b2f1-7b2e49b0c648"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""46f6c9d0-85e3-46b7-81b7-e9bda5a81b6c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d32f4e12-d4aa-48c4-95fd-613b3db761fe"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lock On Left"",
                    ""type"": ""Button"",
                    ""id"": ""ced42587-735b-4397-a37a-9f483ee5db89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lock On Right"",
                    ""type"": ""Button"",
                    ""id"": ""03eeffd4-ea53-4960-887e-7280bf775244"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""43f3a27d-e26b-40d9-ac54-940fe5f35518"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""49fc2462-62af-4a70-8752-159de050fc7b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c665b1bf-e5f1-4df6-93f9-214792f17889"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6c6f8a45-d0e6-4745-bcbe-e569c9f8bb5f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6bad5d44-de23-4771-a7a3-5b51339e161b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1467874f-a98b-4908-8d69-f8ae4a33d997"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e88eb480-1ba7-4fa9-ba21-a4700c20ded5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d21eb175-54c4-41b0-8357-0c7c744758b4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f30a8471-02bc-436b-8dff-cd1e8d849fb8"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": ""Tap(duration=0.2,pressPoint=1)"",
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Lock On Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afe8b614-eeba-4073-a067-d578aaf5e1da"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock On Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""040d2dd0-5b59-4d69-9bc1-840e10bda01a"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": ""Tap(duration=0.2,pressPoint=1)"",
                    ""processors"": ""AxisDeadzone(min=0.1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Lock On Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bef64bc-c2a7-497f-8c88-a9f80ffdb764"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lock On Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""7355a14d-e326-460d-9a47-2f2b3294234a"",
            ""actions"": [
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""3045d378-4764-4a97-b2f3-7b40d911a6b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""bac8301c-13ad-4c58-ad44-dda9b469ca5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RB"",
                    ""type"": ""Button"",
                    ""id"": ""62b9e223-eaa9-4813-a272-99c7a07c1f38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RT"",
                    ""type"": ""Button"",
                    ""id"": ""593f9bc3-c6a5-42f6-8592-ec30417f35b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""61da32c6-89e5-4eb0-9962-55bbe76b9fd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""325e7ccd-03a9-4252-8e4a-af45641ca8a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LockOn"",
                    ""type"": ""Button"",
                    ""id"": ""c35ca7cb-ac13-4cd3-8eb6-779b26cd24fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""05d0d87c-5d13-4ad7-9329-d5c21354985f"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""066685f9-433a-4584-8fec-0152960c1d2b"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e522b289-8d9f-4d40-869d-684afa14d51f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66bb8711-9351-4276-a531-36b945da4885"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2dc576c-bd07-4a99-a7cf-dbf6d82b535c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4dcbf158-f364-4246-be17-9718ada60e31"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fab73063-659d-4e02-9de3-4e00684cb283"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ec1e15d-2702-4eaa-b492-09ae798297f0"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""087ac6df-063f-45cb-9423-5588df96bc8d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f77db8a-7b47-4d84-8cc2-2f89c7181d0f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b438e8fb-1bdf-472f-8321-b6e303d87981"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5700e1f0-b20c-49b3-8b16-19d88bb69d10"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1a7da36-af1e-4974-88a3-f20e12be4bdf"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b1c6f89-bd24-470f-8af6-24b9059fcb24"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Quick Slots"",
            ""id"": ""602c6d35-69ec-41d9-b4af-10d082aa3651"",
            ""actions"": [
                {
                    ""name"": ""D-Pad Right"",
                    ""type"": ""Button"",
                    ""id"": ""27d55b1f-fbac-4cb0-874a-534688de2742"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""D-Pad Left"",
                    ""type"": ""Button"",
                    ""id"": ""bf78de01-f27e-4975-8f1a-6f549a12e01e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""D-Pad Down"",
                    ""type"": ""Button"",
                    ""id"": ""5d368a85-033a-456b-9f41-5dcdfdadeda1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""D-Pad Up"",
                    ""type"": ""Button"",
                    ""id"": ""c7f49b50-3353-4cc1-b8ff-d8287f3a30ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09643e95-5650-4db0-bf22-87b9ed6f184e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ccb933a-f7ed-4dcc-adb4-2ce4aa968dff"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ffc5f7e-2150-4fd9-ab8b-b7aff67b987a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39be79f7-ee7a-4ce0-80fa-a609f64112b9"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7e1ff0a-dc63-4d3c-8f1c-4c995638a4a3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdf31492-38c1-4ac9-a084-4639a34bde86"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d0b9685-3bdb-455e-a301-4c61e2117ad0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee748388-0bdc-4c45-8a2c-345c1c17fdc3"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-Pad Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Camera = m_PlayerMovement.FindAction("Camera", throwIfNotFound: true);
        m_PlayerMovement_LockOnLeft = m_PlayerMovement.FindAction("Lock On Left", throwIfNotFound: true);
        m_PlayerMovement_LockOnRight = m_PlayerMovement.FindAction("Lock On Right", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_Roll = m_PlayerActions.FindAction("Roll", throwIfNotFound: true);
        m_PlayerActions_Interact = m_PlayerActions.FindAction("Interact", throwIfNotFound: true);
        m_PlayerActions_RB = m_PlayerActions.FindAction("RB", throwIfNotFound: true);
        m_PlayerActions_RT = m_PlayerActions.FindAction("RT", throwIfNotFound: true);
        m_PlayerActions_Jump = m_PlayerActions.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActions_Inventory = m_PlayerActions.FindAction("Inventory", throwIfNotFound: true);
        m_PlayerActions_LockOn = m_PlayerActions.FindAction("LockOn", throwIfNotFound: true);
        // Player Quick Slots
        m_PlayerQuickSlots = asset.FindActionMap("Player Quick Slots", throwIfNotFound: true);
        m_PlayerQuickSlots_DPadRight = m_PlayerQuickSlots.FindAction("D-Pad Right", throwIfNotFound: true);
        m_PlayerQuickSlots_DPadLeft = m_PlayerQuickSlots.FindAction("D-Pad Left", throwIfNotFound: true);
        m_PlayerQuickSlots_DPadDown = m_PlayerQuickSlots.FindAction("D-Pad Down", throwIfNotFound: true);
        m_PlayerQuickSlots_DPadUp = m_PlayerQuickSlots.FindAction("D-Pad Up", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Camera;
    private readonly InputAction m_PlayerMovement_LockOnLeft;
    private readonly InputAction m_PlayerMovement_LockOnRight;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovement_Camera;
        public InputAction @LockOnLeft => m_Wrapper.m_PlayerMovement_LockOnLeft;
        public InputAction @LockOnRight => m_Wrapper.m_PlayerMovement_LockOnRight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @LockOnLeft.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnLeft;
                @LockOnLeft.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnLeft;
                @LockOnLeft.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnLeft;
                @LockOnRight.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnRight;
                @LockOnRight.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnRight;
                @LockOnRight.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLockOnRight;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @LockOnLeft.started += instance.OnLockOnLeft;
                @LockOnLeft.performed += instance.OnLockOnLeft;
                @LockOnLeft.canceled += instance.OnLockOnLeft;
                @LockOnRight.started += instance.OnLockOnRight;
                @LockOnRight.performed += instance.OnLockOnRight;
                @LockOnRight.canceled += instance.OnLockOnRight;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Roll;
    private readonly InputAction m_PlayerActions_Interact;
    private readonly InputAction m_PlayerActions_RB;
    private readonly InputAction m_PlayerActions_RT;
    private readonly InputAction m_PlayerActions_Jump;
    private readonly InputAction m_PlayerActions_Inventory;
    private readonly InputAction m_PlayerActions_LockOn;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Roll => m_Wrapper.m_PlayerActions_Roll;
        public InputAction @Interact => m_Wrapper.m_PlayerActions_Interact;
        public InputAction @RB => m_Wrapper.m_PlayerActions_RB;
        public InputAction @RT => m_Wrapper.m_PlayerActions_RT;
        public InputAction @Jump => m_Wrapper.m_PlayerActions_Jump;
        public InputAction @Inventory => m_Wrapper.m_PlayerActions_Inventory;
        public InputAction @LockOn => m_Wrapper.m_PlayerActions_LockOn;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Roll.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Interact.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @RB.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RB.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RB.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RT.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRT;
                @RT.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRT;
                @RT.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRT;
                @Jump.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Inventory.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInventory;
                @LockOn.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLockOn;
                @LockOn.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLockOn;
                @LockOn.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnLockOn;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @RB.started += instance.OnRB;
                @RB.performed += instance.OnRB;
                @RB.canceled += instance.OnRB;
                @RT.started += instance.OnRT;
                @RT.performed += instance.OnRT;
                @RT.canceled += instance.OnRT;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @LockOn.started += instance.OnLockOn;
                @LockOn.performed += instance.OnLockOn;
                @LockOn.canceled += instance.OnLockOn;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // Player Quick Slots
    private readonly InputActionMap m_PlayerQuickSlots;
    private IPlayerQuickSlotsActions m_PlayerQuickSlotsActionsCallbackInterface;
    private readonly InputAction m_PlayerQuickSlots_DPadRight;
    private readonly InputAction m_PlayerQuickSlots_DPadLeft;
    private readonly InputAction m_PlayerQuickSlots_DPadDown;
    private readonly InputAction m_PlayerQuickSlots_DPadUp;
    public struct PlayerQuickSlotsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerQuickSlotsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @DPadRight => m_Wrapper.m_PlayerQuickSlots_DPadRight;
        public InputAction @DPadLeft => m_Wrapper.m_PlayerQuickSlots_DPadLeft;
        public InputAction @DPadDown => m_Wrapper.m_PlayerQuickSlots_DPadDown;
        public InputAction @DPadUp => m_Wrapper.m_PlayerQuickSlots_DPadUp;
        public InputActionMap Get() { return m_Wrapper.m_PlayerQuickSlots; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerQuickSlotsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerQuickSlotsActions instance)
        {
            if (m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface != null)
            {
                @DPadRight.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadRight;
                @DPadRight.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadRight;
                @DPadRight.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadRight;
                @DPadLeft.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadLeft;
                @DPadDown.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadDown;
                @DPadDown.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadDown;
                @DPadDown.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadDown;
                @DPadUp.started -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadUp;
                @DPadUp.performed -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadUp;
                @DPadUp.canceled -= m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface.OnDPadUp;
            }
            m_Wrapper.m_PlayerQuickSlotsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @DPadRight.started += instance.OnDPadRight;
                @DPadRight.performed += instance.OnDPadRight;
                @DPadRight.canceled += instance.OnDPadRight;
                @DPadLeft.started += instance.OnDPadLeft;
                @DPadLeft.performed += instance.OnDPadLeft;
                @DPadLeft.canceled += instance.OnDPadLeft;
                @DPadDown.started += instance.OnDPadDown;
                @DPadDown.performed += instance.OnDPadDown;
                @DPadDown.canceled += instance.OnDPadDown;
                @DPadUp.started += instance.OnDPadUp;
                @DPadUp.performed += instance.OnDPadUp;
                @DPadUp.canceled += instance.OnDPadUp;
            }
        }
    }
    public PlayerQuickSlotsActions @PlayerQuickSlots => new PlayerQuickSlotsActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnLockOnLeft(InputAction.CallbackContext context);
        void OnLockOnRight(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnRoll(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnRB(InputAction.CallbackContext context);
        void OnRT(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnLockOn(InputAction.CallbackContext context);
    }
    public interface IPlayerQuickSlotsActions
    {
        void OnDPadRight(InputAction.CallbackContext context);
        void OnDPadLeft(InputAction.CallbackContext context);
        void OnDPadDown(InputAction.CallbackContext context);
        void OnDPadUp(InputAction.CallbackContext context);
    }
}
