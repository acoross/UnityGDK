// Generated by SpatialOS codegen. DO NOT EDIT!
// source: ExhaustiveRepeated in improbable/gdk/tests/exhaustive_test.schema.

namespace Improbable.Gdk.Tests
{

public static class ExhaustiveRepeated_Extensions
{
  public static ExhaustiveRepeated.Data Get(this global::Improbable.Worker.IComponentData<ExhaustiveRepeated> data)
  {
    return (ExhaustiveRepeated.Data) data;
  }

  public static ExhaustiveRepeated.Update Get(this global::Improbable.Worker.IComponentUpdate<ExhaustiveRepeated> update)
  {
    return (ExhaustiveRepeated.Update) update;
  }
}

public partial class ExhaustiveRepeated : global::Improbable.Worker.IComponentMetaclass
{
  public const uint ComponentId = 197717;

  uint global::Improbable.Worker.IComponentMetaclass.ComponentId
  {
    get { return ComponentId; }
  }

  /// <summary>
  /// Concrete data type for the ExhaustiveRepeated component.
  /// </summary>
  public class Data : global::Improbable.Worker.IComponentData<ExhaustiveRepeated>, global::Improbable.Collections.IDeepCopyable<Data>
  {
    public global::Improbable.Gdk.Tests.ExhaustiveRepeatedData Value;

    public Data(global::Improbable.Gdk.Tests.ExhaustiveRepeatedData value)
    {
      Value = value;
    }

    public Data(
        global::Improbable.Collections.List<float> field2,
        global::Improbable.Collections.List<int> field4,
        global::Improbable.Collections.List<long> field5,
        global::Improbable.Collections.List<double> field6,
        global::Improbable.Collections.List<string> field7,
        global::Improbable.Collections.List<uint> field8,
        global::Improbable.Collections.List<ulong> field9,
        global::Improbable.Collections.List<int> field10,
        global::Improbable.Collections.List<long> field11,
        global::Improbable.Collections.List<uint> field12,
        global::Improbable.Collections.List<ulong> field13,
        global::Improbable.Collections.List<int> field14,
        global::Improbable.Collections.List<long> field15,
        global::Improbable.Collections.List<global::Improbable.EntityId> field16,
        global::Improbable.Collections.List<global::Improbable.Gdk.Tests.SomeType> field17)
    {
      Value = new global::Improbable.Gdk.Tests.ExhaustiveRepeatedData(
          field2,
          field4,
          field5,
          field6,
          field7,
          field8,
          field9,
          field10,
          field11,
          field12,
          field13,
          field14,
          field15,
          field16,
          field17);
    }

    public Data DeepCopy()
    {
      return new Data(Value.DeepCopy());
    }

    public global::Improbable.Worker.IComponentUpdate<ExhaustiveRepeated> ToUpdate()
    {
      var update = new Update();
      update.SetField2(Value.field2);
      update.SetField4(Value.field4);
      update.SetField5(Value.field5);
      update.SetField6(Value.field6);
      update.SetField7(Value.field7);
      update.SetField8(Value.field8);
      update.SetField9(Value.field9);
      update.SetField10(Value.field10);
      update.SetField11(Value.field11);
      update.SetField12(Value.field12);
      update.SetField13(Value.field13);
      update.SetField14(Value.field14);
      update.SetField15(Value.field15);
      update.SetField16(Value.field16);
      update.SetField17(Value.field17);
      return update;
    }
  }

