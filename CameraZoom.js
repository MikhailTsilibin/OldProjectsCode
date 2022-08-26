#pragma strict

function Update ()
{
    //------------------Code for Zooming Out------------
    if (Input.GetAxis("Mouse ScrollWheel") <0)
    {
        if (Camera.main.fieldOfView<=70)
            Camera.main.fieldOfView +=2;
        if (Camera.main.orthographicSize<=20)
            Camera.main.orthographicSize +=0.5;
    }

    //----------------Code for Zooming In-----------------------
    if (Input.GetAxis("Mouse ScrollWheel") > 0)
    {
        if (Camera.main.fieldOfView>35)
            Camera.main.fieldOfView -=2;
        if (Camera.main.orthographicSize>=1)
            Camera.main.orthographicSize -=0.5;
    }
}