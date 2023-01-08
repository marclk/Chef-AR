using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

namespace DanielLochner.Assets.SimpleScrollSnap
{
    public class SetTimer : MonoBehaviour
    {
        private float Time;

        public GameObject TenMinutesObject;
        public GameObject MinutesObject;
        public GameObject TenSecondsObject;
        public GameObject SecondsObject;

        private SimpleScrollSnap TenMinutesScript;
        private SimpleScrollSnap MinutesScript;
        private SimpleScrollSnap TenSecondsScript;
        private SimpleScrollSnap SecondsScript;

        private float TenMinutes;
        private float Minutes;
        private float TenSeconds;
        private float Seconds;

        public GameObject TimerPrefab;
        public Transform TimerParent;
        private GameObject Timer;

        // Start is called before the first frame update
        void Start()
        {
            TenMinutesScript = TenMinutesObject.GetComponent<SimpleScrollSnap>();
            MinutesScript = MinutesObject.GetComponent<SimpleScrollSnap>();
            TenSecondsScript = TenSecondsObject.GetComponent<SimpleScrollSnap>();
            SecondsScript = SecondsObject.GetComponent<SimpleScrollSnap>();
        }

        // Update is called once per frame
        void Update()
        {
            TenMinutes = TenMinutesScript.SelectedPanel;
            Minutes = MinutesScript.SelectedPanel;
            TenSeconds = TenSecondsScript.SelectedPanel;
            Seconds = SecondsScript.SelectedPanel;
        }

        public void CreateTimer()
        {
            Timer = Instantiate(TimerPrefab, new Vector3(50f, -25f, 1f), Quaternion.identity);
            Timer.transform.SetParent(TimerParent);
            Timer.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            
            Timer.GetComponent<Timer>().TimeLeft = CalculateTimeInSeconds();
        }

        private float CalculateTimeInSeconds()
        {
            Time = (TenMinutes * 600) + (Minutes * 60) + (TenSeconds * 10) + Seconds;
            return Time;
        }
    }
}
