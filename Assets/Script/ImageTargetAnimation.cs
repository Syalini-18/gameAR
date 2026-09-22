using UnityEngine;
using Vuforia;

public class ImageTargetAnimation : MonoBehaviour
{
    public Animator objectAnimator;

    void Start()
    {
        var observerBehaviour = GetComponent<ObserverBehaviour>();
        if (observerBehaviour != null)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetFound;
        }
    }

    private void OnTargetFound(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status == Status.TRACKED || status.Status == Status.EXTENDED_TRACKED)
        {
            objectAnimator.SetBool("isDetected", true);
        }
        else
        {
            objectAnimator.SetBool("isDetected", false);
        }
    }
}
