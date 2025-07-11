using HotelBookingSystem.Dto;
using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;

namespace HotelBookingSystem.Service
{
    public class RoomService:IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<List<Room>> GetAllRoomsAsync()
        {
            return await _roomRepository.GetAllRoomsAsync();
        }

        public async Task<List<Room>> GetAvailableRoomsAsync()
        {
            return await _roomRepository.GetAvailableRoomsAsync();
        }

        public async Task<Room> GetRoomByIdAsync(int id)
        {
            return await _roomRepository.GetRoomByIdAsync(id);
        }

        public async Task AddRoomAsync(RoomDto roomDto)
        {
            var room = new Room
            {
                RoomNumber = roomDto.RoomNumber,
                RoomType = roomDto.RoomType,
                Price = roomDto.Price,
                IsAvailable = roomDto.IsAvailable
            };

            await _roomRepository.AddRoomAsync(room);
        }

        public async Task UpdateRoomAsync(RoomDto roomDto)
        {
            var room = await _roomRepository.GetRoomByIdAsync(roomDto.Id);
            if (room != null)
            {
                room.RoomNumber = roomDto.RoomNumber;
                room.RoomType = roomDto.RoomType;
                room.Price = roomDto.Price;
                room.IsAvailable = roomDto.IsAvailable;

                await _roomRepository.UpdateRoomAsync(room);
            }
        }

        public async Task DeleteRoomAsync(int id)
        {
            await _roomRepository.DeleteRoomAsync(id);
        }
    }
}
