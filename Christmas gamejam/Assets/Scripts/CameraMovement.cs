using UnityEngine;


public class CameraMovement : MonoBehaviour
{

    public float amplitude = 1f;


    public float frequency = 1f;


    public Vector3 movementAxis = Vector3.up;


    private Vector3 startPosition;
    private float randomOffset;

    void Start()
    {

        startPosition = transform.position;


        randomOffset = Random.Range(0f, Mathf.PI * 2f);
    }

    void Update()
    {

        float sineValue = Mathf.Sin((Time.time * frequency) + randomOffset) * amplitude;

   
        transform.position = startPosition + movementAxis.normalized * sineValue;
    }
}