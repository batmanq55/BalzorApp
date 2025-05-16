
namespace TestBlazorApp1.Models
{
    public static class ServerDetailssRepository
    {
        private static List<ServerDetails> ServerDetailss = new List<ServerDetails>()
        {
            new ServerDetails {  ServerId = 1, Name = "ServerDetails1", City = "Toronto" },
            new ServerDetails { ServerId = 2, Name = "ServerDetails2", City = "Toronto" },
            new ServerDetails { ServerId = 3, Name = "ServerDetails3", City = "Toronto" },
            new ServerDetails { ServerId = 4, Name = "ServerDetails4", City = "Toronto" },
            new ServerDetails { ServerId = 5, Name = "ServerDetails5", City = "Montreal" },
            new ServerDetails { ServerId = 6, Name = "ServerDetails6", City = "Montreal" },
            new ServerDetails { ServerId = 7, Name = "ServerDetails7", City = "Montreal" },
            new ServerDetails { ServerId = 8, Name = "ServerDetails8", City = "Ottawa" },
            new ServerDetails { ServerId = 9, Name = "ServerDetails9", City = "Ottawa" },
            new ServerDetails { ServerId = 10, Name = "ServerDetails10", City = "Calgary" },
            new ServerDetails { ServerId = 11, Name = "ServerDetails11", City = "Calgary" },
            new ServerDetails { ServerId = 12, Name = "ServerDetails12", City = "Halifax" },
            new ServerDetails { ServerId = 13, Name = "ServerDetails13", City = "Halifax" },
        };

        public static void AddServerDetails(ServerDetails ServerDetails)
        {
            var maxId = ServerDetailss.Max(s => s.ServerId);
            ServerDetails.ServerId = maxId + 1;
            ServerDetailss.Add(ServerDetails);
        }

        public static List<ServerDetails> GetServres() => ServerDetailss;

        public static List<ServerDetails> GetServerDetailssByCity(string cityName)
        {
            return ServerDetailss.Where(s => s.City.Equals(cityName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static ServerDetails? GetServerDetailsById(int id)
        {
            var ServerDetails = ServerDetailss.FirstOrDefault(s => s.ServerId == id);
            if (ServerDetails != null)
            {
                return new ServerDetails
                {
                    ServerId = ServerDetails.ServerId,
                    Name = ServerDetails.Name,
                    City = ServerDetails.City,
                    IsOnline = ServerDetails.IsOnline
                };
            }
            return null;
        }

        public static void UpdateServerDetails(int ServerDetailsId, ServerDetails ServerDetails)
        {
            if (ServerDetailsId != ServerDetails.ServerId) return;

            var ServerDetailsToUpdate = ServerDetailss.FirstOrDefault(s => s.ServerId == ServerDetailsId);
            if (ServerDetailsToUpdate != null)
            {
                ServerDetailsToUpdate.IsOnline = ServerDetails.IsOnline;
                ServerDetailsToUpdate.Name = ServerDetails.Name;
                ServerDetailsToUpdate.City = ServerDetails.City;
            }
        }

        public static void DeleteServerDetails(int ServerDetailsId)
        {
            var ServerDetails = ServerDetailss.FirstOrDefault(s => s.ServerId == ServerDetailsId);
            if (ServerDetails != null)
            {
                ServerDetailss.Remove(ServerDetails);
            }
        }

        public static List<ServerDetails> SearchServerDetailss(string ServerDetailsFilter)
        {
            return ServerDetailss.Where(s => s.Name.Contains(ServerDetailsFilter, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
