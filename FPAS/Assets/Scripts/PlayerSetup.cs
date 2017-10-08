using UnityEngine;

public class PlayerSetup : MonoBehaviour {

    public bool lockCursor = false;

    private void Update()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

}
