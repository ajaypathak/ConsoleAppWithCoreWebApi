﻿namespace Api.ClientProxy
{
    //----------------------
    // <auto-generated>
    //     Generated using the NSwag toolchain v12.0.13.0 (NJsonSchema v9.13.17.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
    // </auto-generated>
    //----------------------

    namespace MyNamespace
    {
        [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "9.13.17.0 (Newtonsoft.Json v11.0.0.0)")]
        public partial class UpdateUserResponse : UserResponse
        {
            public string ToJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

            public static UpdateUserResponse FromJson(string data)
            {
                return Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateUserResponse>(data);
            }

        }

#pragma warning restore
    }
}
