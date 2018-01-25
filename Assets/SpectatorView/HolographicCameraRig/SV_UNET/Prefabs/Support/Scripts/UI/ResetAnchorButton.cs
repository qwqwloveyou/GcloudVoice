// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.SharingWithUNET;
using UnityEngine;

namespace SpectatorView
{
    public class ResetAnchorButton : MonoBehaviour, IInputClickHandler
    {

        public void OnInputClicked(InputClickedEventData eventData)
        {
            if (NetworkDiscoveryWithAnchors.Instance.isServer)
            {
#if UNITY_WSA
                UNetAnchorManager.Instance.MakeNewAnchor();
#endif
            }
            else
            {
                Debug.Log("Only the server for now");
            }
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
