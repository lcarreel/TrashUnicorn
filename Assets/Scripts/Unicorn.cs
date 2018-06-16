using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class			Unicorn : MonoBehaviour
{
	Vector3				m_InputBuffer = Vector3.zero;

	void				Start ()
	{
		SetRandomPosition();
	}

	void				Update ()
	{

	}

	public void			SetRandomPosition()
	{
		Vector3			pos = Vector3.zero;
		pos.x = Random.Range(-Screen.width / 2f, Screen.width / 2f);
		pos.y = Random.Range(-Screen.height / 2f, 0f);
		transform.localPosition = pos;
		SetScaleByPosition();
	}

	private void		SetScaleByPosition()
	{
		float			scale = -transform.localPosition.y / (Screen.height / 2f);
		transform.localScale = new Vector3(scale, scale, scale);
	}
}
