using UnityEngine; 
using UnityEngine.InputSystem;
using UnityEngine.UI; 



public class InputManager : MonoBehaviour
{
    public Text myText;
    private TouchControls touchControls;
    private void Awake() {
        touchControls = new TouchControls();   
    }
    private void OnEnable() {
        touchControls.Enable();
    }
    private void OnDisable() {
        touchControls.Disable();
    }
    private void Start() {
        touchControls.Touch.TouchPress.started += ctx => StartTouch(ctx);
        touchControls.Touch.TouchPress.canceled += ctx => EndTouch(ctx);
    }
    private void StartTouch(InputAction.CallbackContext context){
        Debug.Log("Touch started : " + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
        myText.text = "Touch started : " + touchControls.Touch.TouchPosition.ReadValue<Vector2>();
    }
    private void EndTouch(InputAction.CallbackContext context){
        Debug.Log("Touch ended : " + touchControls.Touch.TouchPosition.ReadValue<Vector2>());
        myText.text = "Touch ended : " + touchControls.Touch.TouchPosition.ReadValue<Vector2>();
    }
}
