using System.Reflection;
using UnityEditor.UIElements;
using UnityEngine;

namespace UniBT.Editor
{
    public class GradientResolver : FieldResolver<GradientField,Gradient>
    {
        public GradientResolver(FieldInfo fieldInfo) : base(fieldInfo)
        {
        }
        protected override GradientField CreateEditorField(FieldInfo fieldInfo)
        {
            return new GradientField(fieldInfo.Name);
        }
        public static bool IsAcceptable(FieldInfo info) => info.FieldType == typeof(Gradient);
    }
}