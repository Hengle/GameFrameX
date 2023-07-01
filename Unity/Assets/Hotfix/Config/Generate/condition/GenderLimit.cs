//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;

namespace cfg.condition
{
    public sealed partial class GenderLimit :  condition.BoolRoleCondition 
    {
        public GenderLimit(JSONNode _json)  : base(_json) 
        {
            { if(!_json["gender"].IsNumber) { throw new SerializationException(); }  Gender = (role.EGenderType)_json["gender"].AsInt; }
            PostInit();
        }
    
        public GenderLimit(role.EGenderType gender )  : base() 
        {
            this.Gender = gender;
            PostInit();
        }
    
        public static GenderLimit DeserializeGenderLimit(JSONNode _json)
        {
            return new condition.GenderLimit(_json);
        }
    
        public role.EGenderType Gender { get; private set; }
    
        public const int __ID__ = 103675143;
        public override int GetTypeId() => __ID__;
    
        public override void Resolve(Dictionary<string, object> _tables)
        {
            base.Resolve(_tables);
            PostResolve();
        }
    
        public override void TranslateText(System.Func<string, string, string> translator)
        {
            base.TranslateText(translator);
        }
    
        public override string ToString()
        {
            return "{ "
            + "Gender:" + Gender + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}