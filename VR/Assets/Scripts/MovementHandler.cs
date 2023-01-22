using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MovementHandler : MonoBehaviour
{
    public float speed = 5.0f;
    XRController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Récupérer les inputs du joystick droit
        float horizontal = controller.inputDevice.GetAxis(CommonUsages.secondary2DAxisX);
        float vertical = controller.inputDevice.GetAxis(CommonUsages.secondary2DAxisY);

        // Appliquer les inputs pour déplacer la caméra ou le joueur
        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);
    }
}
