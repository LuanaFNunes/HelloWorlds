using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using SendBird;

namespace SendbirdTest.SendBirdChat.Interfaces
{
    public interface ISendbirdService : IDisposable
    {
        event EventHandler<BaseMessage> OnMessageReceived;

        bool IsConnected { get; }

        #region Messages

        Task<IReadOnlyCollection<BaseMessage>> GetMessages(Guid roomId, int count);
        Task SendMessage(BaseMessage message);

        #endregion

        #region Rooms

        Task<GroupChannel> CreateRoom(GroupChannel room);
        Task DeleteRoom(GroupChannel room);
        Task<GroupChannel> JoinRoom(Guid userId, Guid roomId);
        Task LeaveRoom(Guid userId, Guid roomId);
        Task<IReadOnlyCollection<Guid>> GetUsersRooms(Guid userId);
        Task<IReadOnlyCollection<Guid>> GetRoomUsers(Guid roomId);

        Task<GroupChannel> GetRoom(Guid roomId);
        Task<IReadOnlyCollection<GroupChannel>> GetRooms();

        #endregion

        /************IChatHub end*/
        Task SignIn();

        Task JoinRoom();

        Task SubmitMessage(KeyboardEventArgs e);

    }
}
