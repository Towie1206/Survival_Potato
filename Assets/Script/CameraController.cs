using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Vector2 minmaxXY;
    PlayerController player = PlayerController.Instance;

    private void LateUpdate()
    {
        Vector3 target = new Vector3(PlayerController.Instance.transform.position.x, PlayerController.Instance.transform.position.y, -10);
        //giới hạn giá trị 1 khoảng nhất định Mathf.Clamp(giá_trị_cần_kiểm_tra, min, max);
       target.x = Mathf.Clamp(PlayerController.Instance.transform.position.x, -minmaxXY.x, minmaxXY.x); 
       target.y = Mathf.Clamp(PlayerController.Instance.transform.position.y, -minmaxXY.y, minmaxXY.y);

        transform.position = target;
    }
}
