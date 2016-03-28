using UnityEngine;
using System.Collections;

public class GetClick : MonoBehaviour {

    public LayerMask mask;
    Ray ray;

    void Update()
    {
        Debugging();
        Detection();
    }

    void OnClick()
    {
        print("sending message to " + transform);
        transform.SendMessage("Clicked");
    }

    void Detection()
    {
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0) && hit.transform == transform)
        {
            if ( hit.transform.tag == "clickable")
            {
                print(hit.transform);
                OnClick();
            }
            else
            {
                print("clicking on " + hit.transform);
            }
        }
    }

    void Debugging()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 10f, Color.yellow);
    }
}
