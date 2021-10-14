using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ColliderType{
    ABOVE,
    BELOW
}

public class HoopColliderScript : MonoBehaviour
{
    public static System.Action scoreActionEvent;

    private static bool hitFirstCollider;
    private static float timeUntilColliderReset;

    public ColliderType colliderType;

    // Start is called before the first frame update
    void Start()
    {
        hitFirstCollider = false;
        timeUntilColliderReset = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hitFirstCollider && colliderType == ColliderType.ABOVE)
        {
            hitFirstCollider = true;
            return;
        }

        if(hitFirstCollider && colliderType == ColliderType.BELOW)
        {
            hitFirstCollider = false;
            scoreActionEvent.Invoke();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilColliderReset += Time.deltaTime;
        if(timeUntilColliderReset > 2)
        {
            hitFirstCollider = false;
            timeUntilColliderReset = 0;
        }
    }
}
