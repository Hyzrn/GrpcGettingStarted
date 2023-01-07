// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/weather.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcService.Server {

  /// <summary>Holder for reflection information generated from Protos/weather.proto</summary>
  public static partial class WeatherReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/weather.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeatherReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90b3Mvd2VhdGhlci5wcm90bxIHd2VhdGhlciKRAQoYR2V0Q3VycmVu",
            "dFdlYXRoZXJSZXF1ZXN0EgwKBGNpdHkYASABKAkSNgoFdW5pdHMYAiABKA4y",
            "Jy53ZWF0aGVyLkdldEN1cnJlbnRXZWF0aGVyUmVxdWVzdC5Vbml0cyIvCgVV",
            "bml0cxIMCghTdGFuZGFyZBAAEgoKBk1ldHJpYxABEgwKCEltcGVyaWFsEAIi",
            "OgoPV2VhdGhlclJlc3BvbnNlEhMKC3RlbXBlcmF0dXJlGAEgASgBEhIKCmZl",
            "ZWxzX2xpa2UYAiABKAEyYgoOV2VhdGhlclNlcnZpY2USUAoRR2V0Q3VycmVu",
            "dFdlYXRoZXISIS53ZWF0aGVyLkdldEN1cnJlbnRXZWF0aGVyUmVxdWVzdBoY",
            "LndlYXRoZXIuV2VhdGhlclJlc3BvbnNlQhWqAhJHcnBjU2VydmljZS5TZXJ2",
            "ZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Server.GetCurrentWeatherRequest), global::GrpcService.Server.GetCurrentWeatherRequest.Parser, new[]{ "City", "Units" }, null, new[]{ typeof(global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcService.Server.WeatherResponse), global::GrpcService.Server.WeatherResponse.Parser, new[]{ "Temperature", "FeelsLike" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetCurrentWeatherRequest : pb::IMessage<GetCurrentWeatherRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetCurrentWeatherRequest> _parser = new pb::MessageParser<GetCurrentWeatherRequest>(() => new GetCurrentWeatherRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCurrentWeatherRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.Server.WeatherReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCurrentWeatherRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCurrentWeatherRequest(GetCurrentWeatherRequest other) : this() {
      city_ = other.city_;
      units_ = other.units_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCurrentWeatherRequest Clone() {
      return new GetCurrentWeatherRequest(this);
    }

    /// <summary>Field number for the "city" field.</summary>
    public const int CityFieldNumber = 1;
    private string city_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string City {
      get { return city_; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "units" field.</summary>
    public const int UnitsFieldNumber = 2;
    private global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units units_ = global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units.Standard;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units Units {
      get { return units_; }
      set {
        units_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCurrentWeatherRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCurrentWeatherRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (City != other.City) return false;
      if (Units != other.Units) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (City.Length != 0) hash ^= City.GetHashCode();
      if (Units != global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units.Standard) hash ^= Units.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (City.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(City);
      }
      if (Units != global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units.Standard) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Units);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (City.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(City);
      }
      if (Units != global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units.Standard) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Units);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (City.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      if (Units != global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units.Standard) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Units);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCurrentWeatherRequest other) {
      if (other == null) {
        return;
      }
      if (other.City.Length != 0) {
        City = other.City;
      }
      if (other.Units != global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units.Standard) {
        Units = other.Units;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            City = input.ReadString();
            break;
          }
          case 16: {
            Units = (global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            City = input.ReadString();
            break;
          }
          case 16: {
            Units = (global::GrpcService.Server.GetCurrentWeatherRequest.Types.Units) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the GetCurrentWeatherRequest message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Units {
        [pbr::OriginalName("Standard")] Standard = 0,
        [pbr::OriginalName("Metric")] Metric = 1,
        [pbr::OriginalName("Imperial")] Imperial = 2,
      }

    }
    #endregion

  }

  public sealed partial class WeatherResponse : pb::IMessage<WeatherResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WeatherResponse> _parser = new pb::MessageParser<WeatherResponse>(() => new WeatherResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WeatherResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcService.Server.WeatherReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherResponse(WeatherResponse other) : this() {
      temperature_ = other.temperature_;
      feelsLike_ = other.feelsLike_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherResponse Clone() {
      return new WeatherResponse(this);
    }

    /// <summary>Field number for the "temperature" field.</summary>
    public const int TemperatureFieldNumber = 1;
    private double temperature_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Temperature {
      get { return temperature_; }
      set {
        temperature_ = value;
      }
    }

    /// <summary>Field number for the "feels_like" field.</summary>
    public const int FeelsLikeFieldNumber = 2;
    private double feelsLike_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FeelsLike {
      get { return feelsLike_; }
      set {
        feelsLike_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WeatherResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WeatherResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Temperature, other.Temperature)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FeelsLike, other.FeelsLike)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Temperature != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Temperature);
      if (FeelsLike != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FeelsLike);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Temperature != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Temperature);
      }
      if (FeelsLike != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(FeelsLike);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Temperature != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Temperature);
      }
      if (FeelsLike != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(FeelsLike);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Temperature != 0D) {
        size += 1 + 8;
      }
      if (FeelsLike != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WeatherResponse other) {
      if (other == null) {
        return;
      }
      if (other.Temperature != 0D) {
        Temperature = other.Temperature;
      }
      if (other.FeelsLike != 0D) {
        FeelsLike = other.FeelsLike;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            Temperature = input.ReadDouble();
            break;
          }
          case 17: {
            FeelsLike = input.ReadDouble();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 9: {
            Temperature = input.ReadDouble();
            break;
          }
          case 17: {
            FeelsLike = input.ReadDouble();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
