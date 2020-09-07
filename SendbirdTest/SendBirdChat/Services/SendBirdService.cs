using System;
using System.Threading.Tasks;
using SendbirdTest.SendBirdChat.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using SendBird;
using System.Collections.Generic;

namespace SendbirdTest.SendBirdChat.Services
{
    public class SendbirdService : ISendbirdService
    {


        public SendbirdService(String AppId, String UserId)
        {
            try
            { SendBirdClient.Init(AppId); }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e}");
            }
            /* SendBirdClient.Connect(UserId, (User user, SendBirdException e) =>
             {
                 if (e != null)
                 {
                     // Error
                     return;
                 }
             });*/

        }

        /************IClientChatService*/

        public bool IsConnected => throw new NotImplementedException();

        public event EventHandler<BaseMessage> OnMessageReceived;

        public string GetConnectionStatus()
        {

            return SendBirdClient.GetConnectionState().ToString();
        }

        public Task<GroupChannel> CreateRoom(GroupChannel room)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRoom(GroupChannel room)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<BaseMessage>> GetMessages(Guid roomId, int count)
        {
            throw new NotImplementedException();
        }

        public Task<GroupChannel> GetRoom(Guid roomId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<GroupChannel>> GetRooms()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Guid>> GetRoomUsers(Guid roomId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<Guid>> GetUsersRooms(Guid userId)
        {
            throw new NotImplementedException();
        }

        /* public Task Init(SendBirdClient sendBirdClient)
         {
             SendBirdClient.Init("123");
             throw new NotImplementedException();
         }*/

        public Task JoinRoom()
        {
            throw new NotImplementedException();
        }

        public Task<GroupChannel> JoinRoom(Guid userId, Guid roomId)
        {
            throw new NotImplementedException();
        }

        public Task LeaveRoom(Guid userId, Guid roomId)
        {
            throw new NotImplementedException();
        }

        public Task SendMessage(BaseMessage message)
        {
            throw new NotImplementedException();
        }

        public Task SignIn()
        {
            throw new NotImplementedException();
        }

        public Task SubmitMessage(KeyboardEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
