

using UnityEngine;

public class BallView:BoundElement
{
    void OnCollisionEnter()
    {
        app.Notify(BounceNotification.BallHitGround, this);

        GetComponent<Rigidbody>().AddForce(transform.up * 300);
    }
}