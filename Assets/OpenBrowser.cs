using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBrowser : MonoBehaviour
{
    string CatalystName = "Nothing";

    // Start is called before the first frame update
    void Start()
    {
        Handheld.Vibrate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if (Physics.Raycast(ray, out Hit))
            {
                CatalystName = Hit.transform.name;

                switch (CatalystName)
                {
                    case "Palm_Google":
                        Application.OpenURL("http://google.com/");
                        break;
                    case "Palm_Portfolio":
                        Application.OpenURL("http://yaphet.surge.sh/");
                        break;
                    default:
                        break;

                }
            }
        }
    }

    void OnGUI()
    {
        GUILayout.Label("                           " + CatalystName);
    }
}
