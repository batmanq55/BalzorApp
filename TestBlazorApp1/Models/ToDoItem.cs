﻿namespace TestBlazorApp1.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        private bool _isCompleted;
        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                _isCompleted = value;
                if (_isCompleted)
                    DateCompleted = DateTime.Now;
            }
        }
        public DateTime DateCompleted { get; set; }
    }
}
