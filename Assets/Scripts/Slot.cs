using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class		Slot : MonoBehaviour
{
	private Image	m_Object;

	void			Start ()
	{
		float		scale = -transform.localPosition.y / (Screen.height / 2f);
		transform.localScale = new Vector3(scale, scale, scale);
		m_Object = transform.GetChild(0).GetComponent<Image>();
	}

	void			Update ()
	{

	}

	public void		DisplaySlot(bool _Display)
	{
		GetComponent<Image>().enabled = _Display;
	}

	public void		DisplayObject(bool _Display)
	{
		m_Object.enabled = _Display;
	}

	public void		ChangeObject(Sprite _Sprite)
	{
		if (_Sprite == null)
			m_Object.enabled = false;
		else
			m_Object.sprite = _Sprite;
	}

}
