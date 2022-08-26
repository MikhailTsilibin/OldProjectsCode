using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeTeleport : MonoBehaviour {

    public Image fadePlane;
    public Transform spawnPoint;
    public GameObject spawnObject;

    void Teleport() 
    {
        StartCoroutine(Fade(Color.clear, new Color(0, 0, 0, .95f), 1));
	}
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("LolJIza");
            Teleport();
            //GameObject spawnObject = GameObject.FindObjectByTag("Spawn");
           // spawnPoint = spawnObject.transform.position;
        }
    }
    
    IEnumerator Fade(Color from, Color to, float time)
    {
        float speed = 1 / time;
        float percent = 0;

        while (percent < 1)
        {
            percent += Time.deltaTime * speed;
            fadePlane.color = Color.Lerp(from, to, percent);
            yield return null;
        }
    }
}
