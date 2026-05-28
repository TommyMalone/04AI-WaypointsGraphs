using UnityEngine;

public class Waypoint : MonoBehaviour
{
    private void OnValidate()
    {
        GetComponent<TextMesh>().text = gameObject.transform.parent.gameObject.name;
    }
}
