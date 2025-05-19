namespace TestBlazorApp1.Models
{
    public static class ToDoItemsRepository
    {
        public static List<ToDoItem> items = new List<ToDoItem>()
        {
                new ToDoItem{ Id=1, Name="Item 1" },
                new ToDoItem{ Id=2, Name="Item 2" },
                new ToDoItem{ Id=3, Name="Item 3" },
                new ToDoItem{ Id=4, Name="Item 4" },
        };
        public static List<ToDoItem> GetItems()
        {
           return items.
                OrderBy(x => x.IsCompleted)
                .ThenByDescending(item => item.Id)
              .ToList();
        }
        public static void AddItem(ToDoItem item)
        {
            if (items.Count > 0)
            {
                var maxId = items.Max(s => s.Id);
                item.Id = maxId + 1;
                items.Add(item);
            }
            else
            {
                item.Id = 1;
                items.Add(item);
            }
        }

        public static void UpdateItem(ToDoItem item)
        {
            if (items.Any(i => i.Id == item.Id))
            {
                var itemDetails = items.FirstOrDefault(s => s.Id == item.Id);
                itemDetails.Name = item.Name;
            }
        }
    }
}
