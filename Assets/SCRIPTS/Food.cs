using UnityEngine;

public class Food : MonoBehaviour
{
    void Start()
    {
        int x = Random.Range(-8, 8);
        int y = Random.Range(-4, 4);
        transform.position = new Vector3(x, y, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Snake")
        {
            PositionChange();
        }
    }

    void PositionChange()
    {
        int x = Random.Range(-8, 8);
        int y = Random.Range(-4, 4);
        transform.position = new Vector3(x, y, 0);
    }
}
