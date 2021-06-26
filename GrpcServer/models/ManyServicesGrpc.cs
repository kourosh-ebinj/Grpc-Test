// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ManyServices.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Deltaban.Grpc {
  public static partial class SearchService
  {
    static readonly string __ServiceName = "GrpcBroker.SearchService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Deltaban.Grpc.SearchRequest> __Marshaller_GrpcBroker_SearchRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Deltaban.Grpc.SearchRequest.Parser));
    static readonly grpc::Marshaller<global::Deltaban.Grpc.SearchResponse> __Marshaller_GrpcBroker_SearchResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Deltaban.Grpc.SearchResponse.Parser));

    static readonly grpc::Method<global::Deltaban.Grpc.SearchRequest, global::Deltaban.Grpc.SearchResponse> __Method_Search = new grpc::Method<global::Deltaban.Grpc.SearchRequest, global::Deltaban.Grpc.SearchResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "Search",
        __Marshaller_GrpcBroker_SearchRequest,
        __Marshaller_GrpcBroker_SearchResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Deltaban.Grpc.ManyServicesReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SearchService</summary>
    [grpc::BindServiceMethod(typeof(SearchService), "BindService")]
    public abstract partial class SearchServiceBase
    {
      public virtual global::System.Threading.Tasks.Task Search(global::Deltaban.Grpc.SearchRequest request, grpc::IServerStreamWriter<global::Deltaban.Grpc.SearchResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SearchServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Search, serviceImpl.Search).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SearchServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Search, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Deltaban.Grpc.SearchRequest, global::Deltaban.Grpc.SearchResponse>(serviceImpl.Search));
    }

  }
}
#endregion
