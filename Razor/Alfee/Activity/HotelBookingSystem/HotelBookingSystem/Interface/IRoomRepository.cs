using HotelBookingSystem.Model;

namespace HotelBookingSystem.Interface
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetAllRoomsAsync();
        Task<List<Room>> GetAvailableRoomsAsync();
        Task<Room> GetRoomByIdAsync(int id);
        Task AddRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(int id);
    }
}
