using UnityEngine;

public class FakeCursor : MonoBehaviour
{
    public SpriteRenderer pawSprite;

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        // Get mouse position in world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0; 
        transform.position = mousePos;
    }
}
