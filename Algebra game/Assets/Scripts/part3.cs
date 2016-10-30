using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class part3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for(int i=0; i<4; i++)
        {
            Image img = transform.GetChild(i).GetChild(0).GetComponent<Image>();
            var obj = Resources.Load("a") as Texture2D;
            Rect rec = new Rect(0, 0, obj.width, obj.height);
            var x = Sprite.Create(obj, rec, new Vector2(0.5f, 0.5f));
            img.sprite = x;
        }
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}
}
