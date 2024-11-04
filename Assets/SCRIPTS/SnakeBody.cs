using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SnakeBody : MonoBehaviour
{
    [SerializeField] GameObject Target;
    InGameScoreManager InGameScoreManager;
    int OwnName;
    int TargetName;
    void Start()
    {
        InGameScoreManager = FindObjectOfType<InGameScoreManager>();
        OwnName = InGameScoreManager.Score;
        transform.name = OwnName.ToString();
        TargetName = OwnName - 1;
        Target = GameObject.Find(TargetName.ToString());
    }

    void Update()
    {
        Vector3 direction = Target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        transform.position= Vector2.Lerp(transform.position,Target.transform.position,Time.deltaTime*7);
    }
}
