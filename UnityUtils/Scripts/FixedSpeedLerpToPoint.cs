using UnityEngine;

public class FixedSpeedLerpToPoint : MonoBehaviour
{
    public float speed;
    public Vector3 position;
    private Vector3 start;
    private float distance;
    private float remainingDistance;


    private void Update()
    {
        if (remainingDistance > 0) 
        {
            transform.postion = Vector3.Lerp(start.position, position, 1 - (remainingDistance / distance));
            remainingDistance -= speed * Time.deltaTime;
        }
    }


    public void MoveToPosition(Vector3 position)
    {
        start = new Vector3(this.transform.position);
        distance = Vector3.Distance(start.position, position.position);
        remainingDistance = distance;
        this.position = position;
    }
}