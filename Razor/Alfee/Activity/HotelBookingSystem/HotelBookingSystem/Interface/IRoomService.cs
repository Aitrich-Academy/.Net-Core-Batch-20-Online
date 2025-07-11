using HotelBookingSystem.Dto;
using HotelBookingSystem.Model;

namespace HotelBookingSystem.Interface
{
    public interface IRoomService
    {
        Task<List<Room>> GetAllRoomsAsync();
        Task<List<Room>> GetAvailableRoomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task AddRoomAsync(RoomDto roomDto);
        Task UpdateRoomAsync(RoomDto roomDto);
        Task DeleteRoomAsync(int id);
    }
}
