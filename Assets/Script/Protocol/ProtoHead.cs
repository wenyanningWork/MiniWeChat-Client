//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ProtoHead.proto
namespace protocol
{
    [global::ProtoBuf.ProtoContract(Name=@"ENetworkMessage")]
    public enum ENetworkMessage
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"KEEP_ALIVE_SYNC", Value=0)]
      KEEP_ALIVE_SYNC = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REGISTER_REQ", Value=1)]
      REGISTER_REQ = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"REGISTER_RSP", Value=2)]
      REGISTER_RSP = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_REQ", Value=3)]
      LOGIN_REQ = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGIN_RSP", Value=4)]
      LOGIN_RSP = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PERSONALSETTINGS_REQ", Value=5)]
      PERSONALSETTINGS_REQ = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PERSONALSETTINGS_RSP", Value=6)]
      PERSONALSETTINGS_RSP = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_USERINFO_REQ", Value=7)]
      GET_USERINFO_REQ = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_USERINFO_RSP", Value=8)]
      GET_USERINFO_RSP = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADD_FRIEND_REQ", Value=9)]
      ADD_FRIEND_REQ = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADD_FRIEND_RSP", Value=10)]
      ADD_FRIEND_RSP = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DELETE_FRIEND_REQ", Value=11)]
      DELETE_FRIEND_REQ = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DELETE_FRIEND_RSP", Value=12)]
      DELETE_FRIEND_RSP = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OFFLINE_SYNC", Value=13)]
      OFFLINE_SYNC = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGOUT_REQ", Value=14)]
      LOGOUT_REQ = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"LOGOUT_RSP", Value=15)]
      LOGOUT_RSP = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_PERSONALINFO_REQ", Value=16)]
      GET_PERSONALINFO_REQ = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GET_PERSONALINFO_RSP", Value=17)]
      GET_PERSONALINFO_RSP = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_FRIEND_SYNC", Value=18)]
      CHANGE_FRIEND_SYNC = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SEND_CHAT_REQ", Value=19)]
      SEND_CHAT_REQ = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SEND_CHAT_RSP", Value=20)]
      SEND_CHAT_RSP = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RECEIVE_CHAT_SYNC", Value=21)]
      RECEIVE_CHAT_SYNC = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CREATE_GROUP_CHAT_REQ", Value=22)]
      CREATE_GROUP_CHAT_REQ = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CREATE_GROUP_CHAT_RSP", Value=23)]
      CREATE_GROUP_CHAT_RSP = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_GROUP_CHAT_MEMBER_REQ", Value=24)]
      CHANGE_GROUP_CHAT_MEMBER_REQ = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CHANGE_GROUP_CHAT_MEMBER__RSP", Value=25)]
      CHANGE_GROUP_CHAT_MEMBER__RSP = 25
    }
  
}