using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableTwoAttach : XRGrabInteractable
{
    public Transform LeftAttachTransform;
    public Transform RightAttachTransform;
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactableObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = LeftAttachTransform;
        }
        else if (args.interactableObject.transform.CompareTag("RightHand"))
        {
            attachTransform = RightAttachTransform;
        }

        base.OnSelectEntered(args);
    }
}
