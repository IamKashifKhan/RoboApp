using System;
using System.ComponentModel;
using System.Reflection;
using RoboApp.Enums;
using Xamarin.Essentials;

namespace RoboApp.Helpers.Extensions
{
    public static class MotorTypeDescription
    {
        /// <summary>
        /// Get description for TextChatStatus enum
        /// </summary>
        /// <param name="chatStatus"></param>
        /// <returns></returns>
        public static string GetMotorDescription(this MotorType motorType)
        {
            // get the field 
            var field = motorType.GetType().GetField(motorType.ToString());
            var result = GetDescriptionAttributeValue(field);
            return string.IsNullOrWhiteSpace(result) ? motorType.ToString() : result;
        }
        /// <summary>
        /// Get description for Device Type enum
        /// </summary>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        public static string GetDescription(this DeviceType deviceType)
        {
            // get the field 
            var field = deviceType.GetType().GetField(deviceType.ToString());
            var result = GetDescriptionAttributeValue(field);
            return string.IsNullOrWhiteSpace(result) ? deviceType.ToString() : result;
        }
        /// <summary>
        /// Get decription attribute value
        /// </summary>
        /// <param name="fieldInfo"></param>
        /// <returns></returns>
        private static string GetDescriptionAttributeValue(FieldInfo fieldInfo)
        {
            var customAttributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (customAttributes.Length > 0)
            {
                return (customAttributes[0] as DescriptionAttribute).Description;
            }
            return string.Empty;
        }
        public static T GetValueFromDescription<T>(string description)
        {
            var type = typeof(T);
            if (!type.IsEnum) throw new InvalidOperationException();
            foreach (var field in type.GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (attribute != null)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", nameof(description));
            // or return default(T);
        }
    }
}
