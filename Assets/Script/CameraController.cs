using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   // [SerializeField] private Vector2 minmaxXY;
    private Transform player;

    void Start()
    {
        player = PlayerController.Instance.transform;
    }

    private void LateUpdate()
    {
        Vector3 target = new Vector3(player.position.x, player.position.y, -10);
        //giới hạn giá trị 1 khoảng nhất định Mathf.Clamp(giá_trị_cần_kiểm_tra, min, max);
       // target.x = Mathf.Clamp(player.position.x, -minmaxXY.x, minmaxXY.x); 
        //target.y = Mathf.Clamp(player.position.y, -minmaxXY.y, minmaxXY.y);

        transform.position = target;
    }
}
