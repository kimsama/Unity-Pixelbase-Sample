using UnityEngine;
using System.Collections;

public class ResizeByPixel : MonoBehaviour 
{
	public int pixelSize;
	public float defaultSize = 1;

	public int screenHeight =  1920;

	void OnValidate()
	{
        if (pixelSize == 0)
            return;

		float orthographicSize = screenHeight / pixelSize * 0.5f;
		Camera.main.orthographicSize = orthographicSize;

		defaultSize = Mathf.Max(0.0001f, defaultSize);

		if( pixelSize < 1 )
			return;
		float rate = defaultSize / pixelSize;
		transform.localScale = new Vector3(rate, rate, rate);
	}
}
