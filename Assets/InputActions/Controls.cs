// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""9f55990d-ac91-4263-91e3-c4414b547780"",
            ""actions"": [
                {
                    ""name"": ""binding A"",
                    ""type"": ""Button"",
                    ""id"": ""14778d88-0906-43a7-aebf-c7132f495a73"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""binding Z"",
                    ""type"": ""Button"",
                    ""id"": ""1a96a07b-a60e-49cb-bf4d-3d109fb5f96a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""binding E"",
                    ""type"": ""Button"",
                    ""id"": ""246c49ff-625e-46c3-8861-ddc60be25ea5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""binding R"",
                    ""type"": ""Button"",
                    ""id"": ""eebfb700-8241-4550-bb49-833a2202d362"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""bank"",
                    ""type"": ""Button"",
                    ""id"": ""f270436b-b88e-4a48-bf28-f87775a7f860"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe739bd3-5182-411c-9366-34fcbbf507a9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""binding A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc593a0d-8e42-48e9-8ddb-4cbd7dfa6d6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""binding Z"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a3c71b5-2157-4472-8c5a-08ac67ae3ac8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""binding E"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1faad4d5-94d1-41dc-9c1d-d8105bae0349"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""binding R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfe29413-b2e9-4da5-a6d6-81a165d7df1b"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""bank"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_bindingA = m_Player.FindAction("binding A", throwIfNotFound: true);
        m_Player_bindingZ = m_Player.FindAction("binding Z", throwIfNotFound: true);
        m_Player_bindingE = m_Player.FindAction("binding E", throwIfNotFound: true);
        m_Player_bindingR = m_Player.FindAction("binding R", throwIfNotFound: true);
        m_Player_bank = m_Player.FindAction("bank", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_bindingA;
    private readonly InputAction m_Player_bindingZ;
    private readonly InputAction m_Player_bindingE;
    private readonly InputAction m_Player_bindingR;
    private readonly InputAction m_Player_bank;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @bindingA => m_Wrapper.m_Player_bindingA;
        public InputAction @bindingZ => m_Wrapper.m_Player_bindingZ;
        public InputAction @bindingE => m_Wrapper.m_Player_bindingE;
        public InputAction @bindingR => m_Wrapper.m_Player_bindingR;
        public InputAction @bank => m_Wrapper.m_Player_bank;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @bindingA.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingA;
                @bindingA.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingA;
                @bindingA.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingA;
                @bindingZ.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingZ;
                @bindingZ.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingZ;
                @bindingZ.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingZ;
                @bindingE.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingE;
                @bindingE.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingE;
                @bindingE.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingE;
                @bindingR.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingR;
                @bindingR.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingR;
                @bindingR.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBindingR;
                @bank.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBank;
                @bank.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBank;
                @bank.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBank;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @bindingA.started += instance.OnBindingA;
                @bindingA.performed += instance.OnBindingA;
                @bindingA.canceled += instance.OnBindingA;
                @bindingZ.started += instance.OnBindingZ;
                @bindingZ.performed += instance.OnBindingZ;
                @bindingZ.canceled += instance.OnBindingZ;
                @bindingE.started += instance.OnBindingE;
                @bindingE.performed += instance.OnBindingE;
                @bindingE.canceled += instance.OnBindingE;
                @bindingR.started += instance.OnBindingR;
                @bindingR.performed += instance.OnBindingR;
                @bindingR.canceled += instance.OnBindingR;
                @bank.started += instance.OnBank;
                @bank.performed += instance.OnBank;
                @bank.canceled += instance.OnBank;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnBindingA(InputAction.CallbackContext context);
        void OnBindingZ(InputAction.CallbackContext context);
        void OnBindingE(InputAction.CallbackContext context);
        void OnBindingR(InputAction.CallbackContext context);
        void OnBank(InputAction.CallbackContext context);
    }
}
