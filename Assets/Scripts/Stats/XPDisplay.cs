using System;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Stats
{
    public class XPDisplay : MonoBehaviour
    {
        Experience experience;
        Text XPValue;

        private void Awake()
        {
            experience = GameObject.FindWithTag("Player").GetComponent<Experience>();
            XPValue = GetComponent<Text>();
        }

        private void Update()
        {
            XPValue.text = String.Format("{0:0}", experience.GetExperience());
        }

    }
}
