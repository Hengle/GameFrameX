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

namespace cfg.test
{
    public sealed partial class MultiRowType2 :  Bright.Config.BeanBase 
    {
        public MultiRowType2(JSONNode _json) 
        {
            { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
            { if(!_json["x"].IsNumber) { throw new SerializationException(); }  X = _json["x"]; }
            { if(!_json["y"].IsNumber) { throw new SerializationException(); }  Y = _json["y"]; }
            PostInit();
        }
    
        public MultiRowType2(int id, int x, float y ) 
        {
            this.Id = id;
            this.X = x;
            this.Y = y;
            PostInit();
        }
    
        public static MultiRowType2 DeserializeMultiRowType2(JSONNode _json)
        {
            return new test.MultiRowType2(_json);
        }
    
        public int Id { get; private set; }
        public int X { get; private set; }
        public float Y { get; private set; }
    
        public const int __ID__ = 540474971;
        public override int GetTypeId() => __ID__;
    
        public  void Resolve(Dictionary<string, object> _tables)
        {
            PostResolve();
        }
    
        public  void TranslateText(System.Func<string, string, string> translator)
        {
        }
    
        public override string ToString()
        {
            return "{ "
            + "Id:" + Id + ","
            + "X:" + X + ","
            + "Y:" + Y + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}