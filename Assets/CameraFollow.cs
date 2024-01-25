using Unity.Mathematics;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smothing;

    public Vector2 maxPose;
    public Vector2 minPose;

    private void FixedUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPos = new Vector3(target.position.x,target.position.y,transform.position.z);
            /*
            targetPos.x = math.clamp(targetPos.x,minPose.x,maxPose.x);
            targetPos.y = math.clamp(targetPos.y,minPose.y,maxPose.y);
            */
            transform.position = Vector3.Lerp(transform.position, targetPos, smothing); 
        }
    }
}
