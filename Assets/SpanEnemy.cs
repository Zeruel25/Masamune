
using UnityEngine;

public class SpanEnemy : MonoBehaviour
{
   public Transform tr;
   public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void LateUpate() {
0        transform.position = tr.position + offset;
    }

}
