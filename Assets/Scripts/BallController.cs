using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    public InputActionReference inputMovimiento;
    public Vector2 direccionMovimiento2D;
    public Vector2 direccionMovimiento3D;

    // Start is called before the first frame update
    void Start()
    {
        direccionMovimiento2D = new Vector2();
        direccionMovimiento3D = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        direccionMovimiento2D = inputMovimiento.action.ReadValue<Vector2>();
        direccionMovimiento3D = direccionMovimiento2D;
    }

    // public vector3 ReorganmizaVector2(Vector2 vector2){
    //     Vector3 newVector = new Vector3(vector2.x, 0f, 1);

    // }
}
