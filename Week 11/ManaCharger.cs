using UnityEngine;
using UnityEngine.InputSystem;

public class ManaCharger : MonoBehaviour

{
    public RectTransform manaBarRect;
    public float maxWidth = 400f;
    public float chargeSpeed = 250f;
    public float retractSpeed = 500f;

    private float currentWidth = 0f;

    void Update()
    {
    if (Keyboard.current == null) return;

    if (Keyboard.current.xKey.isPressed)
    {
        currentWidth += chargeSpeed * Time.deltaTime;
        currentWidth = Mathf.Clamp(currentWidth, 0f, maxWidth);

    }
    else
    {
        currentWidth -= retractSpeed * Time.deltaTime;
        currentWidth = Mathf.Max(currentWidth, 0f);
        
    }
    
    if (manaBarRect != null)
    {
        Vector2 size = manaBarRect.sizeDelta;
        size.x = currentWidth;
        manaBarRect.sizeDelta = size;
    }


}

}
