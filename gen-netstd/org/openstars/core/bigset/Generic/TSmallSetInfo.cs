/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace org.openstars.core.bigset.Generic
{

  public partial class TSmallSetInfo : TBase
  {
    private int _count;
    private byte[] _midItem;
    private int _countFromMid;
    private long _prev;
    private long _nxt;

    public int Count
    {
      get
      {
        return _count;
      }
      set
      {
        __isset.count = true;
        this._count = value;
      }
    }

    public byte[] MidItem
    {
      get
      {
        return _midItem;
      }
      set
      {
        __isset.midItem = true;
        this._midItem = value;
      }
    }

    public int CountFromMid
    {
      get
      {
        return _countFromMid;
      }
      set
      {
        __isset.countFromMid = true;
        this._countFromMid = value;
      }
    }

    public long Prev
    {
      get
      {
        return _prev;
      }
      set
      {
        __isset.prev = true;
        this._prev = value;
      }
    }

    public long Nxt
    {
      get
      {
        return _nxt;
      }
      set
      {
        __isset.nxt = true;
        this._nxt = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool count;
      public bool midItem;
      public bool countFromMid;
      public bool prev;
      public bool nxt;
    }

    public TSmallSetInfo()
    {
      this._prev = 0;
      this.__isset.prev = true;
      this._nxt = 0;
      this.__isset.nxt = true;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Count = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                MidItem = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                CountFromMid = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Prev = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                Nxt = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TSmallSetInfo");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (__isset.count)
        {
          field.Name = "count";
          field.Type = TType.I32;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(Count, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (MidItem != null && __isset.midItem)
        {
          field.Name = "midItem";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(MidItem, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.countFromMid)
        {
          field.Name = "countFromMid";
          field.Type = TType.I32;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(CountFromMid, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.prev)
        {
          field.Name = "prev";
          field.Type = TType.I64;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Prev, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.nxt)
        {
          field.Name = "nxt";
          field.Type = TType.I64;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI64Async(Nxt, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as TSmallSetInfo;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.count == other.__isset.count) && ((!__isset.count) || (System.Object.Equals(Count, other.Count))))
        && ((__isset.midItem == other.__isset.midItem) && ((!__isset.midItem) || (System.Object.Equals(MidItem, other.MidItem))))
        && ((__isset.countFromMid == other.__isset.countFromMid) && ((!__isset.countFromMid) || (System.Object.Equals(CountFromMid, other.CountFromMid))))
        && ((__isset.prev == other.__isset.prev) && ((!__isset.prev) || (System.Object.Equals(Prev, other.Prev))))
        && ((__isset.nxt == other.__isset.nxt) && ((!__isset.nxt) || (System.Object.Equals(Nxt, other.Nxt))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.count)
          hashcode = (hashcode * 397) + Count.GetHashCode();
        if(__isset.midItem)
          hashcode = (hashcode * 397) + MidItem.GetHashCode();
        if(__isset.countFromMid)
          hashcode = (hashcode * 397) + CountFromMid.GetHashCode();
        if(__isset.prev)
          hashcode = (hashcode * 397) + Prev.GetHashCode();
        if(__isset.nxt)
          hashcode = (hashcode * 397) + Nxt.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TSmallSetInfo(");
      bool __first = true;
      if (__isset.count)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Count: ");
        sb.Append(Count);
      }
      if (MidItem != null && __isset.midItem)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("MidItem: ");
        sb.Append(MidItem);
      }
      if (__isset.countFromMid)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("CountFromMid: ");
        sb.Append(CountFromMid);
      }
      if (__isset.prev)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Prev: ");
        sb.Append(Prev);
      }
      if (__isset.nxt)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Nxt: ");
        sb.Append(Nxt);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}