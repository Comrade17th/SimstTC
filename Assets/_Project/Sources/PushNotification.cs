using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class PushNotification : MonoBehaviour
{
     private void Awake()
     {
          AndroidNotificationChannel channel = new AndroidNotificationChannel()
          {
               Name = $"News | Новости",
               Description = $"Уведомление о важных новостях",
               Id = "news",
               Importance = Importance.High
          };
          
          AndroidNotificationCenter.RegisterNotificationChannel(channel);
     }

     public void SendNotification()
     {
          int secondsToFire = 5;
          
          AndroidNotification notification = new AndroidNotification()
          {
               Title = $"Не упустите аренду",
               Text = $"Доступна площадь для бронирования",
               FireTime = System.DateTime.Now.AddSeconds(secondsToFire),
               SmallIcon = "small_icon",
               LargeIcon = "large_icon"
          };

          AndroidNotificationCenter.SendNotification(notification, channelId: $"news");
     }
}
