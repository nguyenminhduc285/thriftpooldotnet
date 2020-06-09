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

  public partial class TSetMetaPath : TBase
  {
    private List<TSetMetaPathItem> _metaPath;
    private TSetMetaPathItem _smallSetInfo;
    private TNeedSplitInfo _splitInfo;

    public List<TSetMetaPathItem> MetaPath
    {
      get
      {
        return _metaPath;
      }
      set
      {
        __isset.metaPath = true;
        this._metaPath = value;
      }
    }

    public TSetMetaPathItem SmallSetInfo
    {
      get
      {
        return _smallSetInfo;
      }
      set
      {
        __isset.smallSetInfo = true;
        this._smallSetInfo = value;
      }
    }

    public TNeedSplitInfo SplitInfo
    {
      get
      {
        return _splitInfo;
      }
      set
      {
        __isset.splitInfo = true;
        this._splitInfo = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool metaPath;
      public bool smallSetInfo;
      public bool splitInfo;
    }

    public TSetMetaPath()
    {
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
              if (field.Type == TType.List)
              {
                {
                  TList _list12 = await iprot.ReadListBeginAsync(cancellationToken);
                  MetaPath = new List<TSetMetaPathItem>(_list12.Count);
                  for(int _i13 = 0; _i13 < _list12.Count; ++_i13)
                  {
                    TSetMetaPathItem _elem14;
                    _elem14 = new TSetMetaPathItem();
                    await _elem14.ReadAsync(iprot, cancellationToken);
                    MetaPath.Add(_elem14);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                SmallSetInfo = new TSetMetaPathItem();
                await SmallSetInfo.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                SplitInfo = new TNeedSplitInfo();
                await SplitInfo.ReadAsync(iprot, cancellationToken);
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
        var struc = new TStruct("TSetMetaPath");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (MetaPath != null && __isset.metaPath)
        {
          field.Name = "metaPath";
          field.Type = TType.List;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, MetaPath.Count), cancellationToken);
            foreach (TSetMetaPathItem _iter15 in MetaPath)
            {
              await _iter15.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (SmallSetInfo != null && __isset.smallSetInfo)
        {
          field.Name = "smallSetInfo";
          field.Type = TType.Struct;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await SmallSetInfo.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (SplitInfo != null && __isset.splitInfo)
        {
          field.Name = "splitInfo";
          field.Type = TType.Struct;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await SplitInfo.WriteAsync(oprot, cancellationToken);
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
      var other = that as TSetMetaPath;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.metaPath == other.__isset.metaPath) && ((!__isset.metaPath) || (TCollections.Equals(MetaPath, other.MetaPath))))
        && ((__isset.smallSetInfo == other.__isset.smallSetInfo) && ((!__isset.smallSetInfo) || (System.Object.Equals(SmallSetInfo, other.SmallSetInfo))))
        && ((__isset.splitInfo == other.__isset.splitInfo) && ((!__isset.splitInfo) || (System.Object.Equals(SplitInfo, other.SplitInfo))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.metaPath)
          hashcode = (hashcode * 397) + TCollections.GetHashCode(MetaPath);
        if(__isset.smallSetInfo)
          hashcode = (hashcode * 397) + SmallSetInfo.GetHashCode();
        if(__isset.splitInfo)
          hashcode = (hashcode * 397) + SplitInfo.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TSetMetaPath(");
      bool __first = true;
      if (MetaPath != null && __isset.metaPath)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("MetaPath: ");
        sb.Append(MetaPath);
      }
      if (SmallSetInfo != null && __isset.smallSetInfo)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("SmallSetInfo: ");
        sb.Append(SmallSetInfo== null ? "<null>" : SmallSetInfo.ToString());
      }
      if (SplitInfo != null && __isset.splitInfo)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("SplitInfo: ");
        sb.Append(SplitInfo== null ? "<null>" : SplitInfo.ToString());
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
