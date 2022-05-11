using UnityEngine;
public class ScreenShakeController : MonoBehaviour
{
    private float timeRemaining;
    private float power;

    private void LateUpdate()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            float x = Random.Range(-1f, 1f) * power;
            float y = Random.Range(-1f, 1f) * power;

            transform.position += new Vector3(x, y, 0);
        }
    }

	//Call this function from anywhere to shake the screen
    public void StartShake(float length, float power)
    {
        timeRemaining = length;
        power = power;
    }
}
