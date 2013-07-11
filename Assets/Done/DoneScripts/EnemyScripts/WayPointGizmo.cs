using UnityEngine;
using System.Collections;

public class WayPointGizmo : MonoBehaviour {

    void OnDrawGizmos() {
        Gizmos.DrawIcon(transform.position, "wayPoint.png", true);
    }
}
