using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    private Vector3 raycastPosition;
    // Update is called once per frame
    void Update()
    {       
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity))
        {
            if (hit.collider.CompareTag("Zombie"))
            {
                LookAtTarget(hit.collider.transform.position);
                return;
            }
            //look
            Vector3 lookPoint = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(lookPoint);
            raycastPosition = hit.point;
        }
    }

    private void LookAtTarget(Vector3 target)
    {
        Vector3 lookPoint = new Vector3(target.x, transform.position.y, target.z);
        transform.LookAt(lookPoint);
    }
}