  /// <summary>
  /// Concrete update type for the ExhaustiveRepeated component.
  /// </summary>
  public class Update : global::Improbable.Worker.IComponentUpdate<ExhaustiveRepeated>, global::Improbable.Collections.IDeepCopyable<Update>
  {
    /// <summary>
    /// Field field2 = 2.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<float>> field2;
    public Update SetField2(global::Improbable.Collections.List<float> _value)
    {
      field2.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field4 = 4.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<int>> field4;
    public Update SetField4(global::Improbable.Collections.List<int> _value)
    {
      field4.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field5 = 5.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<long>> field5;
    public Update SetField5(global::Improbable.Collections.List<long> _value)
    {
      field5.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field6 = 6.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<double>> field6;
    public Update SetField6(global::Improbable.Collections.List<double> _value)
    {
      field6.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field7 = 7.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<string>> field7;
    public Update SetField7(global::Improbable.Collections.List<string> _value)
    {
      field7.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field8 = 8.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<uint>> field8;
    public Update SetField8(global::Improbable.Collections.List<uint> _value)
    {
      field8.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field9 = 9.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<ulong>> field9;
    public Update SetField9(global::Improbable.Collections.List<ulong> _value)
    {
      field9.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field10 = 10.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<int>> field10;
    public Update SetField10(global::Improbable.Collections.List<int> _value)
    {
      field10.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field11 = 11.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<long>> field11;
    public Update SetField11(global::Improbable.Collections.List<long> _value)
    {
      field11.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field12 = 12.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<uint>> field12;
    public Update SetField12(global::Improbable.Collections.List<uint> _value)
    {
      field12.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field13 = 13.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<ulong>> field13;
    public Update SetField13(global::Improbable.Collections.List<ulong> _value)
    {
      field13.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field14 = 14.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<int>> field14;
    public Update SetField14(global::Improbable.Collections.List<int> _value)
    {
      field14.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field15 = 15.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<long>> field15;
    public Update SetField15(global::Improbable.Collections.List<long> _value)
    {
      field15.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field16 = 16.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<global::Improbable.EntityId>> field16;
    public Update SetField16(global::Improbable.Collections.List<global::Improbable.EntityId> _value)
    {
      field16.Set(_value);
      return this;
    }

    /// <summary>
    /// Field field17 = 17.
    /// </summary>
    public global::Improbable.Collections.Option<global::Improbable.Collections.List<global::Improbable.Gdk.Tests.SomeType>> field17;
    public Update SetField17(global::Improbable.Collections.List<global::Improbable.Gdk.Tests.SomeType> _value)
    {
      field17.Set(_value);
      return this;
    }

    public Update DeepCopy()
    {
      var _result = new Update();
      if (field2.HasValue)
      {
        global::Improbable.Collections.List<float> field;
        field = field2.Value.DeepCopy();
        _result.field2.Set(field);
      }
      if (field4.HasValue)
      {
        global::Improbable.Collections.List<int> field;
        field = field4.Value.DeepCopy();
        _result.field4.Set(field);
      }
      if (field5.HasValue)
      {
        global::Improbable.Collections.List<long> field;
        field = field5.Value.DeepCopy();
        _result.field5.Set(field);
      }
      if (field6.HasValue)
      {
        global::Improbable.Collections.List<double> field;
        field = field6.Value.DeepCopy();
        _result.field6.Set(field);
      }
      if (field7.HasValue)
      {
        global::Improbable.Collections.List<string> field;
        field = field7.Value.DeepCopy();
        _result.field7.Set(field);
      }
      if (field8.HasValue)
      {
        global::Improbable.Collections.List<uint> field;
        field = field8.Value.DeepCopy();
        _result.field8.Set(field);
      }
      if (field9.HasValue)
      {
        global::Improbable.Collections.List<ulong> field;
        field = field9.Value.DeepCopy();
        _result.field9.Set(field);
      }
      if (field10.HasValue)
      {
        global::Improbable.Collections.List<int> field;
        field = field10.Value.DeepCopy();
        _result.field10.Set(field);
      }
      if (field11.HasValue)
      {
        global::Improbable.Collections.List<long> field;
        field = field11.Value.DeepCopy();
        _result.field11.Set(field);
      }
      if (field12.HasValue)
      {
        global::Improbable.Collections.List<uint> field;
        field = field12.Value.DeepCopy();
        _result.field12.Set(field);
      }
      if (field13.HasValue)
      {
        global::Improbable.Collections.List<ulong> field;
        field = field13.Value.DeepCopy();
        _result.field13.Set(field);
      }
      if (field14.HasValue)
      {
        global::Improbable.Collections.List<int> field;
        field = field14.Value.DeepCopy();
        _result.field14.Set(field);
      }
      if (field15.HasValue)
      {
        global::Improbable.Collections.List<long> field;
        field = field15.Value.DeepCopy();
        _result.field15.Set(field);
      }
      if (field16.HasValue)
      {
        global::Improbable.Collections.List<global::Improbable.EntityId> field;
        field = field16.Value.DeepCopy();
        _result.field16.Set(field);
      }
      if (field17.HasValue)
      {
        global::Improbable.Collections.List<global::Improbable.Gdk.Tests.SomeType> field;
        field = field17.Value.DeepCopy();
        _result.field17.Set(field);
      }
      return _result;
    }

    public global::Improbable.Worker.IComponentData<ExhaustiveRepeated> ToInitialData()
    {
      return new Data(new global::Improbable.Gdk.Tests.ExhaustiveRepeatedData(
          field2.Value,
          field4.Value,
          field5.Value,
          field6.Value,
          field7.Value,
          field8.Value,
          field9.Value,
          field10.Value,
          field11.Value,
          field12.Value,
          field13.Value,
          field14.Value,
          field15.Value,
          field16.Value,
          field17.Value));
    }

    public void ApplyTo(global::Improbable.Worker.IComponentData<ExhaustiveRepeated> _data)
    {
      var _concrete = _data.Get();
      if (field2.HasValue)
      {
        _concrete.Value.field2 = field2.Value;
      }
      if (field4.HasValue)
      {
        _concrete.Value.field4 = field4.Value;
      }
      if (field5.HasValue)
      {
        _concrete.Value.field5 = field5.Value;
      }
      if (field6.HasValue)
      {
        _concrete.Value.field6 = field6.Value;
      }
      if (field7.HasValue)
      {
        _concrete.Value.field7 = field7.Value;
      }
      if (field8.HasValue)
      {
        _concrete.Value.field8 = field8.Value;
      }
      if (field9.HasValue)
      {
        _concrete.Value.field9 = field9.Value;
      }
      if (field10.HasValue)
      {
        _concrete.Value.field10 = field10.Value;
      }
      if (field11.HasValue)
      {
        _concrete.Value.field11 = field11.Value;
      }
      if (field12.HasValue)
      {
        _concrete.Value.field12 = field12.Value;
      }
      if (field13.HasValue)
      {
        _concrete.Value.field13 = field13.Value;
      }
      if (field14.HasValue)
      {
        _concrete.Value.field14 = field14.Value;
      }
      if (field15.HasValue)
      {
        _concrete.Value.field15 = field15.Value;
      }
      if (field16.HasValue)
      {
        _concrete.Value.field16 = field16.Value;
      }
      if (field17.HasValue)
      {
        _concrete.Value.field17 = field17.Value;
      }
    }
  }

  public partial class Commands
  {
  }

  // Implementation details below here.
  //----------------------------------------------------------------

  public global::Improbable.Worker.Internal.ComponentProtocol.ComponentVtable Vtable {
    get {
      global::Improbable.Worker.Internal.ComponentProtocol.ComponentVtable vtable;
      vtable.ComponentId = ComponentId;
      vtable.Free = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(global::Improbable.Worker.Internal.ClientHandles.ClientFree);
      vtable.Copy = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(global::Improbable.Worker.Internal.ClientHandles.ClientCopy);
      vtable.Deserialize = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(clientDeserialize);
      vtable.Serialize = global::System.Runtime.InteropServices.Marshal
          .GetFunctionPointerForDelegate(clientSerialize);
      return vtable;
    }
  }

  public void InvokeHandler(global::Improbable.Worker.Dynamic.Handler handler)
  {
    handler.Accept<ExhaustiveRepeated>(this);
  }

  private static unsafe readonly global::Improbable.Worker.Internal.ComponentProtocol.ClientDeserialize
      clientDeserialize = ClientDeserialize;
  private static unsafe readonly global::Improbable.Worker.Internal.ComponentProtocol.ClientSerialize
      clientSerialize = ClientSerialize;

  [global::Improbable.Worker.Internal.MonoPInvokeCallback(typeof(global::Improbable.Worker.Internal.ComponentProtocol.ClientDeserialize))]
  private static unsafe global::System.Byte
  ClientDeserialize(global::System.UInt32 componentId,
                    global::System.Byte handleType,
                    global::Improbable.Worker.Internal.Pbio.Object* root,
                    global::Improbable.Worker.Internal.ComponentProtocol.ClientHandle** handleOut)
  {
    *handleOut = null;
    try
    {
      *handleOut = global::Improbable.Worker.Internal.ClientHandles.HandleAlloc();
      if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Update) {
        var data = new Update();
        var fieldsToClear = new global::System.Collections.Generic.HashSet<uint>();
        var fieldsToClearCount = global::Improbable.Worker.Internal.Pbio.GetUint32Count(root, /* fields to clear */ 1);
        for (uint i = 0; i < fieldsToClearCount; ++i)
        {
           fieldsToClear.Add(global::Improbable.Worker.Internal.Pbio.IndexUint32(root, /* fields to clear */ 1, i));
        }
        var stateObject = global::Improbable.Worker.Internal.Pbio.GetObject(
            global::Improbable.Worker.Internal.Pbio.GetObject(root, /* entity_state */ 2), 197717);
        if (global::Improbable.Worker.Internal.Pbio.GetFloatCount(stateObject, 2) > 0 || fieldsToClear.Contains(2))
        {
          global::Improbable.Collections.List<float> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetFloatCount(stateObject, 2);
            field = new global::Improbable.Collections.List<float>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexFloat(stateObject, 2, _i));
            }
          }
          data.field2.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetInt32Count(stateObject, 4) > 0 || fieldsToClear.Contains(4))
        {
          global::Improbable.Collections.List<int> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetInt32Count(stateObject, 4);
            field = new global::Improbable.Collections.List<int>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexInt32(stateObject, 4, _i));
            }
          }
          data.field4.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetInt64Count(stateObject, 5) > 0 || fieldsToClear.Contains(5))
        {
          global::Improbable.Collections.List<long> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetInt64Count(stateObject, 5);
            field = new global::Improbable.Collections.List<long>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexInt64(stateObject, 5, _i));
            }
          }
          data.field5.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetDoubleCount(stateObject, 6) > 0 || fieldsToClear.Contains(6))
        {
          global::Improbable.Collections.List<double> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetDoubleCount(stateObject, 6);
            field = new global::Improbable.Collections.List<double>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexDouble(stateObject, 6, _i));
            }
          }
          data.field6.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetBytesCount(stateObject, 7) > 0 || fieldsToClear.Contains(7))
        {
          global::Improbable.Collections.List<string> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetBytesCount(stateObject, 7);
            field = new global::Improbable.Collections.List<string>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::System.Text.Encoding.UTF8.GetString(global::Improbable.Worker.Bytes.CopyOf(global::Improbable.Worker.Internal.Pbio.IndexBytes(stateObject, 7, _i), global::Improbable.Worker.Internal.Pbio.IndexBytesLength(stateObject, 7, _i)).BackingArray));
            }
          }
          data.field7.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetUint32Count(stateObject, 8) > 0 || fieldsToClear.Contains(8))
        {
          global::Improbable.Collections.List<uint> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetUint32Count(stateObject, 8);
            field = new global::Improbable.Collections.List<uint>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexUint32(stateObject, 8, _i));
            }
          }
          data.field8.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetUint64Count(stateObject, 9) > 0 || fieldsToClear.Contains(9))
        {
          global::Improbable.Collections.List<ulong> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetUint64Count(stateObject, 9);
            field = new global::Improbable.Collections.List<ulong>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexUint64(stateObject, 9, _i));
            }
          }
          data.field9.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetSint32Count(stateObject, 10) > 0 || fieldsToClear.Contains(10))
        {
          global::Improbable.Collections.List<int> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetSint32Count(stateObject, 10);
            field = new global::Improbable.Collections.List<int>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexSint32(stateObject, 10, _i));
            }
          }
          data.field10.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetSint64Count(stateObject, 11) > 0 || fieldsToClear.Contains(11))
        {
          global::Improbable.Collections.List<long> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetSint64Count(stateObject, 11);
            field = new global::Improbable.Collections.List<long>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexSint64(stateObject, 11, _i));
            }
          }
          data.field11.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetFixed32Count(stateObject, 12) > 0 || fieldsToClear.Contains(12))
        {
          global::Improbable.Collections.List<uint> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetFixed32Count(stateObject, 12);
            field = new global::Improbable.Collections.List<uint>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexFixed32(stateObject, 12, _i));
            }
          }
          data.field12.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetFixed64Count(stateObject, 13) > 0 || fieldsToClear.Contains(13))
        {
          global::Improbable.Collections.List<ulong> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetFixed64Count(stateObject, 13);
            field = new global::Improbable.Collections.List<ulong>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexFixed64(stateObject, 13, _i));
            }
          }
          data.field13.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetSfixed32Count(stateObject, 14) > 0 || fieldsToClear.Contains(14))
        {
          global::Improbable.Collections.List<int> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetSfixed32Count(stateObject, 14);
            field = new global::Improbable.Collections.List<int>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexSfixed32(stateObject, 14, _i));
            }
          }
          data.field14.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetSfixed64Count(stateObject, 15) > 0 || fieldsToClear.Contains(15))
        {
          global::Improbable.Collections.List<long> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetSfixed64Count(stateObject, 15);
            field = new global::Improbable.Collections.List<long>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Worker.Internal.Pbio.IndexSfixed64(stateObject, 15, _i));
            }
          }
          data.field15.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetInt64Count(stateObject, 16) > 0 || fieldsToClear.Contains(16))
        {
          global::Improbable.Collections.List<global::Improbable.EntityId> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetInt64Count(stateObject, 16);
            field = new global::Improbable.Collections.List<global::Improbable.EntityId>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(new global::Improbable.EntityId(global::Improbable.Worker.Internal.Pbio.IndexInt64(stateObject, 16, _i)));
            }
          }
          data.field16.Set(field);
        }
        if (global::Improbable.Worker.Internal.Pbio.GetObjectCount(stateObject, 17) > 0 || fieldsToClear.Contains(17))
        {
          global::Improbable.Collections.List<global::Improbable.Gdk.Tests.SomeType> field;
          {
            var _count = global::Improbable.Worker.Internal.Pbio.GetObjectCount(stateObject, 17);
            field = new global::Improbable.Collections.List<global::Improbable.Gdk.Tests.SomeType>((int) _count);
            for (uint _i = 0; _i < _count; ++_i)
            {
              field.Add(global::Improbable.Gdk.Tests.SomeType_Internal.Read(global::Improbable.Worker.Internal.Pbio.IndexObject(stateObject, 17, _i)));
            }
          }
          data.field17.Set(field);
        }
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Snapshot)
      {
        var data = new Data(global::Improbable.Gdk.Tests.ExhaustiveRepeatedData_Internal.Read(
            global::Improbable.Worker.Internal.Pbio.GetObject(root, 197717)));
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Request)
      {
        var data = new global::Improbable.Worker.Internal.GenericCommandObject();
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
        return 0;
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Response)
      {
        var data = new global::Improbable.Worker.Internal.GenericCommandObject();
        **handleOut = global::Improbable.Worker.Internal.ClientHandles.Instance.CreateHandle(data);
        return 0;
      }
    }
    catch (global::System.Exception e)
    {
      global::Improbable.Worker.ClientError.LogClientException(e);
      return 0;
    }
    return 1;
  }

  [global::Improbable.Worker.Internal.MonoPInvokeCallback(typeof(global::Improbable.Worker.Internal.ComponentProtocol.ClientSerialize))]
  private static unsafe void
  ClientSerialize(global::System.UInt32 componentId,
                  global::System.Byte handleType,
                  global::Improbable.Worker.Internal.ComponentProtocol.ClientHandle* handle,
                  global::Improbable.Worker.Internal.Pbio.Object* root)
  {
    try
    {
      var _pool = global::Improbable.Worker.Internal.ClientHandles.Instance.GetGcHandlePool(*handle);
      if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Update) {
        var data = (Update) global::Improbable.Worker.Internal.ClientHandles.Instance.Dereference(*handle);
        var stateObject = global::Improbable.Worker.Internal.Pbio.AddObject(
            global::Improbable.Worker.Internal.Pbio.AddObject(root, /* entity_state */ 2), 197717);
        if (data.field2.HasValue)
        {
          if (data.field2.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 2);
          }
          for (int _i = 0; _i < data.field2.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddFloat(stateObject, 2, data.field2.Value[_i]);
          }
        }
        if (data.field4.HasValue)
        {
          if (data.field4.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 4);
          }
          for (int _i = 0; _i < data.field4.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddInt32(stateObject, 4, data.field4.Value[_i]);
          }
        }
        if (data.field5.HasValue)
        {
          if (data.field5.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 5);
          }
          for (int _i = 0; _i < data.field5.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddInt64(stateObject, 5, data.field5.Value[_i]);
          }
        }
        if (data.field6.HasValue)
        {
          if (data.field6.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 6);
          }
          for (int _i = 0; _i < data.field6.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddDouble(stateObject, 6, data.field6.Value[_i]);
          }
        }
        if (data.field7.HasValue)
        {
          if (data.field7.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 7);
          }
          for (int _i = 0; _i < data.field7.Value.Count; ++_i)
          {
            if (data.field7.Value[_i] != null)
            {
              var _buffer = global::System.Text.Encoding.UTF8.GetBytes(data.field7.Value[_i]);
              global::Improbable.Worker.Internal.Pbio.AddBytes(stateObject, 7, (byte*) _pool.Pin(_buffer), (uint) _buffer.Length);
            }
            else{
              global::Improbable.Worker.Internal.Pbio.AddBytes(stateObject, 7, null, 0);
            }
          }
        }
        if (data.field8.HasValue)
        {
          if (data.field8.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 8);
          }
          for (int _i = 0; _i < data.field8.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(stateObject, 8, data.field8.Value[_i]);
          }
        }
        if (data.field9.HasValue)
        {
          if (data.field9.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 9);
          }
          for (int _i = 0; _i < data.field9.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint64(stateObject, 9, data.field9.Value[_i]);
          }
        }
        if (data.field10.HasValue)
        {
          if (data.field10.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 10);
          }
          for (int _i = 0; _i < data.field10.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddSint32(stateObject, 10, data.field10.Value[_i]);
          }
        }
        if (data.field11.HasValue)
        {
          if (data.field11.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 11);
          }
          for (int _i = 0; _i < data.field11.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddSint64(stateObject, 11, data.field11.Value[_i]);
          }
        }
        if (data.field12.HasValue)
        {
          if (data.field12.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 12);
          }
          for (int _i = 0; _i < data.field12.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddFixed32(stateObject, 12, data.field12.Value[_i]);
          }
        }
        if (data.field13.HasValue)
        {
          if (data.field13.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 13);
          }
          for (int _i = 0; _i < data.field13.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddFixed64(stateObject, 13, data.field13.Value[_i]);
          }
        }
        if (data.field14.HasValue)
        {
          if (data.field14.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 14);
          }
          for (int _i = 0; _i < data.field14.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddSfixed32(stateObject, 14, data.field14.Value[_i]);
          }
        }
        if (data.field15.HasValue)
        {
          if (data.field15.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 15);
          }
          for (int _i = 0; _i < data.field15.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddSfixed64(stateObject, 15, data.field15.Value[_i]);
          }
        }
        if (data.field16.HasValue)
        {
          if (data.field16.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 16);
          }
          for (int _i = 0; _i < data.field16.Value.Count; ++_i)
          {
            global::Improbable.Worker.Internal.Pbio.AddInt64(stateObject, 16, data.field16.Value[_i].Id);
          }
        }
        if (data.field17.HasValue)
        {
          if (data.field17.Value.Count == 0)
          {
            global::Improbable.Worker.Internal.Pbio.AddUint32(root, /* fields to clear */ 1, 17);
          }
          for (int _i = 0; _i < data.field17.Value.Count; ++_i)
          {
            global::Improbable.Gdk.Tests.SomeType_Internal.Write(_pool, data.field17.Value[_i], global::Improbable.Worker.Internal.Pbio.AddObject(stateObject, 17));
          }
        }
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Snapshot) {
        var data = (Data) global::Improbable.Worker.Internal.ClientHandles.Instance.Dereference(*handle);
        global::Improbable.Gdk.Tests.ExhaustiveRepeatedData_Internal.Write(_pool, data.Value, global::Improbable.Worker.Internal.Pbio.AddObject(root, 197717));
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Request)
      {
        global::Improbable.Worker.Internal.Pbio.AddObject(root, 197717);
      }
      else if (handleType == (byte) global::Improbable.Worker.Internal.ComponentProtocol.ClientHandleType.Response)
      {
        global::Improbable.Worker.Internal.Pbio.AddObject(root, 197717);
      }
    }
    catch (global::System.Exception e)
    {
      global::Improbable.Worker.ClientError.LogClientException(e);
    }
  }
}

}
