// GENERATED AUTOMATICALLY FROM 'Assets/Core/Inputs/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""WorldMapCamera"",
            ""id"": ""39fd76c7-1252-49da-8e94-df048a2d4cbd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""8d87082c-fe7a-4ef2-90f3-2818596134d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Selection"",
                    ""type"": ""Value"",
                    ""id"": ""26f1547d-86e0-4971-815d-7e72ce4fc02d"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""79fc8901-4aca-468c-9811-e8e83aea200e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c43d698-7f23-43e2-a102-dfe55f779afe"",
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
                    ""id"": ""33839f70-b637-4b91-8471-ba608600bc39"",
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
                    ""id"": ""13d11d69-2e62-4241-9593-286ab84e9fd0"",
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
                    ""id"": ""7a0e782e-84d1-4af0-87d7-dd7406c64182"",
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
                    ""id"": ""a6d2d65f-b6e7-4254-b412-bc6e14e59038"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Selection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // WorldMapCamera
        m_WorldMapCamera = asset.FindActionMap("WorldMapCamera", throwIfNotFound: true);
        m_WorldMapCamera_Movement = m_WorldMapCamera.FindAction("Movement", throwIfNotFound: true);
        m_WorldMapCamera_Selection = m_WorldMapCamera.FindAction("Selection", throwIfNotFound: true);
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

    // WorldMapCamera
    private readonly InputActionMap m_WorldMapCamera;
    private IWorldMapCameraActions m_WorldMapCameraActionsCallbackInterface;
    private readonly InputAction m_WorldMapCamera_Movement;
    private readonly InputAction m_WorldMapCamera_Selection;
    public struct WorldMapCameraActions
    {
        private @InputActions m_Wrapper;
        public WorldMapCameraActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_WorldMapCamera_Movement;
        public InputAction @Selection => m_Wrapper.m_WorldMapCamera_Selection;
        public InputActionMap Get() { return m_Wrapper.m_WorldMapCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WorldMapCameraActions set) { return set.Get(); }
        public void SetCallbacks(IWorldMapCameraActions instance)
        {
            if (m_Wrapper.m_WorldMapCameraActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_WorldMapCameraActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_WorldMapCameraActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_WorldMapCameraActionsCallbackInterface.OnMovement;
                @Selection.started -= m_Wrapper.m_WorldMapCameraActionsCallbackInterface.OnSelection;
                @Selection.performed -= m_Wrapper.m_WorldMapCameraActionsCallbackInterface.OnSelection;
                @Selection.canceled -= m_Wrapper.m_WorldMapCameraActionsCallbackInterface.OnSelection;
            }
            m_Wrapper.m_WorldMapCameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Selection.started += instance.OnSelection;
                @Selection.performed += instance.OnSelection;
                @Selection.canceled += instance.OnSelection;
            }
        }
    }
    public WorldMapCameraActions @WorldMapCamera => new WorldMapCameraActions(this);
    public interface IWorldMapCameraActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSelection(InputAction.CallbackContext context);
    }
}
