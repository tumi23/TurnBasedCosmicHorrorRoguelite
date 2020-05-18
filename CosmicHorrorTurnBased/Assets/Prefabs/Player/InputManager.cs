using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public InputActions inputActions;
    private bool bMovementHeldDown = false;
    private Vector2 movementVector = new Vector2();

    public void Awake()
    {
        inputActions = new InputActions();
        inputActions.WorldMapCamera.Movement.performed += MovementPerformed;
        inputActions.WorldMapCamera.Selection.performed += MouseClick;
    }

    private void OnEnable()
    {
        
        inputActions.WorldMapCamera.Movement.Enable();
        inputActions.WorldMapCamera.Selection.Enable();
    }

    private void OnDisable()
    {
        inputActions.WorldMapCamera.Movement.Disable();
        inputActions.WorldMapCamera.Selection.Disable();
    }

    private void MouseClick(InputAction.CallbackContext obj)
    {
        Debug.Log("mouse click");
        Vector3 location;
        Camera.main.ScreenToWorldPoint(Mouse.current.position);
        RaycastHit outHit = new RaycastHit();
        Ray newRay = Camera.main.ScreenPointToRay();
        newRay.origin = Camera.main.transform.position;
        
        newRay.direction = (Mouse.current - Camera.main.transform.position).normalized;
        Debug.DrawRay(newRay.origin, newRay.direction);
        bool hit = Physics.Raycast(newRay, out outHit);
        Debug.Log("Hit " + outHit.transform.gameObject.name);
        /*InteractableBase hitObject = outHit.collider.gameObject.GetComponent<InteractableBase>();
        if (hitObject)
        {
            hitObject.Activate();
        }*/
    }

    private void MovementPerformed(InputAction.CallbackContext obj)
    {
        bMovementHeldDown = !bMovementHeldDown;
        movementVector = obj.ReadValue<Vector2>();
    }

    public void FixedUpdate()
    {
        if(bMovementHeldDown)
        {
            transform.position += new Vector3(movementVector.x * Time.deltaTime, movementVector.y * Time.deltaTime, 0);
        }
    }
}
