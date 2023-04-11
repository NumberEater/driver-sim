using UnityEngine;

public class InputLogger : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;

    float rightHorizontal;
    float rightVertical;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        rightVertical = Input.GetAxisRaw("Mouse Y");
        rightHorizontal = Input.GetAxisRaw("Mouse X");

        Debug.Log(rightHorizontal + " " + rightVertical);
        Debug.Log(horizontalInput + " " + verticalInput + "     " + rightHorizontal + " " + rightVertical);
    }
}
