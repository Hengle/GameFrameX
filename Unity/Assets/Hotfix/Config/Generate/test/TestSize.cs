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
    public sealed partial class TestSize :  Bright.Config.BeanBase 
    {
        public TestSize(JSONNode _json) 
        {
            { if(!_json["id"].IsNumber) { throw new SerializationException(); }  Id = _json["id"]; }
            { var __json0 = _json["x1"]; if(!__json0.IsArray) { throw new SerializationException(); } int _n0 = __json0.Count; X1 = new int[_n0]; int __index0=0; foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  X1[__index0++] = __v0; }   }
            { var __json0 = _json["x2"]; if(!__json0.IsArray) { throw new SerializationException(); } X2 = new System.Collections.Generic.List<int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  X2.Add(__v0); }   }
            { var __json0 = _json["x3"]; if(!__json0.IsArray) { throw new SerializationException(); } X3 = new System.Collections.Generic.HashSet<int>(/*__json0.Count*/); foreach(JSONNode __e0 in __json0.Children) { int __v0;  { if(!__e0.IsNumber) { throw new SerializationException(); }  __v0 = __e0; }  X3.Add(__v0); }   }
            { var __json0 = _json["x4"]; if(!__json0.IsArray) { throw new SerializationException(); } X4 = new System.Collections.Generic.Dictionary<int, int>(__json0.Count); foreach(JSONNode __e0 in __json0.Children) { int _k0;  { if(!__e0[0].IsNumber) { throw new SerializationException(); }  _k0 = __e0[0]; } int _v0;  { if(!__e0[1].IsNumber) { throw new SerializationException(); }  _v0 = __e0[1]; }  X4.Add(_k0, _v0); }   }
            PostInit();
        }
    
        public TestSize(int id, int[] x1, System.Collections.Generic.List<int> x2, System.Collections.Generic.HashSet<int> x3, System.Collections.Generic.Dictionary<int, int> x4 ) 
        {
            this.Id = id;
            this.X1 = x1;
            this.X2 = x2;
            this.X3 = x3;
            this.X4 = x4;
            PostInit();
        }
    
        public static TestSize DeserializeTestSize(JSONNode _json)
        {
            return new test.TestSize(_json);
        }
    
        public int Id { get; private set; }
        public int[] X1 { get; private set; }
        public System.Collections.Generic.List<int> X2 { get; private set; }
        public System.Collections.Generic.HashSet<int> X3 { get; private set; }
        public System.Collections.Generic.Dictionary<int, int> X4 { get; private set; }
    
        public const int __ID__ = 340006319;
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
            + "X1:" + Bright.Common.StringUtil.CollectionToString(X1) + ","
            + "X2:" + Bright.Common.StringUtil.CollectionToString(X2) + ","
            + "X3:" + Bright.Common.StringUtil.CollectionToString(X3) + ","
            + "X4:" + Bright.Common.StringUtil.CollectionToString(X4) + ","
            + "}";
        }
        
        partial void PostInit();
        partial void PostResolve();
    }
}