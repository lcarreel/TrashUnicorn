using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class			Unicorn : MonoBehaviour
{
	private Vector3		m_InputBuffer = Vector3.zero;
	private float		m_LastTP = 0;
	public float		m_TimeBetweenTP = 3;


	void				Start ()
	{
		SetRandomPosition();
	}

	void				Update ()
	{
		if (Time.time -  m_LastTP > m_TimeBetweenTP)
			SetRandomPosition();
	}

	public void			SetRandomPosition()
	{
		Vector3			pos = Vector3.zero;
		pos.x = Random.Range(-Screen.width / 2f, Screen.width / 2f);
		pos.y = Random.Range(-Screen.height / 2f, 0f);
		transform.localPosition = pos;
		SetScaleByPosition();
		m_LastTP = Time.time;
	}

	private void		SetScaleByPosition()
	{
		float			scale = -transform.localPosition.y / (Screen.height / 2f);
		transform.localScale = new Vector3(scale, scale, scale);
	}
}
