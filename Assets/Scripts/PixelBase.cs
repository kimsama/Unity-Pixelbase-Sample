using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PixelBase : MonoBehaviour {

	void LateUpdate () 
	{
		Vector3 cashPosition, cashScale;

		cashPosition = transform.localPosition;
		cashScale = transform.localScale;
		transform.localPosition = new Vector3( 
		                Mathf.RoundToInt( cashPosition.x),
		                Mathf.RoundToInt( cashPosition.y),
		                Mathf.RoundToInt( cashPosition.z));
		                
		transform.localScale = new Vector3(
					Mathf.RoundToInt( cashScale.x),
					Mathf.RoundToInt( cashScale.y),
					Mathf.RoundToInt( cashScale.z));
	}
}
