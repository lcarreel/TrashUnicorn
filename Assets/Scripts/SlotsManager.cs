using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class			SlotsManager : MonoBehaviour
{
	private Sprite[]	m_Inventory;
	private Slot[]		m_Slots;


	private bool		m_DisplaySlots = false;

	void				Start ()
	{
		m_Slots = GetComponentsInChildren<Slot>();
		DisplaySlots(false);
	}

	void				Update ()
	{

	}

	public void			ChangeSlotObject(Slot _Slot)
	{
		//_Slot.ChangeObject();
	}

	public void			OpenInventory()
	{

	}

	public void		DisplaySlots(bool _Display)
	{
		foreach (Slot slot in m_Slots)
		{
			slot.DisplaySlot(_Display);
		}
		m_DisplaySlots = _Display;
	}

	public void		ToggleDisplaySlots()
	{
		if (m_DisplaySlots)
			DisplaySlots(false);
		else
			DisplaySlots(true);
	}
}
