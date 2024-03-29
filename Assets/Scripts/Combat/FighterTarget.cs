﻿using UnityEngine;
using RPG.Resources;
using RPG.Control;

namespace RPG.Combat
{

    [RequireComponent(typeof(Health))]
    public class FighterTarget : MonoBehaviour, IRaycastable
    {
        public CursorType GetCursorType()
        {
            return CursorType.Combat;
        }

        public bool HandleRaycast(PlayerController callingController)
        {
            if (callingController.GetComponent<Fighter>().CanAttack(gameObject) == false) return false;

            if (Input.GetMouseButton(0))
            {
                callingController.GetComponent<Fighter>().Attack(gameObject);
            }
            return true;
        }
    }
}

