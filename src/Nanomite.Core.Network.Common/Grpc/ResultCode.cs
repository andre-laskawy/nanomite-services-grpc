// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ResultCode.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Nanomite.Core.Network.Common {

  /// <summary>Holder for reflection information generated from ResultCode.proto</summary>
  public static partial class ResultCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for ResultCode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResultCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBSZXN1bHRDb2RlLnByb3RvEhxOYW5vbWl0ZS5Db3JlLk5ldHdvcmsuQ29t",
            "bW9uKh8KClJlc3VsdENvZGUSBgoCT0sQABIJCgVFUlJPUhABQisKD2lvLmdy",
            "cGMubWVzc2FnZUIQTWVzc2FnZURhdGFQcm90b1ABogIDSExXYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Nanomite.Core.Network.Common.ResultCode), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ResultCode {
    [pbr::OriginalName("OK")] Ok = 0,
    [pbr::OriginalName("ERROR")] Error = 1,
  }

  #endregion

}

#endregion Designer generated code