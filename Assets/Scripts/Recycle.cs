using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recycle : MonoBehaviour
{
    public List<GameObject> objectType;
    private List<Vector3> objectStartPos = new List<Vector3>();
    private static float waitTime = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //Storing the start positions of the objects
        for(int i = 0; i < objectType.Count; i++)
        {
            objectStartPos.Add(objectType[i].transform.position);
        }

        foreach(Vector3 v in objectStartPos) {
            print(v + "\n");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject track in objectType) {
            if (other.name == track.name || other.CompareTag(track.tag))
            {
                Debug.Log("detected collision");
                print(track.name);
                print(objectType.IndexOf(track));

                StartCoroutine(ResetTrackAfterSeconds(waitTime, track, 
                objectStartPos[objectType.IndexOf(track)]));
            }
        }

    }

    IEnumerator ResetTrackAfterSeconds(float seconds, GameObject piece, Vector3 startingPlace) 
    {
        print("WAITING " + waitTime + " SECONDS!");
        yield return new WaitForSeconds(seconds);
        piece.transform.position = startingPlace;
        Debug.Log("whats going on here");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
