﻿namespace Api.ClientProxy
{
    //----------------------
    // <auto-generated>
    //     Generated using the NSwag toolchain v12.0.13.0 (NJsonSchema v9.13.17.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
    // </auto-generated>
    //----------------------

    namespace MyNamespace
    {
        [System.CodeDom.Compiler.GeneratedCode("NSwag", "12.0.13.0 (NJsonSchema v9.13.17.0 (Newtonsoft.Json v11.0.0.0))")]
        public partial class SwaggerException<TResult> : SwaggerException
        {
            public TResult Result { get; private set; }

            public SwaggerException(string message, int statusCode, string response, System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
                : base(message, statusCode, response, headers, innerException)
            {
                Result = result;
            }
        }

#pragma warning restore
    }
}
