using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabableObjectScript : MonoBehaviour
{
    public Rigidbody ownRb;
    public Transform board;
    public Transform playerPosition;
 
    public const float velocityMultiplierAtSpawn = 60f;
    private float startDistanceBoardPlayer;

    private void Start()
    {
        startDistanceBoardPlayer = Vector3.Distance(board.position, playerPosition.position);
        ownRb = GetComponent<Rigidbody>();
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectExited.AddListener(OnRelease);
    }

    public void OnRelease(SelectExitEventArgs args)
    {
        float currentDistanceFromBoard = Vector3.Distance(board.position, playerPosition.position);
        float velocityMultiplier = (currentDistanceFromBoard / startDistanceBoardPlayer) * velocityMultiplierAtSpawn;

        ownRb.AddForce(args.interactor.transform.forward.normalized * velocityMultiplier);
    }
}
