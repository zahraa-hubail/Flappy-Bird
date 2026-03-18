using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed= 5f;
    private float leftEdfe;

    private void Start()
    {
        leftEdfe = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdfe)
        {
            Destroy(gameObject);
        }
    }
}
