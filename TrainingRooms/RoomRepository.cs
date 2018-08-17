using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace TrainingRooms
{
    public class RoomRepository
    {
        private List<TrainingRoom> _rooms = new List<TrainingRoom>
        {
            new TrainingRoom
            {
                Id = 1,
                Name = "Virgo",
                Location = "Building 1",
                NumberComputers = 45
            },
            new TrainingRoom
            {
                Id = 2,
                Name = "Sagitarius",
                Location = "Building 1",
                NumberComputers = 3
            },
            new TrainingRoom
            {
                Id = 3,
                Name = "Solar",
                Location = "External",
                NumberComputers = 12
            },
            new TrainingRoom
            {
                Id = 4,
                Name = "Lunar",
                Location = "Building 4",
                NumberComputers = 18
            }

        };

        public RoomRepository()
        {
            
        }

        public List<TrainingRoom> GetRooms()
        {
            return _rooms;
        }

        public TrainingRoom GetRoom(int id)
        {
            return _rooms.FirstOrDefault(x => x.Id == id);

        }
    }
}