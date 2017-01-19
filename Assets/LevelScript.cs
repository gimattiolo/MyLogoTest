using UnityEngine;
using System.Collections;

public class LevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if(movTexture_left != null)
        {
            QualitySettings.vSyncCount = 0;
            movTexture_left.Play();
        }

        if (movTexture_right != null)
        {
            QualitySettings.vSyncCount = 0;
            movTexture_right.Play();
        }
    }

    // Update is called once per frame
    void Update () {
	
	}

    public MovieTexture movTexture_left;
    public MovieTexture movTexture_right;
}
