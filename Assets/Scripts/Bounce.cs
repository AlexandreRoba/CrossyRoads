using UnityEngine;
using System.Collections;

public class Bounce : MonoBehaviour
{

    private float lerpTime;
    private float currentLerpTime;
    private float perc = 1;

    private Vector3 startPos;
    private Vector3 endPos;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("up") || Input.GetButtonDown("down") || Input.GetButtonDown("left") || Input.GetButtonDown("right"))
        {
            if (perc == 1)
            {
                lerpTime = 1;
                currentLerpTime = 0;
            }
        }
        startPos = gameObject.transform.position;
        if (Input.GetButtonDown("right") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
        if (Input.GetButtonDown("left") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        }
        if (Input.GetButtonDown("up") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        }
        if (Input.GetButtonDown("down") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
        }

        currentLerpTime += Time.deltaTime * 5.5f;
        perc = currentLerpTime / lerpTime;
        gameObject.transform.position = Vector3.Lerp(startPos, endPos, perc);
    }
}
