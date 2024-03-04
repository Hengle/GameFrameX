using Server.Extension;
using Server.NetWork;
using Server.NetWork.Messages;
using Server.Proto;
using Server.Serialize.Serialize;

namespace Server.Launcher.Message;

class MessageDecoderHandler : IMessageDecoderHandler
{
    public IMessage Handler(Span<byte> data)
    {
        int readOffset = 0;
        var length = data.ReadInt(ref readOffset);
        var timestamp = data.ReadLong(ref readOffset);
        var messageId = data.ReadInt(ref readOffset);
        // var messageUniqueData = data.ReadBytes(ref readOffset);
        var messageData = data.ReadBytes(ref readOffset);
        var messageType = ProtoMessageIdHandler.GetReqTypeById(messageId);
        var message = (IMessage)SerializerHelper.Deserialize(messageData, messageType);
        return message;
    }
}